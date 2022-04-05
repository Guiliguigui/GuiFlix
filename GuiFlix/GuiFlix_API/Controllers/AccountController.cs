using Microsoft.AspNetCore.Mvc;
using GuiFlix_Models.Models;
using GuiFlix_Repositories.Repositories;

namespace GuiFlix_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccountController : GenericController<Account>
    {
        public AccountController(IRepository<Account> accountRepository) : base(accountRepository)
        {
        }
    }
}
