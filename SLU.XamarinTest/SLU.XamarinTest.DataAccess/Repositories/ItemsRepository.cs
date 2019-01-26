using SLU.XamarinTest.DataAccess.Entities;
using SLU.XamarinTest.DataAccess.Repositories.Common;
using SLU.XamarinTest.DataAccess.Repositories.Interfaces;
using System.Collections.Generic;
using System.Linq;

namespace SLU.XamarinTest.DataAccess.Repositories
{
    public class ItemsRepository : RepositoryBase<ItemEntity>, IRepository<ItemEntity>, IItemsRepository
    {
        public ItemsRepository() : base("items.json")
        {
        }

        public ICollection<ItemEntity> GetItemsFromWholesalerId(int wholesalerId)
        {
            return GetAll()
                .Where(x => x.WholesalerIds != null && x.WholesalerIds.Contains(wholesalerId))
                .ToList();
        }
    }
}