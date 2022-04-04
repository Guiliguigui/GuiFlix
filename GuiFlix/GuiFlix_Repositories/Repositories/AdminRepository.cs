using GuiFlix_Models.Models;
using GuiFlix_Repositories.Data;

namespace GuiFlix_Repositories.Repositories
{
    public class AdminRepository : GenericRepository<Admin>
    {
        public AdminRepository(ApplicationDbContext applicationDbContext) : base(applicationDbContext)
        {
        }
    }
}
