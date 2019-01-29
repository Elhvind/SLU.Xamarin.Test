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
        public ActionResult<IEnumerable<WholesalerDTO>> Get()
        {
            return Ok(_wholesalerService.GetAllWholesalers());
        }

        [HttpGet("{id}")]
        public ActionResult<WholesalerDTO> Get(int id)
        {
            var wholesaler = _wholesalerService.GetWholesaler(id);

            if (wholesaler != null)
                return Ok(wholesaler);
            else
                return NotFound();
        }

        [HttpPost]
        public ActionResult Post([FromBody] WholesalerDTO wholesaler)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var newWholesalerId = _wholesalerService.CreateWholesaler(wholesaler);
            var wholesalerUrl = Url.Action("Get", new { id = newWholesalerId });
            return Created(wholesalerUrl, newWholesalerId);
        }

        [HttpPut("{id}")]
        public ActionResult Put(int id, [FromBody] WholesalerDTO wholesaler)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var updated = _wholesalerService.UpdateWholesaler(id, wholesaler);

            if (updated)
                return Ok();
            else
                return NotFound();
        }

        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            var deleted = _wholesalerService.DeleteWholesaler(id);

            if (deleted)
                return NoContent();
            else
                return NotFound();
        }
    }
}