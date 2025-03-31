using PeakInvestBackend.Interfaces;
using PeakInvestBackend.Models;
using System;

namespace PeakInvestBackend.Services
{
    public class CalculationService : ICalculationService
    {
        public CalculationResponse Calcular(CalculationRequest request)
        {
            decimal total = (request.ValorParcela * request.Parcelas) * 1.05m;
            return new CalculationResponse { ValorTotal = Math.Round(total, 2) };
        }
    }
}
