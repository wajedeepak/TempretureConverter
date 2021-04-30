using TempretureConverter.Model;

namespace TempretureConverter.Service
{
    public class KelvinConverter : IConverter
    {
        public TempretureValues Convert(decimal value)
        {
            return new TempretureValues
            {
                TemperatureC = value - 273.15M,
                TemperatureF = (value - 273.15M) * 9/5 + 32,
                TemperatureK = value
            };
        }
    }

}
