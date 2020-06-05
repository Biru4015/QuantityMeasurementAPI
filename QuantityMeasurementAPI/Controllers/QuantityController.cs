namespace QuantityMeasurementAPI.Controllers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Http;
    using Microsoft.AspNetCore.Mvc;
    using QuantityManagerLayer.IManager;
    using QuantityModelLayer.Model;

    /// <summary>
    /// This is controller class
    /// </summary>
    [Route("api/[controller]")]
    [ApiController]
    public class QuantityController : ControllerBase
    {
        /// <summary>
        /// This is object of IQuantityManager
        /// </summary>
        public readonly IQuantityManager manager;

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="manager"></param>
        public QuantityController(IQuantityManager manager)
        {
            this.manager = manager;
        }

        /// <summary>
        /// Adding length conversion
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        [HttpPost]
        [Route("length")]
        public ActionResult PostAllLength(Length model)
        {

            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            var res = manager.PostAllLength(model);
            try
            {
                if (model.OptionType == OptionType.InchToFeet.ToString())
                {
                    return Ok(res);
                }
                else if (model.OptionType == OptionType.FeetToInch.ToString())
                {
                    return Ok(res);
                }
                else if (model.OptionType == OptionType.YardToInch.ToString())
                {
                    return Ok(res);
                }
                else
                {
                    return NotFound();
                }
            }
            catch (CustomException)
            {
                return BadRequest(CustomException.ExceptionType.TYPE_NOT_MATCH);
            }
        }

        /// <summary>
        /// This action verb is created for updating length conversion
        /// </summary>
        /// <param name="lengthChanges"></param>
        /// <returns></returns>
        [Route("UpdateLength")]
        [HttpPut]
        public async Task<IActionResult> UpdateLength(Length lengthChanges)
        {
            var result = await this.manager.UpdateLength(lengthChanges);
            if (result == 1)
            {
                return this.Ok(lengthChanges);
            }
            else
            {
                return this.BadRequest();
            }
        }

        /// <summary>
        /// This is getting list of length coversion
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [Route("length")]
        public ActionResult<List<Length>> AllDataLength()
        {
            var a = manager.AllDataLength();
            return Ok(a);
        }

        /// <summary>
        /// This is deleting the length converion id
        /// </summary>
        /// <param name="Id"></param>
        /// <returns></returns>
        [HttpDelete]
        [Route("{id}")]
        public int DeleteLength(int Id)
        {
            var delete = manager.DeleteLength(Id);
            return delete;
        }

        /// <summary>
        /// This is adding volume converion
        /// </summary>
        /// <param name="vmodel"></param>
        /// <returns></returns>
        [HttpPost]
        [Route("volume")]
        public ActionResult PostAllVolume(Volume vmodel)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var res = manager.PostAllVolume(vmodel);
            try
            {
                if (vmodel.OptionType == OptionType.GallonToLiter.ToString())
                {
                    return Ok(res);
                }
                else if (vmodel.OptionType == OptionType.LitreToMilliliter.ToString())
                {
                    return Ok(res);
                }
                else if (vmodel.OptionType == OptionType.MilliliterToLiter.ToString())
                {
                    return Ok(res);
                }
                else
                {
                    return NotFound();
                }
            }
            catch (CustomException)
            {
                return BadRequest(CustomException.ExceptionType.TYPE_NOT_MATCH);
            }
        }

        [Route("UpdateVolume")]
        [HttpPut]
        public async Task<IActionResult> UpdateVolume(Volume volumeChanges)
        {
            var result = await this.manager.UpdateVolume(volumeChanges);
            if (result == 1)
            {
                return this.Ok(volumeChanges);
            }
            else
            {
                return this.BadRequest();
            }
        }

        /// <summary>
        /// This is getting all volume conversion
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [Route("volume")]
        public ActionResult<List<Volume>> AllVolumeData()
        {
            var a = manager.AllVolumeData();
            return Ok(a);
        }

        /// <summary>
        /// This is deleting id of volume conversion
        /// </summary>
        /// <param name="Id"></param>
        /// <returns></returns>
        [HttpDelete]
        //[Route("volume/{id}")]
        public int DeleteVolume(int Id)
        {
            var delete = manager.DeleteVolume(Id);
            return delete;
        }

        /// <summary>
        /// This adding weigth conversion id
        /// </summary>
        /// <param name="wmodel"></param>
        /// <returns></returns>
        [HttpPost]
        [Route("weight")]
        public ActionResult PostAllWeight(Weight wmodel)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            var res = manager.PostAllWeight(wmodel);
            try
            {

                if (wmodel.OptionType == OptionType.KgToGrams.ToString())
                {
                    return Ok(res);
                }
                else if (wmodel.OptionType == OptionType.GramToKg.ToString())
                {
                    return Ok(res);
                }
                else if (wmodel.OptionType == OptionType.TonneToKgs.ToString())
                {
                    return Ok(res);
                }
                else
                {
                    return NotFound();
                }
            }
            catch (CustomException)
            {
                return BadRequest(CustomException.ExceptionType.TYPE_NOT_MATCH);
            }
        }

        /// <summary>
        /// This action verb is created for updating weight conversion
        /// </summary>
        /// <param name="weightChanges"></param>
        /// <returns></returns>
        [Route("UpdateWeight")]
        [HttpPut]
        public async Task<IActionResult> UpdateWeight(Weight weightChanges)
        {
            var result = await this.manager.UpdateWeight(weightChanges);
            if (result == 1)
            {
                return this.Ok(weightChanges);
            }
            else
            {
                return this.BadRequest();
            }
        }

        /// <summary>
        /// This action verb is created for getting all weight conversion
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [Route("weight")]
        public ActionResult<List<Weight>> AllWeightData()
        {
            var a = manager.AllWeightData();
            return Ok(a);
        }

        /// <summary>
        /// This action verbs is created for deleting weight conversion
        /// </summary>
        /// <param name="Id"></param>
        /// <returns></returns>
        [HttpDelete]
        [Route("weight/{id}")]
        public int DeleteWeight(int Id)
        {
            var delete = manager.DeleteWeight(Id);
            return delete;
        }

        /// <summary>
        /// This method is  created for addin
        /// </summary>
        /// <param name="tmodel"></param>
        /// <returns></returns>
        [HttpPost]
        [Route("temperature")]
        public ActionResult PostTemperature(Temperature tmodel)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            var res = manager.PostAllTempreture(tmodel);
            try
            {
                if (tmodel.OptionType == OptionType.CelsiusToFahrenheit.ToString())
                {

                    return Ok(res);
                }
                else if (tmodel.OptionType == OptionType.FahrenheitToCelsius.ToString())
                {

                    return Ok(res);
                }
                else
                {
                    return NotFound();
                }
            }
            catch (CustomException)
            {
                return BadRequest(CustomException.ExceptionType.TYPE_NOT_MATCH);
            }
        }

        /// <summary>
        /// This method is created for updating tempreture conversion
        /// </summary>
        /// <param name="tempretureChanges"></param>
        /// <returns></returns>
        [Route("UpdateTempreture")]
        [HttpPut]
        public async Task<IActionResult> UpdateTempreture(Temperature tempretureChanges)
        {
            var result = await this.manager.UpdateTempreture(tempretureChanges);
            if (result == 1)
            {
                return this.Ok(tempretureChanges);
            }
            else
            {
                return this.BadRequest();
            }
        }

        /// <summary>
        /// This action is getting all the id of tempreture conversion
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [Route("temperature")]
        public ActionResult<List<Temperature>> AllTemperatureData()
        {
            var a = manager.AllTemperatureData();
            return Ok(a);
        }

        /// <summary>
        /// This action is created for deleting tempreture id.
        /// </summary>
        /// <param name="Id"></param>
        /// <returns></returns>
        [HttpDelete]
        [Route("temperature/{id}")]
        public int DeleteTemperature(int Id)
        {
            var delete = manager.DeleteTemperature(Id);
            return delete;
        }
    }
}