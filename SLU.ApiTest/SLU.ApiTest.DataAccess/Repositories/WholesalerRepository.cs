using SLU.ApiTest.DataAccess.Models;
using SLU.ApiTest.DataAccess.Repositories.Core;
using SLU.ApiTest.DataAccess.Repositories.Interfaces;

namespace SLU.ApiTest.DataAccess.Repositories
{
    public class WholesalerRepository : RepositoryBase<WholesalerEntity>, IRepository<WholesalerEntity>, IWholesalerRepository
    {
        public WholesalerRepository() : base("wholesaler.json")
        {
        }
    }
}