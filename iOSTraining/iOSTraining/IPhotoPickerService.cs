using System.IO;
using System.Threading.Tasks;

namespace iOSTraining
{
    public interface IPhotoPickerService
    {
        Task<Stream> GetImageStreamAsync();

    }
}