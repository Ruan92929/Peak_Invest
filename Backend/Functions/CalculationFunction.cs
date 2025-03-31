using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.Http;
using Newtonsoft.Json;
using PeakInvestBackend.Interfaces;
using PeakInvestBackend.Models;
using System.IO;
using System.Threading.Tasks;

public class CalculationFunction
{
    private readonly ICalculationService _calculationService;

    public CalculationFunction(ICalculationService calculationService)
    {
        _calculationService = calculationService;
    }

    [FunctionName("CalculationFunction")]
    [EnableCors("AllowAll")]
    public async Task<IActionResult> Run(
            [HttpTrigger(AuthorizationLevel.Anonymous, "post")] HttpRequest req)
    {
        string requestBody = await new StreamReader(req.Body).ReadToEndAsync();
        var request = JsonConvert.DeserializeObject<CalculationRequest>(requestBody);

        if (request == null)
        {
            return new BadRequestObjectResult("Requisição inválida.");
        }

        if (request.Parcelas <= 0 || request.ValorParcela <= 0)
        {
            return new BadRequestObjectResult("Parcelas e valor devem ser maiores que zero.");
        }

        var response = _calculationService.Calcular(request);

        return new OkObjectResult(response);
    }
}
