using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using QuantityMeasurementManager.IQuantityManager;
using QuantityMeasurementModel;

namespace QuantityMeasurementAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TempretureController : ControllerBase
    {
        /// <summary>
        /// Calling QuantityMeasuremnet Interface
        /// </summary>
        public IQuantityMeasurementManager manager;
        public TempretureController(IQuantityMeasurementManager manager)
        {
            this.manager = manager;
        }

        [Route("TempreturePost")]
        [HttpPost]
        public IActionResult TempreturePost(TempretureUnit value)
        {
            var res = manager.TempreturePost(value);
            try
            {
                if (value.OptionType == OptionType.CelciusToFahrenhiet.ToString())
                    return this.Ok(new { output = res });
                else if (value.OptionType == OptionType.FahrenhietToCelcius.ToString())
                    return this.Ok(new { output = res });
                return this.BadRequest(new { error = "Conversion not possible" });
            }
            catch (CustomException)
            {
                return BadRequest(CustomException.ExceptionType.TYPE_NOT_MATCH);
            }
        }
    }
}