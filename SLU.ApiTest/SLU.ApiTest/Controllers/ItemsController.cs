using Microsoft.AspNetCore.Mvc;
using SLU.ApiTest.Models.Items;
using SLU.ApiTest.Services;
using SLU.ApiTest.Services.Interfaces;
using System.Collections.Generic;

namespace SLU.ApiTest.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ItemsController : ControllerBase
    {
        private readonly IItemService _itemService;

        public ItemsController()
        {
            //TODO: Dependency injection
            _itemService = new ItemService();
        }

        [HttpGet]
        public ActionResult<IEnumerable<ItemDTO>> Get()
        {
            return Ok(_itemService.GetAllItems());
        }

        [HttpGet("{id}")]
        public ActionResult<ItemDTO> Get(int id)
        {
            var item = _itemService.GetItem(id);

            if (item != null)
                return Ok(item);
            else
                return NotFound();
        }

        [HttpGet("{id}/details")]
        public ActionResult<ItemDTO> GetDetails(int id)
        {
            var item = _itemService.GetItemDetails(id);

            if (item != null)
                return Ok(item);
            else
                return NotFound();
        }

        [HttpPost]
        public ActionResult Post([FromBody] ItemDTO item)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var newItemId = _itemService.CreateItem(item);
            var itemUrl = Url.Action("Get", new { id = newItemId });
            return Created(itemUrl, newItemId);
        }

        [HttpPut("{id}")]
        public ActionResult Put(int id, [FromBody] ItemDTO item)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var updated = _itemService.UpdateItem(id, item);

            if (updated)
                return Ok();
            else
                return NotFound();
        }

        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            var deleted = _itemService.DeleteItem(id);

            if (deleted)
                return NoContent();
            else
                return NotFound();
        }
    }
}