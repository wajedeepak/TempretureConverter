using TempretureConverter.Model;

namespace TempretureConverter.Service
{
    public class CelsiusConverter : IConverter
    {
        public TempretureValues Convert(decimal value)
        {
            return new TempretureValues
            {
                TemperatureC = value,
                TemperatureF = (value * 9/5) + 32,
                TemperatureK = value + 273.15M
            };
        }
    }

}
