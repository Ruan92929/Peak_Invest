using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Azure.Functions.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;
using PeakInvestBackend.Interfaces;
using PeakInvestBackend.Services;
using System;

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
