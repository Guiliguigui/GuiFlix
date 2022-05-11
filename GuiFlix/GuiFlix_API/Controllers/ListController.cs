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
    public class ListController : GenericController<List>
    {
        public ListController(IRepository<List> listRepository) : base(listRepository)
        {
        }

        [HttpGet("Random")]
        public virtual async Task<ActionResult<List>> GetRandom(int quantity)
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
