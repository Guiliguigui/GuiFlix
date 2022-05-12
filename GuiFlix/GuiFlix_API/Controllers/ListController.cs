using Microsoft.AspNetCore.Mvc;
using GuiFlix_Models.Models;
using GuiFlix_Repositories.Repositories;
using System.Threading.Tasks;
using System.Linq;
using System;
using System.Collections.Generic;

namespace GuiFlix_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ListController : GenericController<List>
    {
        protected readonly IRepository<Media> _mediaRepository;
        public ListController(IRepository<List> listRepository, IRepository<Media> mediaRepository) : base(listRepository)
        {
            _mediaRepository = mediaRepository;
        }

        [HttpGet("Random")]
        public virtual async Task<ActionResult<IEnumerable<List>>> GetRandom(int quantity, string? mediaType)
        {
            if (mediaType == null)
                return Ok((await _repository.FindRandom(quantity))
                .Select(e =>
                {
                    e.Medias = e.Medias.OrderBy(r => Guid.NewGuid()).ToList();
                    return e;
                }));

            if (mediaType == nameof(TVShow) || mediaType == nameof(Film))
            {
                var lists = await _repository.FindRandom(quantity);
                foreach (var list in lists)
                {
                    list.Medias = (await _mediaRepository.FindRandom(int.MaxValue, m => m.Lists.Contains(list) && m.Type == mediaType)).ToList();
                }
                return Ok(lists);
            }

            return BadRequest($"Invalid Type, must be either null, \"{nameof(TVShow)}\" or \"{nameof(Film)}\"");
        }
    }
}
