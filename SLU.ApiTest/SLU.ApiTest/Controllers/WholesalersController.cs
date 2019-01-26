using Microsoft.AspNetCore.Mvc;
using SLU.ApiTest.Data.Entities;
using SLU.ApiTest.Repositories;

namespace SLU.ApiTest.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class WholesalersController : DataEntityControllerBase<WholesalerEntity>
    {
        public WholesalersController() : base(new WholesalerRepository())
        {
            //TODO: Dependency injection
        }
    }
}