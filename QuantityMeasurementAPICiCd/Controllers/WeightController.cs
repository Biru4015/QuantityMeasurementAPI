using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using QuantityMeasurementManager.IQuantityManager;
using QuantityMeasurementModel;

namespace QuantityMeasurementAPICiCd.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class WeightController : ControllerBase
    {
        public IQuantityMeasurementManager manager;
        public WeightController(IQuantityMeasurementManager manager)
        {
            this.manager = manager;
        }

       
        [HttpPost]
        [Route("WeightPost")]
        public IActionResult WeightPost(WeightUnit value)
        {
            var res = manager.WeightPost(value);
            try
            {
                if (value.OptionType == OptionType.KilogramToGram.ToString())
                    return this.Ok(new { output = res });
                else if (value.OptionType == OptionType.GramToKilogram.ToString())
                    return this.Ok(new { output = res });
                else if (value.OptionType == OptionType.TonneToKilogram.ToString())
                    return this.Ok(new { output = res });
                else if (value.OptionType == OptionType.KilogramToTonne.ToString())
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