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
    public class TemperatureController : ControllerBase
    {
        public IQuantityMeasurementManager manager;
        public TemperatureController(IQuantityMeasurementManager manager)
        {
            this.manager = manager;
        }

        [HttpPost]
        public IActionResult TempreturePost(TempretureUnit quantity)
        {
            var item = this.manager.TempreturePost(quantity);
            try
            {
                object result;
                switch (quantity.TempretureOptions)
                {
                    case "FahrenhietToCelcius":
                        result = this.Ok(new { Celcius = String.Format("{0:0.00}", item) });
                        break;
                    case "CelciusToFahrenhiet":
                        result = this.Ok(new { Fahrenheit = String.Format("{0:0.00}", item) });
                        break;
                    default:
                        result = this.BadRequest(new { error = "Conversion not possible" });
                        break;

                }
                return (IActionResult)result;
            }
            catch (CustomException)
            {
                return BadRequest(CustomException.ExceptionType.OPTIONS_NOT_MATCH);
            }
        }
    }
}