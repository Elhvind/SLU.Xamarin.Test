using SLU.ApiTest.Common.Repositories;
using SLU.ApiTest.Data.Entities;
using SLU.ApiTest.Repositories.Common;
using SLU.ApiTest.Repositories.Interfaces;

namespace SLU.ApiTest.Repositories
{
    public class WholesalerRepository : RepositoryBase<WholesalerEntity>, IRepository<WholesalerEntity>, IWholesalerRepository
    {
        public WholesalerRepository() : base("wholesaler.json")
        {
        }
    }
}