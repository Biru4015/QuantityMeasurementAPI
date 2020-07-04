using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using QuantityMeasurementManager.IQuantityManager;
using QuantityMeasurementModel;

namespace QuantityMeasurementAPICiCd.Controllers
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
        [Route("LengthPost")]
        public IActionResult LengthPost(LengthUnit value)
        {
            var res = manager.LengthPost(value);
            try
            {
                if (value.OptionType == OptionType.InchToFeet.ToString())
                    return this.Ok(new { output = res });
                else if (value.OptionType == OptionType.FeetToInch.ToString())
                    return this.Ok(new { output = res });
                else if (value.OptionType == OptionType.InchToCentiMeter.ToString())
                    return this.Ok(new { output = res });
                else if (value.OptionType == OptionType.CentiMeterToInch.ToString())
                    return this.Ok(new { output = res });
                else if (value.OptionType == OptionType.FeetToYard.ToString())
                    return this.Ok(new { output = res });
                else if (value.OptionType == OptionType.YardToFeet.ToString())
                    return this.Ok(new { output = res });
                else
                    return this.BadRequest(new { error = "Conversion not possible" });
            }
            catch (CustomException)
            {
                return BadRequest(CustomException.ExceptionType.TYPE_NOT_MATCH);
            }
        }
    }
}