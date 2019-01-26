using SLU.XamarinTest.DataAccess.Entities;
using SLU.XamarinTest.DataAccess.Repositories.Common;
using SLU.XamarinTest.DataAccess.Repositories.Interfaces;

namespace SLU.XamarinTest.DataAccess.Repositories
{
    public class ItemsRepository : RepositoryBase<ItemEntity>, IRepository<ItemEntity>, IItemsRepository
    {
        public ItemsRepository() : base("items.json")
        {
        }
    }
}