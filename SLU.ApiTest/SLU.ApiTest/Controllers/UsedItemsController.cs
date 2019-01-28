using Microsoft.AspNetCore.Mvc;
using SLU.ApiTest.Controllers.Core;
using SLU.ApiTest.DataAccess.Models;
using SLU.ApiTest.DataAccess.Repositories;

namespace SLU.ApiTest.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsedItemsController : DataEntityControllerBase<UsedItemEntity>
    {
        public UsedItemsController() : base(new UsedItemRepository())
        {
            //TODO: Dependency injection
        }
    }
}