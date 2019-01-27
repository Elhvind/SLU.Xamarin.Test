using SLU.XamarinFormsTest.DataAccess.Repositories;
using SLU.XamarinFormsTest.DataAccess.Repositories.Interfaces;

namespace SLU.XamarinFormsTest.Services
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