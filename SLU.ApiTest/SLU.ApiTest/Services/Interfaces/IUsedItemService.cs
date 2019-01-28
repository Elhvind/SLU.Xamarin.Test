using SLU.ApiTest.Models.UsedItems;
using System.Collections.Generic;

namespace SLU.ApiTest.Services.Interfaces
{
    public interface IUsedItemService
    {
        ICollection<UsedItemDTO> GetAllUsedItems();
        UsedItemDTO GetUsedItem(int id);
        int CreateUsedItem(UsedItemDTO item);
        bool UpdateUsedItem(int id, UsedItemDTO item);
        bool DeleteUsedItem(int id);
    }
}
