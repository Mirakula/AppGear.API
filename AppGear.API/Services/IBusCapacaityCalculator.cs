using System.Threading.Tasks;

namespace AppGear.API.Services
{
    public interface IBusCapacaityCalculator
    {
        Task<double> CalculateCapacityPercent(double maxCapacity, double newInsOuts);
    }
}