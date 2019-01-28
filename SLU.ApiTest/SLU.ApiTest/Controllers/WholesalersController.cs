using Microsoft.AspNetCore.Mvc;
using SLU.ApiTest.Models.Wholesalers;
using SLU.ApiTest.Services;
using SLU.ApiTest.Services.Interfaces;
using System.Collections.Generic;

namespace SLU.ApiTest.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class WholesalersController : ControllerBase
    {
        private readonly IWholesalerService _wholesalerService;

        public WholesalersController()
        {
            //TODO: Dependency injection
            _wholesalerService = new WholesalerService();
        }

        [HttpGet]
        public virtual ActionResult<IEnumerable<WholesalerDTO>> Get()
        {
            return Ok(_wholesalerService.GetAllWholesalers());
        }

        [HttpGet("{id}")]
        public virtual ActionResult<WholesalerDTO> Get(int id)
        {
            var item = _wholesalerService.GetWholesaler(id);

            if (item != null)
                return Ok(item);
            else
                return NotFound();
        }

        [HttpPost]
        public virtual ActionResult Post([FromBody] WholesalerDTO item)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var newItemId = _wholesalerService.CreateWholesaler(item);
            var itemUrl = Url.Action("Get", new { id = newItemId });
            return Created(itemUrl, newItemId);
        }

        [HttpPut("{id}")]
        public virtual ActionResult Put(int id, [FromBody] WholesalerDTO item)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var updated = _wholesalerService.UpdateWholesaler(id, item);

            if (updated)
                return Ok();
            else
                return NotFound();
        }

        [HttpDelete("{id}")]
        public virtual ActionResult Delete(int id)
        {
            var deleted = _wholesalerService.DeleteWholesaler(id);

            if (deleted)
                return NoContent();
            else
                return NotFound();
        }
    }
}