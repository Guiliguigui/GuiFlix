using Microsoft.AspNetCore.Mvc;
using GuiFlix_Models.Models;
using GuiFlix_Repositories.Repositories;
using System.Threading.Tasks;
using GuiFlix_Repositories.Services;

namespace GuiFlix_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccountController : GenericController<Account>
    {
        private readonly ICryptPasswordService _cryptPasswordService;
        public AccountController(IRepository<Account> accountRepository,
            ICryptPasswordService cryptPasswordService) : base(accountRepository)
        {
            _cryptPasswordService = cryptPasswordService;
        }
        public override Task<ActionResult<Account>> Post(Account entity)
        {
            entity.Password = _cryptPasswordService.EncryptPassword(entity.Password);
            return base.Post(entity);
        }
        public override Task<IActionResult> Put(Account entity)
        {
            entity.Password = _cryptPasswordService.EncryptPassword(entity.Password);
            return base.Put(entity);
        }
    }
}
