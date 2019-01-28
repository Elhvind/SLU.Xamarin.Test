using SLU.ApiTest.DataAccess.Models;
using SLU.ApiTest.DataAccess.Repositories.Core;
using SLU.ApiTest.DataAccess.Repositories.Interfaces;

namespace SLU.ApiTest.DataAccess.Repositories
{
    public class UsedItemRepository : RepositoryBase<UsedItemEntity>, IRepository<UsedItemEntity>, IUsedItemRepository
    {
        public UsedItemRepository() : base("useditems.json")
        {
        }
    }
}