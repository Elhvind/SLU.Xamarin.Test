using SLU.Api.Test.Common.Repositories;
using SLU.Api.Test.Data.Entities;
using SLU.Api.Test.Repositories.Common;
using SLU.Api.Test.Repositories.Interfaces;

namespace SLU.Api.Test.Repositories
{
    public class ItemsRepository : RepositoryBase<ItemEntity>, IRepository<ItemEntity>, IItemsRepository
    {
        public ItemsRepository() : base("items.json")
        {
        }

        public void Create(ItemEntity entity)
        {
            throw new System.NotImplementedException();
        }

        public void Update(ItemEntity entity)
        {
            throw new System.NotImplementedException();
        }
    }
}