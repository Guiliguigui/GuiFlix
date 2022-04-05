using Microsoft.AspNetCore.Mvc;
using GuiFlix_Models.Models;
using GuiFlix_Repositories.Repositories;

namespace GuiFlix_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LikeController : GenericController<Like>
    {
        public LikeController(IRepository<Like> likeRepository) : base(likeRepository)
        {
        }
    }
}
