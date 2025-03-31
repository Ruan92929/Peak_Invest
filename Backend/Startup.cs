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

            // Configuração de CORS
            builder.Services.AddCors(options =>
            {
                options.AddPolicy("AllowAll",
                    builder => builder
                        .AllowAnyOrigin()
                        .AllowAnyMethod()
                        .AllowAnyHeader());
            });
        }
    }

    public class CorsStartupFilter : IStartupFilter
    {
        public Action<IApplicationBuilder> Configure(Action<IApplicationBuilder> next)
        {
            return builder =>
            {
                // Aqui, chamamos o middleware UseCors antes de qualquer outro middleware.
                builder.UseCors(options =>
                    options.WithOrigins("http://localhost:4200")  // Adicionar o domínio do frontend
                           .AllowAnyMethod()
                           .AllowAnyHeader());
                next(builder);
            };
        }
    }

}
