using SLU.Api.Test.Core.Repositories;
using SLU.Api.Test.Data.Entities;

namespace SLU.Api.Test.Repositories
{
    public class UsedItemsRepository : RepositoryBase<UsedItemEntity>
    {
        public UsedItemsRepository() : base("useditems.json")
        {

        }
    }
}