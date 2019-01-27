using SLU.XamarinFormsTest.DataAccess.Entities;
using System.Collections.Generic;

namespace SLU.XamarinFormsTest.Services
{
    public interface IItemsService
    {
        ICollection<ItemEntity> GetAll();
    }
}