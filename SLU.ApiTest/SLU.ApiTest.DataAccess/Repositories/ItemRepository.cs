using SLU.ApiTest.DataAccess.Models;
using SLU.ApiTest.DataAccess.Repositories.Core;
using SLU.ApiTest.DataAccess.Repositories.Interfaces;

namespace SLU.ApiTest.DataAccess.Repositories
{
    public class ItemRepository : RepositoryBase<ItemEntity>, IRepository<ItemEntity>, IItemRepository
    {
        public ItemRepository() : base("items.json")
        {
        }
    }
}