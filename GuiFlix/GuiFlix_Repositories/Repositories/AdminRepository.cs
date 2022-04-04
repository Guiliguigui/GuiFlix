using GuiFlix_Models.Models;
using GuiFlix_Repositories.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuiFlix_Repositories.Repositories
{
    internal class AdminRepository : GenericRepository<Admin>
    {
        public AdminRepository(ApplicationDbContext applicationDbContext) : base(applicationDbContext)
        {
        }
    }
}
