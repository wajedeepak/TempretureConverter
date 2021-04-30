using TempretureConverter.Model;

namespace TempretureConverter.Service
{
    public class TempConverter
    {
        public TempretureValues GetTempretureValues(IConverter converter, decimal value)
        {
            return converter.Convert(value);
        }
    }
}
