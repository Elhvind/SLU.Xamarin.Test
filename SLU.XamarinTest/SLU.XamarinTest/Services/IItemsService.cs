using SLU.XamarinTest.DataAccess.Entities;
using System.Collections.Generic;

namespace SLU.XamarinTest.Services
{
    public interface IItemsService
    {
        ICollection<ItemEntity> GetAll();
    }
}