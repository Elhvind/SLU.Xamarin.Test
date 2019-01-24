using Microsoft.AspNetCore.Mvc;
using SLU.Api.Test.Data.Entities;
using SLU.Api.Test.Repositories;

namespace SLU.Api.Test.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsedItemsController : DataEntityControllerBase<UsedItemEntity>
    {
        public UsedItemsController() : base(new UsedItemsRepository())
        {
            //TODO: Dependency injection
        }
    }
}