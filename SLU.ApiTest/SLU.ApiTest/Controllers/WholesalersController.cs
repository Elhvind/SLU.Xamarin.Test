using Microsoft.AspNetCore.Mvc;
using SLU.ApiTest.Controllers.Core;
using SLU.ApiTest.DataAccess.Models;
using SLU.ApiTest.DataAccess.Repositories;

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