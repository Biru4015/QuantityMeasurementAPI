namespace QuantityMeasurementAPI.Controllers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Http;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.CodeAnalysis.CSharp;
    using QuantityMeasurementManager.IQuantityManager;
    using QuantityMeasurementModel;

    /// <summary>
    /// This is controller class
    /// </summary>
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
        [Route("FeetToInch")]
        [HttpPost]
        public IActionResult FeetToInch(LengthUnit value)
        {
            var result = this.manager.FeetToInch(value);

            if (result >= 0)
            {
                return this.Ok(new { output=result });
            }
            return this.BadRequest(new { error="Conversion not possible"});
        }

        /// <summary>
        /// This action verb is created for converting inch to feet
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        [Route("InchToFeet")]
        [HttpPost]
        public IActionResult InchToFeet(LengthUnit value)
        {
            var result = this.manager.InchToFeet(value);

            if (result >= 0)
            {
                return this.Ok(new { output = result });
            }
            return this.BadRequest(new { error = "Conversion not possible" });
        }

        /// <summary>
        /// This action verbs is adding inch to centimeter
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        [Route("InchToCentimeter")]
        [HttpPost]
        public IActionResult InchToCentimeter(LengthUnit value)
        {
            var result = this.manager.InchToCentiMeter(value);

            if (result >= 0)
            {
                return this.Ok(new { output = result });
            }
            return this.BadRequest(new { error = "Conversion not possible" });
        }

        /// <summary>
        /// This action verb is created for converting centimeter to inch
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        [Route("CentimeterToInch")]
        [HttpPost]
        public IActionResult CentimeterToInch(LengthUnit value)
        {
            var result = this.manager.CentiMeterToInch(value);

            if (result >= 0)
            {
                return this.Ok(new { output = result });
            }
            return this.BadRequest(new { error = "Conversion not possible" });
        }

        /// <summary>
        /// This action verbs is created for converting yard to feet
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        [Route("YardToFeet")]
        [HttpPost]
        public IActionResult YardToFeet(LengthUnit value)
        {
            var result = this.manager.YardToFeet(value);

            if (result >= 0)
            {
                return this.Ok(new { output = result });
            }
            return this.BadRequest(new { error = "Conversion not possible" });
        }

        /// <summary>
        /// This action verb is created for converting feet to yard
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        [Route("FeetToYard")]
        [HttpPost]
        public IActionResult FeetToYard(LengthUnit value)
        {
            var result = this.manager.FeetToYard(value);

            if (result >= 0)
                if (result >= 0)
                {
                    return this.Ok(new { output = result });
                }
            return this.BadRequest(new { error = "Conversion not possible" });
        }
    }
}