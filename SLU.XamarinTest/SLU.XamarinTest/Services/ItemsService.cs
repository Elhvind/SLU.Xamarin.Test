using SLU.XamarinTest.DataAccess.Entities;
using SLU.XamarinTest.DataAccess.Repositories;
using SLU.XamarinTest.DataAccess.Repositories.Interfaces;
using System.Collections.Generic;

namespace SLU.XamarinTest.Services
{
    public class ItemsService : IItemsService
    {
        private readonly IItemsRepository _itemsRepository;

        public ItemsService()
        {
            // TODO: Dependency injection
            _itemsRepository = new ItemsRepository();
        }

        public ICollection<ItemEntity> GetAll()
        {
            return _itemsRepository.GetAll();
        }
    }
}