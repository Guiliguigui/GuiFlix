using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using GuiFlix_Models.Models;
using GuiFlix_Repositories.Data;
using GuiFlix_Repositories.Repositories;

namespace GuiFlix_API.Controllers
{
    public class GenericController<TEntity> : ControllerBase where TEntity : class, new()
    {
        private readonly IRepository<TEntity> _genericRepository;

        public GenericController(IRepository<TEntity> genericRepository)
        {
            _genericRepository = genericRepository;
        }

        [HttpGet]
        public virtual async Task<ActionResult<IEnumerable<TEntity>>> GetAll()
        {
            return Ok(await _genericRepository.FindAll());
        }

        [HttpGet("{id}")]
        public virtual async Task<ActionResult<TEntity>> Get(int id)
        {
            var account = await _genericRepository.Find(id);

            if (account == null)
            {
                return NotFound();
            }

            return account;
        }

        [HttpPut("{id}")]
        public virtual async Task<IActionResult> Put(TEntity entity)
        {

            if (await _genericRepository.Update(entity) == null)
            {
                return NotFound();
            }

            return NoContent();
        }

        [HttpPost]
        public virtual async Task<ActionResult<TEntity>> Post(TEntity entity)
        {
            entity = await _genericRepository.Create(entity);

            return CreatedAtAction("GetIEntity", new { id = entity.GetType().GetProperty("Id").GetValue(entity) }, entity);
        }

        [HttpDelete("{id}")]
        public virtual async Task<IActionResult> Delete(int id)
        {
            var entity = await _genericRepository.Find(id);
            if (entity == null)
            {
                return NotFound();
            }

            await _genericRepository.Delete(id);

            return NoContent();
        }
    }
}
