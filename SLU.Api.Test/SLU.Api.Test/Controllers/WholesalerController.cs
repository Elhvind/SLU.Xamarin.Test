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
            //TODO: Dependency injection
            _wholesalerRepository = new WholesalerRepository();
        }

        [HttpGet]
        public ActionResult<IEnumerable<WholesalerEntity>> Get()
        {
            return Ok(_wholesalerRepository.GetAll());
        }

        [HttpGet("{id}")]
        public ActionResult<WholesalerEntity> Get(int id)
        {
            var wholesaler = _wholesalerRepository.Get(id);

            if (wholesaler != null)
                return Ok(wholesaler);
            else
                return NotFound();
        }

        [HttpPost]
        public ActionResult Post([FromBody] WholesalerEntity wholesaler)
        {
            if (ModelState.IsValid)
            {
                _wholesalerRepository.Create(wholesaler);
                return Created(Url.Action("Get", "Wholesaler", new { id = wholesaler.Id }), wholesaler.Id);
            }
            else
            {
                return BadRequest();
            }
        }

        [HttpPut("{id}")]
        public ActionResult Put(int id, [FromBody] WholesalerEntity wholesaler)
        {
            var wholesalerToUpdate = _wholesalerRepository.Get(id);

            if (ModelState.IsValid && wholesalerToUpdate != null)
            {
                _wholesalerRepository.Update(wholesalerToUpdate, wholesaler);
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
            var deleted = _wholesalerRepository.Delete(id);

            if (deleted)
                return NoContent();
            else
                return BadRequest();
        }
    }
}