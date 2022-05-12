using Microsoft.AspNetCore.Mvc;
using GuiFlix_Models.Models;
using GuiFlix_Repositories.Repositories;
using System.Threading.Tasks;
using System.Collections.Generic;

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
        public virtual async Task<ActionResult<IEnumerable<Media>>> GetRandom(int quantity, string? mediaType)
        {
            if (mediaType == null)
                return Ok(await _repository.FindRandom(quantity));
            if (mediaType == nameof(TVShow) || mediaType == nameof(Film))
                return Ok(await _repository.FindRandom(quantity, m => m.Type == mediaType));
            return BadRequest($"Invalid Type, must be either null, \"{nameof(TVShow)}\" or \"{nameof(Film)}\"");
        }
    }
}
