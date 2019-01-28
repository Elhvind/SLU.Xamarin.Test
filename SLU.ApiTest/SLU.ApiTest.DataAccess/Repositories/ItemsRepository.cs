using SLU.ApiTest.DataAccess.Models;
using SLU.ApiTest.DataAccess.Repositories.Core;
using SLU.ApiTest.DataAccess.Repositories.Interfaces;

namespace SLU.ApiTest.DataAccess.Repositories
{
    public class ItemsRepository : RepositoryBase<ItemEntity>, IRepository<ItemEntity>, IItemsRepository
    {
        public ItemsRepository() : base("items.json")
        {
        }
    }
}