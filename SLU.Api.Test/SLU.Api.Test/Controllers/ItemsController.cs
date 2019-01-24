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
            //TODO: Dependency injection
            _itemsRepository = new ItemsRepository();
        }

        [HttpGet]
        public ActionResult<IEnumerable<ItemEntity>> Get()
        {
            return Ok(_itemsRepository.GetAll());
        }

        [HttpGet("{id}")]
        public ActionResult<ItemEntity> Get(int id)
        {
            var item = _itemsRepository.Get(id);

            if (item != null)
                return Ok(item);
            else
                return NotFound();
        }

        [HttpPost]
        public ActionResult Post([FromBody] ItemEntity item)
        {
            if (ModelState.IsValid)
            {
                _itemsRepository.Create(item);
                return Created(Url.Action("Get", "Items", new { id = item.Id }), item.Id);
            }
            else
            {
                return BadRequest();
            }
        }

        [HttpPut("{id}")]
        public ActionResult Put(int id, [FromBody] ItemEntity item)
        {
            var itemToUpdate = _itemsRepository.Get(id);

            if (ModelState.IsValid && itemToUpdate != null)
            {
                _itemsRepository.Update(itemToUpdate, item);
                return Ok();
            }
            else
            {
                return BadRequest();
            }
        }

        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            var deleted = _itemsRepository.Delete(id);

            if (deleted)
                return NoContent();
            else
                return BadRequest();
        }
    }
}