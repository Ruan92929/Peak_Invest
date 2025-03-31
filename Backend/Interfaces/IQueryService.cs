using PeakInvestBackend.Models;

namespace PeakInvestBackend.Interfaces
{
    public interface IQueryService
    {
        QueryResponse BuscarNome(int id);
    }
}
