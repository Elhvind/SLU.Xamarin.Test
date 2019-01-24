using Microsoft.AspNetCore.Mvc;
using SLU.Api.Test.Data.Entities;
using SLU.Api.Test.Repositories;
using SLU.Api.Test.Repositories.Interfaces;
using System.Collections.Generic;

namespace SLU.Api.Test.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsedItemsController : ControllerBase
    {
        private readonly IUsedItemsRepository _usedItemsRepository;

        public UsedItemsController()
        {
            //TODO: Dependency injection
            _usedItemsRepository = new UsedItemsRepository();
        }

        [HttpGet]
        public ActionResult<IEnumerable<UsedItemEntity>> Get()
        {
            return Ok(_usedItemsRepository.Get());
        }

        [HttpGet("{id}")]
        public ActionResult<UsedItemEntity> Get(int id)
        {
            var usedItem = _usedItemsRepository.Get(id);

            if (usedItem != null)
                return Ok(usedItem);
            else
                return NotFound();
        }

        [HttpPost]
        public void Post([FromBody] UsedItemEntity value)
        {
        }

        [HttpPut("{id}")]
        public void Put(int id, [FromBody] UsedItemEntity value)
        {
        }

        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            _usedItemsRepository.Delete(id);
        }
    }
}