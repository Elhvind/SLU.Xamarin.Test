﻿using Microsoft.AspNetCore.Mvc;
using SLU.ApiTest.Data.Entities;
using SLU.ApiTest.Repositories.Common;
using System.Collections.Generic;

namespace SLU.ApiTest.Controllers
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
            if (ModelState.IsValid)
            {
                _dataRepository.Create(entity);
                var entityUrl = Url.Action("Get", new { id = entity.Id });
                return Created(entityUrl, entity);
            }
            else
            {
                return BadRequest();
            }
        }

        [HttpPut("{id}")]
        public virtual ActionResult Put(int id, [FromBody] TEntityType entity)
        {
            if (ModelState.IsValid && entity != null)
            {
                var updated = _dataRepository.Update(id, entity);

                if (updated)
                    return Ok();
                else
                    return NotFound();
            }
            else
            {
                return BadRequest();
            }
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