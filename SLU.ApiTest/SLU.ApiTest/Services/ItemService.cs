using SLU.ApiTest.DataAccess.Models;
using SLU.ApiTest.DataAccess.Repositories;
using SLU.ApiTest.DataAccess.Repositories.Interfaces;
using SLU.ApiTest.Models;
using SLU.ApiTest.Services.Interfaces;
using System.Collections.Generic;
using System.Linq;

namespace SLU.ApiTest.Services
{
    public class ItemService : IItemService
    {
        private readonly IItemRepository _itemRepository;

        public ItemService()
        {
            _itemRepository = new ItemRepository();
        }

        public ICollection<ItemDTO> GetAllItems()
        {
            var allItems = _itemRepository
                .GetAll()?
                .Select(ConvertToDTO)
                .ToList();

            return allItems ?? new List<ItemDTO>();
        }

        public ItemDTO GetItem(int id)
        {
            var item = _itemRepository.Get(id);
            return ConvertToDTO(item);
        }

        public void CreateItem(ItemDTO item)
        {
            var itemEntity = new ItemEntity
            {
                Name = item.Name,
                ItemNumber = item.ItemNumber,
                Price = item.Price,
                ImageUrl = item.ImageUrl,
                ItemGroup = string.Empty,
                WholesalerIds = new List<int>()
            };

            _itemRepository.Create(itemEntity);
        }

        public bool UpdateItem(int id, ItemDTO item)
        {
            if (item == null)
                return false;

            var itemToUpdate = _itemRepository.Get(id);
            if (itemToUpdate == null)
                return false;

            itemToUpdate.Name = item.Name;
            itemToUpdate.ItemNumber = item.ItemNumber;
            itemToUpdate.Price = item.Price;
            itemToUpdate.ImageUrl = item.ImageUrl;

            return _itemRepository.Update(id, itemToUpdate);
        }

        public bool DeleteItem(int id)
        {
            return _itemRepository.Delete(id);
        }

        /// <summary>
        /// Use AutoMapper instead of custom mapping
        /// </summary>
        /// <param name="item"></param>
        /// <returns></returns>
        private ItemDTO ConvertToDTO(ItemEntity item)
        {
            if (item == null)
                return null;

            return new ItemDTO
            {
                Id = item.Id,
                Name = item.Name,
                ItemNumber = item.ItemNumber,
                Price = item.Price,
                ImageUrl = item.ImageUrl
            };
        }
    }
}
