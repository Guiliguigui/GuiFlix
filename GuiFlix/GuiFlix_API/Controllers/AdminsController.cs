using Microsoft.AspNetCore.Mvc;
using GuiFlix_Models.Models;
using GuiFlix_Repositories.Repositories;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using System;
using GuiFlix_API.Helpers;
using GuiFlix_Repositories.Services;

namespace GuiFlix_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize(Roles = Constants.RoleAdminAccount)]
    public class AdminsController : GenericController<Admin>
    {
        private readonly ICryptPasswordService _cryptPasswordService;
        public AdminsController(IRepository<Admin> adminRepository,
            ICryptPasswordService cryptPasswordService) : base(adminRepository)
        {
            _cryptPasswordService = cryptPasswordService;
        }
        public override Task<ActionResult<Admin>> Post(Admin entity)
        {
            entity.Password = _cryptPasswordService.EncryptPassword(entity.Password);
            return base.Post(entity);
        }
        public override Task<IActionResult> Put(Admin entity)
        {
            entity.Password = _cryptPasswordService.EncryptPassword(entity.Password);
            return base.Put(entity);
        }
    }
}
