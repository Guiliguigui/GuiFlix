using GuiFlix_Models.Models;
using GuiFlix_Repositories.Data;

namespace GuiFlix_Repositories.Repositories
{
    public class LikeRepository : GenericRepository<Like>
    {
        public LikeRepository(ApplicationDbContext applicationDbContext) : base(applicationDbContext)
        {
        }
    }
}
