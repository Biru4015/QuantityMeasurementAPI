using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using QuantityMeasurementManager.IQuantityManager;
using QuantityMeasurementModel;

namespace QuantityMeasurementApplication.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LengthController : ControllerBase
    {
        /// <summary>
        /// Calling QuantityMeasuremnet Interface
        /// </summary>
        public IQuantityMeasurementManager manager;

        /// <summary>
        /// Parameterized constructor
        /// </summary>
        /// <param name="manager"></param>
        public LengthController(IQuantityMeasurementManager manager)
        {
            this.manager = manager;
        }

        /// <summary>
        /// This action verb is created for adding feet to inch conversion
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>

        [HttpPost]
        public IActionResult LengthPost(LengthUnit value)
        {
            var res = manager.LengthPost(value);
            
            try
            {
                object result;
                switch (value.LengthOptions)
                {
                    case "InchToFeet":
                         result= this.Ok(new { Feet = String.Format("{0:0.00}", res) });
                        break;
                    case "FeetToInch":
                         result = this.Ok(new { Inch = String.Format("{0:0.00}", res) });
                        break;
                    case "InchToCentiMeter":
                         result = this.Ok(new { Centimeter = String.Format("{0:0.00}", res) });
                        break;
                    case "CentiMeterToInch":
                        result = this.Ok(new { Inch = String.Format("{0:0.00}", res) });
                        break;
                    case "FeetToYard":
                         result = this.Ok(new { Yard = String.Format("{0:0.00}", res) });
                        break;
                    case "YardToFeet":
                        result= this.Ok(new { Feet = String.Format("{0:0.00}", res) });
                        break;
                    default:
                        result= this.BadRequest(new { error = "Conversion not possible" });
                        break;

                }
                return (IActionResult)result;
            }
            catch (CustomException)
            {
                return BadRequest(CustomException.ExceptionType.TYPE_NOT_MATCH);
            }
        }
    }
}