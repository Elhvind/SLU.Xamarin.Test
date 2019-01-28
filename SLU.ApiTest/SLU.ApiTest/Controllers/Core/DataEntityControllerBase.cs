using Microsoft.AspNetCore.Mvc;
using SLU.ApiTest.DataAccess.Models;
using SLU.ApiTest.DataAccess.Repositories.Core;
using System.Collections.Generic;

namespace SLU.ApiTest.Controllers.Core
{
    [ApiController]
    public abstract class DataEntityControllerBase<TEntityType> : ControllerBase where TEntityType : IDataEntity, new()
    {
        private readonly IRepository<TEntityType> _dataRepository;

        public DataEntityControllerBase(IRepository<TEntityType> dataRepository)
        {
            _dataRepository = dataRepository;
        }

        [HttpGet]
        public virtual ActionResult<IEnumerable<TEntityType>> Get()
        {
            return Ok(_dataRepository.GetAll());
        }

        [HttpGet("{id}")]
        public virtual ActionResult<TEntityType> Get(int id)
        {
            var entity = _dataRepository.Get(id);

            if (entity != null)
                return Ok(entity);
            else
                return NotFound();
        }

        [HttpPost]
        public virtual ActionResult Post([FromBody] TEntityType entity)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            _dataRepository.Create(entity);
            var entityUrl = Url.Action("Get", new { id = entity.Id });
            return Created(entityUrl, entity);
        }

        [HttpPut("{id}")]
        public virtual ActionResult Put(int id, [FromBody] TEntityType entity)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var updated = _dataRepository.Update(id, entity);

            if (updated)
                return Ok();
            else
                return NotFound();
        }

        [HttpDelete("{id}")]
        public virtual ActionResult Delete(int id)
        {
            var deleted = _dataRepository.Delete(id);

            if (deleted)
                return NoContent();
            else
                return NotFound();
        }
    }
}