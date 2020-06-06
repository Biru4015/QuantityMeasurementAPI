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
    }
}