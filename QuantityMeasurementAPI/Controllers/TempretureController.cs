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

        /// <summary>
        /// This action verb is created for conveting fahrenhiet to celcius
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        [Route("FahrenhietToCelcius")]
        [HttpPost]
        public IActionResult FahrenhietToCelcius(TempretureUnit value)
        {
            var result = this.manager.FahrenhietToCelcius(value);

            if (result >= 0)
            {
                return this.Ok(new { output = result });
            }
            return this.BadRequest(new { error = "Conversion not possible" });
        }

        /// <summary>
        /// This action verbs is created for converting celcius to fahrenheit
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        [Route("CelciusToFahrenhiet")]
        [HttpPost]
        public IActionResult CelciusToFahrenhiet(TempretureUnit value)
        {
            var result = this.manager.CelciusToFahrenhiet(value);

            if (result >= 0)
            {
                return this.Ok(new { output = result });
            }
            return this.BadRequest(new { error = "Conversion not possible" });
        }
    }
}