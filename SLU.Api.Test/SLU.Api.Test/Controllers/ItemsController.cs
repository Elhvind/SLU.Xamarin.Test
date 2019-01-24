using Microsoft.AspNetCore.Mvc;
using SLU.Api.Test.Data.Entities;
using SLU.Api.Test.Repositories;
using SLU.Api.Test.Repositories.Interfaces;
using System.Collections.Generic;

namespace SLU.Api.Test.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ItemsController : ControllerBase
    {
        private readonly IItemsRepository _itemsRepository;

        public ItemsController()
        {
            _itemsRepository = new ItemsRepository();
        }

        [HttpGet]
        public ActionResult<IEnumerable<ItemEntity>> Get()
        {
            return new List<ItemEntity>();
        }

        [HttpGet("{id}")]
        public ActionResult<ItemEntity> Get(int id)
        {
            return _itemsRepository.Get(id);
        }

        [HttpPost]
        public void Post([FromBody] ItemEntity value)
        {
        }

        [HttpPut("{id}")]
        public void Put(int id, [FromBody] ItemEntity value)
        {
        }

        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}