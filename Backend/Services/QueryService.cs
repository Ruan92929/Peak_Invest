using PeakInvestBackend.Interfaces;
using PeakInvestBackend.Models;
using System.Collections.Generic;
using System.Linq;

namespace PeakInvestBackend.Services
{
    public class QueryService : IQueryService
    {
        private readonly List<KeyValuePair<int, string>> lista = new()
        {
            new(1, "João"),
            new(2, "Maria"),
            new(3, "Ana")
        };

        public QueryResponse BuscarNome(int id)
        {
            var nome = lista.FirstOrDefault(x => x.Key == id).Value;
            return nome != null ? new QueryResponse { Nome = nome } : null;
        }
    }
}
