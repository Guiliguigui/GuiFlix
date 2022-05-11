using Microsoft.AspNetCore.Mvc;
using GuiFlix_Models.Models;
using GuiFlix_Repositories.Repositories;
using System.Threading.Tasks;

namespace GuiFlix_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MediaController : GenericController<Media>
    {
        public MediaController(IRepository<Media> mediaRepository) : base(mediaRepository)
        {
        }

        [HttpGet("Random")]
        public virtual async Task<ActionResult<Media>> GetRandom(int quantity)
        {
            return Ok(await _repository.FindRandom(quantity));
        }
    }
}
