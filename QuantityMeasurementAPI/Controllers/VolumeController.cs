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
    public class VolumeController : ControllerBase
    {
        /// <summary>
        /// Calling QuantityMeasuremnet Interface
        /// </summary>
        public IQuantityMeasurementManager manager;
        public VolumeController(IQuantityMeasurementManager manager)
        {
            this.manager = manager;
        }

        [Route("VolumePost")]
        [HttpPost]
        public IActionResult VolumePost(VolumeUnit value)
        {
            var res = manager.VolumePost(value);
            try
            {
                if (value.OptionType == OptionType.LitreToGallon.ToString())
                    return this.Ok(new { output = res });
                else if (value.OptionType == OptionType.GallonToLitre.ToString())
                    return this.Ok(new { output = res });
                else if (value.OptionType == OptionType.LitreToMiliLitre.ToString())
                    return this.Ok(new { output = res });
                else if (value.OptionType == OptionType.MiliLitreToLitre.ToString())
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