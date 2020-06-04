using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using QuantityManagerLayer.IManager;
using QuantityModelLayer.Model;

namespace QuantityMeasurementAPI.Controllers
{
    [Route("api/[controller]")]
    [Produces("application/json")]
    [ApiController]
    public class QuantityController : ControllerBase
    {
        private readonly IQuantityManager manager;

        public QuantityController(IQuantityManager manager)
        {
            this.manager = manager;
        }

        [HttpPost]
        [Route("length")]
        public ActionResult Post(Length model)
        {

            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            var res = manager.Post(model);
            try
            {
                if (model.OptionType == OptionType.InchToFeet.ToString())
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

        [HttpGet]
        [Route("length")]
        public ActionResult<List<Length>> AllData()
        {
            var a = manager.AllData();
            return Ok(a);
            //return a;
        }

        [HttpDelete]
        [Route("length/{id}")]
        public int Delete(int Id)
        {
            var delete = manager.Delete(Id);
            return delete;
        }

        [HttpPost]
        [Route("volume")]
        public ActionResult PostVolume(Volume vmodel)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var res = manager.PostV(vmodel);
            try
            {
                if (vmodel.OptionType == OptionType.GallonToLiter.ToString())
                {
                    return Ok(res);
                    //  return model.Result;
                }
                else if (vmodel.OptionType == OptionType.LitreToMilliliter.ToString())
                {
                    //double litre = 3.78;
                    return Ok(res);
                    //  return model.Result;
                }
                else if (vmodel.OptionType == OptionType.MilliliterToLiter.ToString())
                {
                    //double litre = 3.78;
                    return Ok(res);
                    //  return model.Result;
                }
                else
                {
                    return NotFound();
                }
                //  return model.Result;
            }
            catch (CustomException)
            {
                return BadRequest(CustomException.ExceptionType.TYPE_NOT_MATCH);
            }
        }

        [HttpGet]
        [Route("volume")]
        public ActionResult<List<Volume>> AllVolumeData()
        {
            var a = manager.AllVolumeData();
            return Ok(a);
        }

        [HttpDelete]
        [Route("volume/{id}")]
        public int DeleteVolume(int Id)
        {
            var delete = manager.Delete(Id);
            return delete;
        }

        [HttpPost]
        [Route("weight")]
        public ActionResult PostWeight(Weight wmodel)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            var res = manager.PostWeight(wmodel);
            try
            {

                if (wmodel.OptionType == OptionType.KgToGrams.ToString())
                {
                    //double litre = 3.78;
                    return Ok(res);
                    //  return model.Result;
                }
                else if (wmodel.OptionType == OptionType.GramToKg.ToString())
                {
                    //double litre = 3.78;
                    return Ok(res);
                    //  return model.Result;
                }
                else if (wmodel.OptionType == OptionType.TonneToKgs.ToString())
                {
                    //double litre = 3.78;
                    return Ok(res);
                    //  return model.Result;
                }
                else
                {
                    return NotFound();
                }
            }
            //  return model.Result;
            catch (CustomException)
            {
                return BadRequest(CustomException.ExceptionType.TYPE_NOT_MATCH);
            }
        }

        [HttpGet]
        [Route("weight")]
        public ActionResult<List<Weight>> AllWeightData()
        {
            var a = manager.AllWeightData();
            return Ok(a);
        }

        [HttpDelete]
        [Route("weight/{id}")]
        public int DeleteWeight(int Id)
        {
            var delete = manager.DeleteWeight(Id);
            return delete;
        }

        [HttpPost]
        [Route("temperature")]
        public ActionResult PostTemperature(Temperature tmodel)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            var res = manager.PostTemperature(tmodel);
            try
            {
                if (tmodel.OptionType == OptionType.CelsiusToFahrenheit.ToString())
                {

                    return Ok(res);
                    //  return model.Result;
                }
                else if (tmodel.OptionType == OptionType.FahrenheitToCelsius.ToString())
                {

                    return Ok(res);
                    //  return model.Result;
                }
                else
                {
                    return NotFound();
                }
                //  return model.Result;
            }
            catch (CustomException)
            {
                return BadRequest(CustomException.ExceptionType.TYPE_NOT_MATCH);
            }
        }

        [HttpGet]
        [Route("temperature")]
        public ActionResult<List<Temperature>> AllTemperatureData()
        {
            var a = manager.AllTemperatureData();
            return Ok(a);
        }

        [HttpDelete]
        [Route("temperature/{id}")]
        public int DeleteTemperature(int Id)
        {
            var delete = manager.DeleteTemperature(Id);
            return delete;
        }
    }
}