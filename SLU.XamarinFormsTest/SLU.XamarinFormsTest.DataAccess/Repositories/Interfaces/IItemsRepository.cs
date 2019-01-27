using SLU.XamarinFormsTest.DataAccess.Entities;
using SLU.XamarinFormsTest.DataAccess.Repositories.Common;
using System.Collections.Generic;

namespace SLU.XamarinFormsTest.DataAccess.Repositories.Interfaces
{
    public interface IItemsRepository : IRepository<ItemEntity>
    {
        ICollection<ItemEntity> GetItemsFromWholesalerId(int wholesalerId);
    }
}