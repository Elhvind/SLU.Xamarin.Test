using SLU.XamarinTest.DataAccess.Entities;
using SLU.XamarinTest.DataAccess.Repositories.Common;
using SLU.XamarinTest.DataAccess.Repositories.Interfaces;

namespace SLU.XamarinTest.DataAccess.Repositories
{
    public class UsedItemsRepository : RepositoryBase<UsedItemEntity>, IRepository<UsedItemEntity>, IUsedItemsRepository
    {
        public UsedItemsRepository() : base("useditems.json")
        {
        }
    }
}