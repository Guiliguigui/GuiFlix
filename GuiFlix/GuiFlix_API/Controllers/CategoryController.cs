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
    public class CategoryController : GenericController<Category>
    {
        protected readonly IRepository<Media> _mediaRepository;
        public CategoryController(IRepository<Category> categoryRepository, IRepository<Media> mediaRepository) : base(categoryRepository)
        {
            _mediaRepository = mediaRepository;
        }

        [HttpGet("Random")]
        public virtual async Task<ActionResult<IEnumerable<Category>>> GetRandom(int quantity, string? mediaType)
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
                var categories = await _repository.FindRandom(quantity);
                foreach (var category in categories)
                {
                    category.Medias = (await _mediaRepository.FindRandom(int.MaxValue, m => m.Categories.Contains(category) && m.Type == mediaType)).ToList();
                }
                return Ok(categories);  
            }

            return BadRequest($"Invalid Type, must be either null, \"{nameof(TVShow)}\" or \"{nameof(Film)}\"");
        }
    }
}
