using SLU.ApiTest.DataAccess.Repositories;
using SLU.ApiTest.DataAccess.Repositories.Interfaces;
using SLU.ApiTest.Services.Interfaces;

namespace SLU.ApiTest.Services
{
    public class ItemService : IItemService
    {
        private readonly IItemRepository _itemRepository;

        public ItemService()
        {
            _itemRepository = new ItemRepository();
        }
    }
}
