using Microsoft.AspNetCore.Mvc;
using GuiFlix_Models.Models;
using GuiFlix_Repositories.Repositories;
using System.Threading.Tasks;
using System.Linq;
using System;

namespace GuiFlix_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : GenericController<Category>
    {
        public CategoryController(IRepository<Category> categoryRepository) : base(categoryRepository)
        {
        }

        [HttpGet("Random")]
        public virtual async Task<ActionResult<Category>> GetRandom(int quantity)
        {
            return Ok((await _repository.FindRandom(quantity))
                .Select(e =>
                {
                    e.Medias = e.Medias.OrderBy(r => Guid.NewGuid()).ToList();
                    return e;
                }));
        }
    }
}
