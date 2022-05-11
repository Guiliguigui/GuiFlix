using Microsoft.AspNetCore.Mvc;
using GuiFlix_Models.Models;
using GuiFlix_Repositories.Repositories;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using System;

namespace GuiFlix_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AdminsController : GenericController<Admin>
    {
        public AdminsController(IRepository<Admin> adminRepository) : base(adminRepository)
        {
        }
    }
}
