using SLU.XamarinTest.Common.Repositories;
using SLU.XamarinTest.Data.Entities;
using SLU.XamarinTest.Repositories.Common;
using SLU.XamarinTest.Repositories.Interfaces;

namespace SLU.XamarinTest.Repositories
{
    public class ItemsRepository : RepositoryBase<ItemEntity>, IRepository<ItemEntity>, IItemsRepository
    {
        public ItemsRepository() : base("items.json")
        {
        }
    }
}