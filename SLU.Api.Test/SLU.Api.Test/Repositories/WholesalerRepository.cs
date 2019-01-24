using SLU.Api.Test.Common.Repositories;
using SLU.Api.Test.Data.Entities;
using SLU.Api.Test.Repositories.Interfaces;

namespace SLU.Api.Test.Repositories
{
    public class WholesalerRepository : RepositoryBase<WholesalerEntity>, IWholesalerRepository
    {
        public WholesalerRepository() : base("wholesaler.json")
        {

        }
    }
}