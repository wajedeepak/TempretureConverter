using Microsoft.AspNetCore.Mvc;
using System;
using TempretureConverter.Model;
using TempretureConverter.Service;

namespace TempretureConverter.Controllers
{
    [Route("api/[controller]")]
    public class TempConverterController : ControllerBase
    {
        private CelsiusConverter celsiusConverter;
        private KelvinConverter kelvinConverter;
        private FahrenheitConverter fahrenheitConverter;
        private TempConverter converter;
        public TempConverterController()
        {
            //These can be injected using IOC 
            celsiusConverter = new CelsiusConverter();
            fahrenheitConverter = new FahrenheitConverter();
            kelvinConverter = new KelvinConverter();

            converter = new TempConverter();
        }

        [HttpGet("[action]")]
        public TempretureValues ConvertUnit(string type, string value)
        {
            decimal decimalValue;
            var isValid = Decimal.TryParse(value, out decimalValue);
            if (isValid)
            {
                switch (type)
                {
                    case "1":
                        return converter.GetTempretureValues(celsiusConverter, decimalValue);

                    case "2":
                        return converter.GetTempretureValues(fahrenheitConverter, decimalValue);

                    case "3":
                        return converter.GetTempretureValues(kelvinConverter, decimalValue);

                }
            }
            //For invalid input return empty result
            return new TempretureValues();
        }
    }
}
