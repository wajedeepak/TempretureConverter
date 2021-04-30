using TempretureConverter.Model;

namespace TempretureConverter.Service
{
    public class FahrenheitConverter : IConverter
    {
        public TempretureValues Convert(decimal value)
        {
            return new TempretureValues
            {
                TemperatureC = (value - 32) * 5/9,
                TemperatureF = value,
                TemperatureK = (value - 32) * 5/9 + 273.15M
            };
        }
    }

}
