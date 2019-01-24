using Microsoft.AspNetCore.Mvc;
using SLU.Api.Test.Data.Entities;
using SLU.Api.Test.Repositories;

namespace SLU.Api.Test.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class WholesalerController : DataEntityControllerBase<WholesalerEntity>
    {
        public WholesalerController() : base(new WholesalerRepository())
        {
            //TODO: Dependency injection
        }
    }
}