using Microsoft.AspNetCore.Mvc;
using SLU.ApiTest.Data.Entities;
using SLU.ApiTest.Repositories;

namespace SLU.ApiTest.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ItemsController : DataEntityControllerBase<ItemEntity>
    {
        public ItemsController() : base(new ItemsRepository())
        {
            //TODO: Dependency injection
        }
    }
}