using PeakInvestBackend.Models;

namespace PeakInvestBackend.Interfaces
{
    public interface ICalculationService
    {
        CalculationResponse Calcular(CalculationRequest request);

    }
}
