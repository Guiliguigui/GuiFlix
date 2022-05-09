using GuiFlix_Models.Models;
using GuiFlix_Repositories.Data;

namespace GuiFlix_Repositories.Repositories
{
    public class QuestionRepository : GenericRepository<Question>
    {
        public QuestionRepository(ApplicationDbContext applicationDbContext) : base(applicationDbContext)
        {
        }
    }
}
