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
    public class WeightController : ControllerBase
    {
        /// <summary>
        /// Calling QuantityMeasuremnet Interface
        /// </summary>
        public IQuantityMeasurementManager manager;
        public WeightController(IQuantityMeasurementManager manager)
        {
            this.manager = manager;
        }


        [HttpPost]
        public IActionResult WeightPost(WeightUnit value)
        {
            var res = manager.WeightPost(value);

            try
            {
                object result;
                switch (value.WeightOptions)
                {
                    case "KilogramToGram":
                        result = this.Ok(new { Gram = String.Format("{0:0.00}", res) });
                        break;
                    case "GramToKilogram":
                        result = this.Ok(new { Kilogram = String.Format("{0:0.00}", res) });
                        break;
                    case "TonneToKilogram":
                        result = this.Ok(new { Kilogram = String.Format("{0:0.00}", res) });
                        break;
                    case "KilogramToTonne":
                        result = this.Ok(new { Tonne = String.Format("{0:0.00}", res) });
                        break;
                    default:
                        result = this.BadRequest(new { error = "Conversion not possible" });
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