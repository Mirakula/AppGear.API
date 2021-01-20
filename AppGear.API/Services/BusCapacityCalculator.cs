using System.Threading.Tasks;

namespace AppGear.API.Services
{
    public class BusCapacityCalculator : IBusCapacaityCalculator
    {
        public async Task<double> CalculateCapacityPercent(double maxCapacity, double newInsOuts)
        {
            if (newInsOuts == 0)
            {
                return 0;
            }
            else
            {
                double percent = newInsOuts / maxCapacity;
                return await Task.FromResult(percent * 100);    
            }
        }
    }
}