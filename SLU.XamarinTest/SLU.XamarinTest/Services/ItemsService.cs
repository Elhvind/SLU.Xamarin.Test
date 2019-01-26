using SLU.XamarinTest.DataAccess.Repositories;
using SLU.XamarinTest.DataAccess.Repositories.Interfaces;

namespace SLU.XamarinTest.Services
{
    public class ItemsService
    {
        private readonly IItemsRepository _itemsRepository;

        public ItemsService()
        {
            // TODO: Dependency injection
            _itemsRepository = new ItemsRepository();
        }
    }
}