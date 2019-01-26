using SLU.ApiTest.Common.Repositories;
using SLU.ApiTest.Data.Entities;
using SLU.ApiTest.Repositories.Common;
using SLU.ApiTest.Repositories.Interfaces;

namespace SLU.ApiTest.Repositories
{
    public class ItemsRepository : RepositoryBase<ItemEntity>, IRepository<ItemEntity>, IItemsRepository
    {
        public ItemsRepository() : base("items.json")
        {
        }
    }
}