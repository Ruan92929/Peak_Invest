using Microsoft.Azure.Functions.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection;
using PeakInvestBackend.Interfaces;
using PeakInvestBackend.Services;

[assembly: FunctionsStartup(typeof(PeakInvestBackend.Startup))]

namespace PeakInvestBackend
{
    public class Startup : FunctionsStartup
    {
        public override void Configure(IFunctionsHostBuilder builder)
        {
            builder.Services.AddSingleton<ICalculationService, CalculationService>();
            builder.Services.AddSingleton<IQueryService, QueryService>();
        }
    }
}
