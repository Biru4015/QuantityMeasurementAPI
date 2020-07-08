using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using QuantityMeasurementManager.IQuantityManager;
using QuantityMeasurementModel;

namespace QuantityMeasurementApplication.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VolumesController : ControllerBase
    {
        public IQuantityMeasurementManager manager;
        public VolumesController(IQuantityMeasurementManager manager)
        {
            this.manager = manager;
        }

        [HttpPost]
        public IActionResult VolumePost(VolumeUnit value)
        {

            var res = manager.VolumePost(value);
            try
            {
                object result;
                switch (value.VolumeOptions)
                {
                    case "LitreToGallon":
                        result = this.Ok(new { Gallon = String.Format("{0:0.00}", res) });
                        break;
                    case "GallonToLitre":
                        result = this.Ok(new { Litre = String.Format("{0:0.00}", res) });
                        break;
                    case "LitreToMiliLitre":
                        result = this.Ok(new { Mililitre = String.Format("{0:0.00}", res) });
                        break;
                    case "MiliLitreToLitre":
                        result = this.Ok(new { Litre = String.Format("{0:0.00}", res) });
                        break;
                    default:
                        result = this.BadRequest(new { error = "Conversion not possible" });
                        break;

                }
                return (IActionResult)result;
            }
            catch (CustomException)
            {
                return BadRequest(CustomException.ExceptionType.TYPE_NOT_MATCH);
            }
        }
    }
}