using Microsoft.AspNetCore.Mvc;
using SLU.ApiTest.Models.UsedItems;
using SLU.ApiTest.Services;
using SLU.ApiTest.Services.Interfaces;
using System.Collections.Generic;

namespace SLU.ApiTest.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsedItemsController : ControllerBase
    {
        private readonly IUsedItemService _usedItemService;

        public UsedItemsController()
        {
            //TODO: Dependency injection
            _usedItemService = new UsedItemService();
        }

        [HttpGet]
        public virtual ActionResult<IEnumerable<UsedItemDTO>> Get()
        {
            return Ok(_usedItemService.GetAllUsedItems());
        }

        [HttpGet("{id}")]
        public virtual ActionResult<UsedItemDTO> Get(int id)
        {
            var item = _usedItemService.GetUsedItem(id);

            if (item != null)
                return Ok(item);
            else
                return NotFound();
        }

        [HttpPost]
        public virtual ActionResult Post([FromBody] UsedItemDTO item)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var newItemId = _usedItemService.CreateUsedItem(item);
            var itemUrl = Url.Action("Get", new { id = newItemId });
            return Created(itemUrl, newItemId);
        }

        [HttpPut("{id}")]
        public virtual ActionResult Put(int id, [FromBody] UsedItemDTO item)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var updated = _usedItemService.UpdateUsedItem(id, item);

            if (updated)
                return Ok();
            else
                return NotFound();
        }

        [HttpDelete("{id}")]
        public virtual ActionResult Delete(int id)
        {
            var deleted = _usedItemService.DeleteUsedItem(id);

            if (deleted)
                return NoContent();
            else
                return NotFound();
        }
    }
}