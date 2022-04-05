using Microsoft.AspNetCore.Mvc;
using GuiFlix_Models.Models;
using GuiFlix_Repositories.Repositories;

namespace GuiFlix_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProfileController : GenericController<Profile>
    {
        public ProfileController(IRepository<Profile> profileRepository) : base(profileRepository)
        {
        }
    }
}
