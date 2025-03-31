using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.Http;
using PeakInvestBackend.Interfaces;

public class QueryFunction
{
    private readonly IQueryService _queryService;

    public QueryFunction(IQueryService queryService)
    {
        _queryService = queryService;
    }

    [FunctionName("QueryFunction")]
    [EnableCors("AllowAll")]
    public IActionResult Run(
        [HttpTrigger(AuthorizationLevel.Anonymous, "get", Route = "query/{id}")] HttpRequest req, int id)
    {
        var response = _queryService.BuscarNome(id);

        if (response == null)
        {
            return new NotFoundObjectResult("ID não encontrado.");
        }

        return new OkObjectResult(response);
    }
}
