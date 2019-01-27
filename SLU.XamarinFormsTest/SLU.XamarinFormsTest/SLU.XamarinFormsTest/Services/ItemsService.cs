using SLU.XamarinFormsTest.DataAccess.Entities;
using SLU.XamarinFormsTest.DataAccess.Repositories;
using SLU.XamarinFormsTest.DataAccess.Repositories.Interfaces;
using System.Collections.Generic;

namespace SLU.XamarinFormsTest.Services
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