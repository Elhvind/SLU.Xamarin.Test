using SLU.ApiTest.DataAccess.Models;
using SLU.ApiTest.DataAccess.Repositories.Core;
using SLU.ApiTest.DataAccess.Repositories.Interfaces;

namespace SLU.ApiTest.DataAccess.Repositories
{
    public class UsedItemsRepository : RepositoryBase<UsedItemEntity>, IRepository<UsedItemEntity>, IUsedItemsRepository
    {
        public UsedItemsRepository() : base("useditems.json")
        {
        }
    }
}