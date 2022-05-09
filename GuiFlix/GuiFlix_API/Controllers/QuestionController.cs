using GuiFlix_Models.Models;
using GuiFlix_Repositories.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace GuiFlix_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class QuestionController : GenericController<Question>
    {
        public QuestionController(IRepository<Question> genericRepository) : base(genericRepository)
        {
        }
    }
}
