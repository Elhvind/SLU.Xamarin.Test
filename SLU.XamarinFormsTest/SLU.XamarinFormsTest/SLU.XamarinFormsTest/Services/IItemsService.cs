using SLU.XamarinFormsTest.Models.Items;
using System.Collections.Generic;

namespace SLU.XamarinFormsTest.Services
{
    public interface IItemsService
    {
        ICollection<ItemDTO> GetAll();
    }
}