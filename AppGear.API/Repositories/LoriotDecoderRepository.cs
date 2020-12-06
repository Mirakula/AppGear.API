using System;
using System.Globalization;
using System.Threading.Tasks;
using AppGear.API.Models;

namespace AppGear.API.Repositories
{
    public class LoriotDecoderRepository : ILoriotDecoderRepository
    {
        private readonly LorawanContext _databaseContext;
        
        public LoriotDecoderRepository(LorawanContext databaseContext)
        {
            _databaseContext = databaseContext;
        }

        public async Task<LoriotDecodeModel> UnpackData(string data)
        {
            var decodeModel = new LoriotDecodeModel();

            for (int i = 1; i <= data.Length; i++)
            {
                if (i == 8)
                {
                    byte[] timeStampResult = await ConvertHexStringToByteArray(data.Substring(0, 8));
                    decodeModel.TimeStamp = BitConverter.ToUInt32(timeStampResult, 0) + 1514764800;
                    decodeModel.ToDate = DateTimeOffset.FromUnixTimeSeconds(decodeModel.TimeStamp);
                }
                else if (i == 10)
                {
                    byte[] cyclePeriod = await ConvertHexStringToByteArray(data.Substring(10, 2));
                    foreach (var b in cyclePeriod)
                    {
                        decodeModel.CyclePeriod = (sbyte) b;
                    }
                }

                else if (i == 14)
                {
                    byte[] dailyEventsCycle = await ConvertHexStringToByteArray(data.Substring(10, 4));
                    decodeModel.DailyEventsCount = BitConverter.ToUInt16(dailyEventsCycle, 0);
                }
                
                else if (i == 18)
                {
                    byte[] cycleEventsCount = await ConvertHexStringToByteArray(data.Substring(14, 4));
                    decodeModel.CycleEventsCount = BitConverter.ToUInt16(cycleEventsCount);
                }
                else if (i == 22)
                {
                    byte[] dailyCycleCount = await ConvertHexStringToByteArray(data.Substring(18, 4));
                    decodeModel.DailyCyclesCount = BitConverter.ToUInt16(dailyCycleCount);
                }
            }
            return await Task.FromResult(decodeModel);
        }

        public async Task<byte[]> ConvertHexStringToByteArray(string hexString)
        {
            if (hexString.Length % 2 != 0)
            {
                throw new ArgumentException(String.Format(CultureInfo.InvariantCulture, "The binary key cannot have an odd number of digits: {0}", hexString));
            }

            byte[] data = new byte[hexString.Length / 2];
            for (int index = 0; index < data.Length; index++)
            {
                string byteValue = hexString.Substring(index * 2, 2);
                data[index] = byte.Parse(byteValue, NumberStyles.HexNumber, CultureInfo.InvariantCulture);
            }
            return data;            
        }

        public void Post(LoriotDecodeModel decodeModel)
        {
            _databaseContext.LoriotDecoded.Add(decodeModel);
            _databaseContext.SaveChanges();
        }
    }
}