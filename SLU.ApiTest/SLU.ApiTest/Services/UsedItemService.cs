using SLU.ApiTest.DataAccess.Repositories;
using SLU.ApiTest.DataAccess.Repositories.Interfaces;
using SLU.ApiTest.Services.Interfaces;

namespace SLU.ApiTest.Services
{
    public class UsedItemService : IUsedItemService
    {
        private readonly IUsedItemRepository _usedItemRepository;

        public UsedItemService()
        {
            _usedItemRepository = new UsedItemRepository();
        }
    }
}
