using SLU.XamarinFormsTest.DataAccess.Entities;
using SLU.XamarinFormsTest.DataAccess.Repositories.Common;
using SLU.XamarinFormsTest.DataAccess.Repositories.Interfaces;

namespace SLU.XamarinFormsTest.DataAccess.Repositories
{
    public class UsedItemsRepository : RepositoryBase<UsedItemEntity>, IRepository<UsedItemEntity>, IUsedItemsRepository
    {
        public UsedItemsRepository() : base("useditems.json")
        {
        }
    }
}