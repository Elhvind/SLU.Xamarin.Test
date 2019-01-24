using SLU.Api.Test.Common.Repositories;
using SLU.Api.Test.Data.Entities;
using SLU.Api.Test.Repositories.Common;
using SLU.Api.Test.Repositories.Interfaces;

namespace SLU.Api.Test.Repositories
{
    public class UsedItemsRepository : RepositoryBase<UsedItemEntity>, IRepository<UsedItemEntity>, IUsedItemsRepository
    {
        public UsedItemsRepository() : base("useditems.json")
        {
        }

        public void Create(UsedItemEntity entity)
        {
            throw new System.NotImplementedException();
        }

        public void Update(UsedItemEntity entity)
        {
            throw new System.NotImplementedException();
        }
    }
}