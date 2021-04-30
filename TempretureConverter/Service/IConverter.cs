using TempretureConverter.Model;

namespace TempretureConverter.Service
{
    public interface IConverter
    {
        TempretureValues Convert(decimal value);
    }

}
