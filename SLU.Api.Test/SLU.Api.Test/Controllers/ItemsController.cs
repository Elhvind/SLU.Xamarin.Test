using Microsoft.AspNetCore.Mvc;
using SLU.Api.Test.Repositories;
using SLU.Api.Test.Repositories.Interfaces;
using System.Collections.Generic;

namespace SLU.Api.Test.Controllers
{
    [Route("items/[controller]")]
    [ApiController]
    public class ItemsController : ControllerBase
    {
        private readonly IItemsRepository _itemsRepository;

        public ItemsController()
        {
            _itemsRepository = new ItemsRepository();
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