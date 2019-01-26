using SLU.ApiTest.Common.Repositories;
using SLU.ApiTest.Data.Entities;
using SLU.ApiTest.Repositories.Common;
using SLU.ApiTest.Repositories.Interfaces;

namespace SLU.ApiTest.Repositories
{
    public class UsedItemsRepository : RepositoryBase<UsedItemEntity>, IRepository<UsedItemEntity>, IUsedItemsRepository
    {
        public UsedItemsRepository() : base("useditems.json")
        {
        }
    }
}