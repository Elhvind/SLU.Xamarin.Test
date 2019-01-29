using SLU.ApiTest.DataAccess.Models;
using SLU.ApiTest.DataAccess.Repositories;
using SLU.ApiTest.DataAccess.Repositories.Interfaces;
using SLU.ApiTest.Models.UsedItems;
using SLU.ApiTest.Services.Interfaces;
using System.Collections.Generic;
using System.Linq;

namespace SLU.ApiTest.Services
{
    public class UsedItemService : IUsedItemService
    {
        private readonly IUsedItemRepository _usedItemRepository;

        public UsedItemService()
        {
            _usedItemRepository = new UsedItemRepository();
        }

        public ICollection<UsedItemDTO> GetAllUsedItems()
        {
            var allItems = _usedItemRepository
                .GetAll()?
                .Select(ConvertToDTO)
                .ToList();

            return allItems ?? new List<UsedItemDTO>();
        }

        public UsedItemDTO GetUsedItem(int id)
        {
            var item = _usedItemRepository.Get(id);
            return ConvertToDTO(item);
        }

        public int CreateUsedItem(UsedItemDTO item)
        {
            var usedItemEntity = new UsedItemEntity
            {
                WholesalerId = item.WholesalerId,
                Name = item.Name,
                ItemNumber = item.ItemNumber,
                Price = item.Price,
                ItemGroup = string.Empty
            };

            return _usedItemRepository.Create(usedItemEntity);
        }

        public bool UpdateUsedItem(int id, UsedItemDTO item)
        {
            if (item == null)
                return false;

            var itemToUpdate = _usedItemRepository.Get(id);
            if (itemToUpdate == null)
                return false;

            itemToUpdate.WholesalerId = item.WholesalerId;
            itemToUpdate.Name = item.Name;
            itemToUpdate.ItemNumber = item.ItemNumber;
            itemToUpdate.ItemGroup = item.ItemGroup;
            itemToUpdate.Price = item.Price;
            itemToUpdate.Amount = item.Amount;
            itemToUpdate.Date = item.Date;

            return _usedItemRepository.Update(id, itemToUpdate);
        }

        public bool DeleteUsedItem(int id)
        {
            return _usedItemRepository.Delete(id);
        }

        private UsedItemDTO ConvertToDTO(UsedItemEntity item)
        {
            if (item == null)
                return null;

            //TODO: Use AutoMapper instead of custom mapping
            return new UsedItemDTO
            {
                Id = item.Id,
                WholesalerId = item.WholesalerId,
                Name = item.Name,
                ItemNumber = item.ItemNumber,
                ItemGroup = item.ItemGroup,
                Price = item.Price,
                Amount = item.Amount,
                Date = item.Date
            };
        }
    }
}
