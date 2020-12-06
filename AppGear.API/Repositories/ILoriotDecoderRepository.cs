using System.Threading.Tasks;
using AppGear.API.Models;

namespace AppGear.API.Repositories
{
    public interface ILoriotDecoderRepository
    {
        Task<LoriotDecodeModel> UnpackData(string data);
        Task<byte[]> ConvertHexStringToByteArray(string hexString);
        void Post(LoriotDecodeModel decodeModel);
    }
}