using Microsoft.AspNetCore.Mvc;
using SLU.Api.Test.Repositories;
using SLU.Api.Test.Repositories.Interfaces;
using System.Collections.Generic;

namespace SLU.Api.Test.Controllers
{
    [Route("wholesalers/[controller]")]
    [ApiController]
    public class WholesalerController : ControllerBase
    {
        private readonly IWholesalerRepository _wholesalerRepository;

        public WholesalerController()
        {
            _wholesalerRepository = new WholesalerRepository();
        }

        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            return new string[] { "value1", "value2" };
        }

        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            return "value";
        }

        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}