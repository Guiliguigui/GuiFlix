using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using GuiFlix_Repositories.Repositories;

namespace GuiFlix_API.Controllers
{
    public class GenericController<TEntity> : ControllerBase where TEntity : class, new()
    {
        protected readonly IRepository<TEntity> _repository;

        public GenericController(IRepository<TEntity> genericRepository)
        {
            _repository = genericRepository;
        }

        [HttpGet]
        public virtual async Task<ActionResult<IEnumerable<TEntity>>> GetAll()
        {
            return Ok(await _repository.FindAll());
        }

        [HttpGet("{id}")]
        public virtual async Task<ActionResult<TEntity>> Get(int id)
        {
            var account = await _repository.Find(id);

            if (account == null)
            {
                return NotFound();
            }

            return account;
        }

        [HttpPut("{id}")]
        public virtual async Task<IActionResult> Put(TEntity entity)
        {

            if (await _repository.Update(entity) == null)
            {
                return NotFound();
            }

            return NoContent();
        }

        [HttpPost]
        public virtual async Task<ActionResult<TEntity>> Post(TEntity entity)
        {
            entity = await _repository.Create(entity);

            return CreatedAtAction("Get", new { id = entity.GetType().GetProperty("Id").GetValue(entity) }, entity);
        }

        [HttpDelete("{id}")]
        public virtual async Task<IActionResult> Delete(int id)
        {
            var entity = await _repository.Find(id);
            if (entity == null)
            {
                return NotFound();
            }

            await _repository.Delete(id);

            return NoContent();
        }
    }
}
