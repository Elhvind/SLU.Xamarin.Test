using Microsoft.AspNetCore.Mvc;
using SLU.Api.Test.Data.Entities;
using SLU.Api.Test.Repositories;

namespace SLU.Api.Test.Controllers
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