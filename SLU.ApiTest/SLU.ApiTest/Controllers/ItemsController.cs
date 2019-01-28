using Microsoft.AspNetCore.Mvc;
using SLU.ApiTest.Controllers.Core;
using SLU.ApiTest.DataAccess.Models;
using SLU.ApiTest.DataAccess.Repositories;

namespace SLU.ApiTest.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ItemsController : DataEntityControllerBase<ItemEntity>
    {
        public ItemsController() : base(new ItemRepository())
        {
            //TODO: Dependency injection
        }
    }
}