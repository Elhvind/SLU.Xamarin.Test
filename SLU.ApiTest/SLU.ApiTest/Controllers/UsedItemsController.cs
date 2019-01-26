using Microsoft.AspNetCore.Mvc;
using SLU.ApiTest.Data.Entities;
using SLU.ApiTest.Repositories;

namespace SLU.ApiTest.Controllers
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