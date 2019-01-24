using SLU.Api.Test.Common.Repositories;
using SLU.Api.Test.Data.Entities;
using SLU.Api.Test.Repositories.Interfaces;

namespace SLU.Api.Test.Repositories
{
    public class UsedItemsRepository : RepositoryBase<UsedItemEntity>, IUsedItemsRepository
    {
        public UsedItemsRepository() : base("useditems.json")
        {

        }
    }
}