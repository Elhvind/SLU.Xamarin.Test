using Microsoft.AspNetCore.Mvc;
using SLU.Api.Test.Data.Entities;
using SLU.Api.Test.Repositories;
using SLU.Api.Test.Repositories.Interfaces;
using System.Collections.Generic;

namespace SLU.Api.Test.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class WholesalerController : ControllerBase
    {
        private readonly IWholesalerRepository _wholesalerRepository;

        public WholesalerController()
        {
            _wholesalerRepository = new WholesalerRepository();
        }

        [HttpGet]
        public ActionResult<IEnumerable<WholesalerEntity>> Get()
        {
            return new List<WholesalerEntity>();
        }

        [HttpGet("{id}")]
        public ActionResult<WholesalerEntity> Get(int id)
        {
            return new WholesalerEntity();
        }

        [HttpPost]
        public void Post([FromBody] WholesalerEntity value)
        {
        }

        [HttpPut("{id}")]
        public void Put(int id, [FromBody] WholesalerEntity value)
        {
        }

        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}