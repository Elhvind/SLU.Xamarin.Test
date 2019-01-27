using SLU.XamarinFormsTest.DataAccess.Entities;
using SLU.XamarinFormsTest.DataAccess.Repositories.Common;
using SLU.XamarinFormsTest.DataAccess.Repositories.Interfaces;
using System.Collections.Generic;
using System.Linq;

namespace SLU.XamarinFormsTest.DataAccess.Repositories
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