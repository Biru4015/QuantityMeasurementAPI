namespace QuantityMeasurementAPI.Controllers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Http;
    using Microsoft.AspNetCore.Mvc;
    using QuantityMeasurementManager.IQuantityManager;
    using QuantityMeasurementModel;

    /// <summary>
    /// This is controller class
    /// </summary>
    [Route("api/[controller]")]
    [ApiController]
    public class QuantityMeasurementController : ControllerBase
    {
        /// <summary>
        /// Calling QuantityMeasuremnet Interface
        /// </summary>
        public IQuantityMeasurementManager manager;

        /// <summary>
        /// Parameterized constructor
        /// </summary>
        /// <param name="manager"></param>
        public QuantityMeasurementController(IQuantityMeasurementManager manager)
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
                return this.Ok(result);
            }
            return this.BadRequest();
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
                return this.Ok(result);
            }
            return this.BadRequest();
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
                return this.Ok(result);
            }
            return this.BadRequest();
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
                return this.Ok(result);
            }
            return this.BadRequest();
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
                return this.Ok(result);
            }
            return this.BadRequest();
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
            {
                return this.Ok(result);
            }
            return this.BadRequest();
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
                return this.Ok(result);
            }
            return this.BadRequest();
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
                return this.Ok(result);
            }
            return this.BadRequest();
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
                return this.Ok(result);
            }
            return this.BadRequest();
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
                return this.Ok(result);
            }
            return this.BadRequest();
        }

        /// <summary>
        /// This action verb is created for converting litre to gallon
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        [Route("LitreToGallon")]
        [HttpPost]
        public IActionResult LitreToGallon(VolumeUnit value)
        {
            var result = this.manager.LitreToGallon(value);

            if (result >= 0)
            {
                return this.Ok(result);
            }
            return this.BadRequest();
        }

        /// <summary>
        /// This action verb is created for converting gallon to litre
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        [Route("GallonToLitre")]
        [HttpPost]
        public IActionResult GallonToLitre(VolumeUnit value)
        {
            var result = this.manager.GallonToLitre(value);

            if (result >= 0)
            {
                return this.Ok(result);
            }
            return this.BadRequest();
        }

        /// <summary>
        /// This action verbs is created for converting litre to mililitre
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        [Route("LitreToMiliLitre")]
        [HttpPost]
        public IActionResult LitreToMiliLitre(VolumeUnit value)
        {
            var result = this.manager.LitreToMiliLitre(value);

            if (result >= 0)
            {
                return this.Ok(result);
            }
            return this.BadRequest();
        }

        /// <summary>
        /// This action verb is created for converting mililitre to litre
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        [Route("MiliLitreToLitre")]
        [HttpPost]
        public IActionResult MiliLitreToLitre(VolumeUnit value)
        {
            var result = this.manager.LitreToMiliLitre(value);

            if (result >= 0)
            {
                return this.Ok(result);
            }
            return this.BadRequest();
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
                return this.Ok(result);
            }
            return this.BadRequest();
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
                return this.Ok(result);
            }
            return this.BadRequest();
        }
    }
}