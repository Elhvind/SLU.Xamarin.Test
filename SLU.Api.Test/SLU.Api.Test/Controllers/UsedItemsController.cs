﻿using Microsoft.AspNetCore.Mvc;
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
            return Ok(_usedItemsRepository.GetAll());
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
        public ActionResult Post([FromBody] UsedItemEntity usedItem)
        {
            if (ModelState.IsValid)
            {
                _usedItemsRepository.Create(usedItem);
                return Created(Url.Action("Get", "UsedItems", new { id = usedItem.Id }), usedItem);
            }
            else
            {
                return BadRequest();
            }
        }

        [HttpPut("{id}")]
        public ActionResult Put(int id, [FromBody] UsedItemEntity usedItem)
        {
            if (ModelState.IsValid && usedItem != null)
            {
                var updated = _usedItemsRepository.Update(id, usedItem);

                if (updated)
                    return Ok();
                else
                    return BadRequest();
            }
            else
            {
                return BadRequest();
            }
        }

        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            var deleted = _usedItemsRepository.Delete(id);

            if (deleted)
                return NoContent();
            else
                return BadRequest();
        }
    }
}