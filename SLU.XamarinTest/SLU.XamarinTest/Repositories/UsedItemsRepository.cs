using SLU.XamarinTest.Common.Repositories;
using SLU.XamarinTest.Data.Entities;
using SLU.XamarinTest.Repositories.Common;
using SLU.XamarinTest.Repositories.Interfaces;

namespace SLU.XamarinTest.Repositories
{
    public class UsedItemsRepository : RepositoryBase<UsedItemEntity>, IRepository<UsedItemEntity>, IUsedItemsRepository
    {
        public UsedItemsRepository() : base("useditems.json")
        {
        }
    }
}