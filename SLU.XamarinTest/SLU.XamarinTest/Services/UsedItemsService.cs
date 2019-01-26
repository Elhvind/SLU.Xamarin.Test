using SLU.XamarinTest.DataAccess.Repositories;
using SLU.XamarinTest.DataAccess.Repositories.Interfaces;

namespace SLU.XamarinTest.Services
{
    public class UsedItemsService : IUsedItemsService
    {
        private readonly IUsedItemsRepository _usedItemsRepository;

        public UsedItemsService()
        {
            // TODO: Dependency injection
            _usedItemsRepository = new UsedItemsRepository();
        }
    }
}