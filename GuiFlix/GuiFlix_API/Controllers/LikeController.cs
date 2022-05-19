using Microsoft.AspNetCore.Mvc;
using GuiFlix_Models.Models;
using GuiFlix_Repositories.Repositories;
using System.Threading.Tasks;

namespace GuiFlix_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LikeController : GenericController<Like>
    {
        public LikeController(IRepository<Like> likeRepository) : base(likeRepository)
        {
        }

        [HttpPost("LikeMedia")]
        public async Task<ActionResult<Like>> LikeMedia(Like entity)
        {

            var entityFromDb = await _repository.Find(e => e.ProfileId == entity.ProfileId && e.MediaId == entity.MediaId);
            if (entityFromDb == null)
                entityFromDb = await _repository.Create(entity);
            else
            {
                entity.Id = entityFromDb.Id;
                entity = await _repository.Update(entity);
            }

            return CreatedAtAction("Get", new { id = entity.GetType().GetProperty("Id")!.GetValue(entity) }, entity);
        }
        [HttpGet("IsMediaLiked")]
        public async Task<ActionResult<Like>> IsMediaLiked(int profileId, int mediaId)
        {
            var entityFromDb = await _repository.Find(e => e.ProfileId == profileId && e.MediaId == mediaId);
            if (entityFromDb == null)
                return NoContent();
            return CreatedAtAction("Get", new { id = entityFromDb.Id }, entityFromDb);
        }
    }
}
