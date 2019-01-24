using SLU.Api.Test.Common.Repositories;
using SLU.Api.Test.Data.Entities;
using SLU.Api.Test.Repositories.Common;
using SLU.Api.Test.Repositories.Interfaces;

namespace SLU.Api.Test.Repositories
{
    public class WholesalerRepository : RepositoryBase<WholesalerEntity>, IRepository<WholesalerEntity>, IWholesalerRepository
    {
        public WholesalerRepository() : base("wholesaler.json")
        {
        }

        public override void Update(WholesalerEntity entityToUpdate, WholesalerEntity entity)
        {

        }
    }
}