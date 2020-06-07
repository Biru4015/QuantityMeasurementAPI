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

        /// <summary>
        /// This action verb is created for converting kilogram to gram
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        [Route("KilogramToGram")]
        [HttpPost]
        public IActionResult KilogramToGram(WeightUnit value)
        {
            var result = this.manager.KilogramToGram(value);

            if (result >= 0)
            {
                return this.Ok(new { output = result });
            }
            return this.BadRequest(new { error = "Conversion not possible" });
        }

        /// <summary>
        /// This action verb is created for converting gram to kilogram
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        [Route("GramToKilogram")]
        [HttpPost]
        public IActionResult GramToKilogram(WeightUnit value)
        {
            var result = this.manager.GramToKilogram(value);

            if (result >= 0)
            {
                return this.Ok(new { output = result });
            }
            return this.BadRequest(new { error = "Conversion not possible" });
        }

        /// <summary>
        /// This action verb is created for converting tonne to kilogram
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        [Route("TonneToKilogram")]
        [HttpPost]
        public IActionResult TonneToKilogram(WeightUnit value)
        {
            var result = this.manager.TonneToKilogram(value);

            if (result >= 0)
            {
                return this.Ok(new { output = result });
            }
            return this.BadRequest(new { error = "Conversion not possible" });
        }

        /// <summary>
        /// This action verb is created for converting kilogram to tonne
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        [Route("KilogramToTonne")]
        [HttpPost]
        public IActionResult KilogramTonee(WeightUnit value)
        {
            var result = this.manager.KilogramToTonne(value);

            if (result >= 0)
            {
                return this.Ok(new { output = result });
            }
            return this.BadRequest(new { error = "Conversion not possible" });
        }
    }
}