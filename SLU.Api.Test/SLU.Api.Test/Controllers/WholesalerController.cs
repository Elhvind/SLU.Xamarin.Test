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
            _wholesalerRepository = new WholesalerRepository();
        }

        [HttpGet]
        public ActionResult<IEnumerable<WholesalerEntity>> Get()
        {
            return Ok(_wholesalerRepository.Get());
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
        public void Post([FromBody] WholesalerEntity wholesaler)
        {
            _wholesalerRepository.Create(wholesaler);
        }

        [HttpPut("{id}")]
        public void Put(int id, [FromBody] WholesalerEntity wholesaler)
        {
            _wholesalerRepository.Update(wholesaler);
        }

        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            _wholesalerRepository.Delete(id);
        }
    }
}