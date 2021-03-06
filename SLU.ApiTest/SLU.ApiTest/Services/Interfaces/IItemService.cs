﻿using SLU.ApiTest.Models.Items;
using System.Collections.Generic;

namespace SLU.ApiTest.Services.Interfaces
{
    public interface IItemService
    {
        ICollection<ItemDTO> GetAllItems();
        ItemDTO GetItem(int id);
        ItemDetailsDTO GetItemDetails(int id);
        int CreateItem(ItemDTO item);
        bool UpdateItem(int id, ItemDTO item);
        bool DeleteItem(int id);
    }
}
