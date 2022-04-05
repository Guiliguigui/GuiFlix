using Microsoft.AspNetCore.Mvc;
using GuiFlix_Models.Models;
using GuiFlix_Repositories.Repositories;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;

namespace GuiFlix_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AdminsController : GenericController<Admin>
    {
        public AdminsController(IRepository<Admin> adminRepository) : base(adminRepository)
        {
        }

        [NonAction]
        public async override Task<ActionResult<Admin>> Post(Admin entity)
        {
            return await base.Post(entity);
        }

        [NonAction]
        public async override Task<IActionResult> Put(Admin entity)
        {
            return await base.Put(entity);
        }

        [NonAction]
        public override Task<IActionResult> Delete(int id)
        {
            return base.Delete(id);
        }
    }
}
