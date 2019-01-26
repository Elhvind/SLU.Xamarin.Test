using SLU.XamarinTest.DataAccess.Entities;
using SLU.XamarinTest.DataAccess.Repositories.Common;
using System.Collections.Generic;

namespace SLU.XamarinTest.DataAccess.Repositories.Interfaces
{
    public interface IItemsRepository : IRepository<ItemEntity>
    {
        ICollection<ItemEntity> GetItemsFromWholesalerId(int wholesalerId);
    }
}