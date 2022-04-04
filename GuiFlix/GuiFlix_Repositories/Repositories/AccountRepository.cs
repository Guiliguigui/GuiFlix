using GuiFlix_Models.Models;
using GuiFlix_Repositories.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace GuiFlix_Repositories.Repositories
{
    internal class AccountRepository : GenericRepository<Account>
    {
        public AccountRepository(ApplicationDbContext applicationDbContext) : base(applicationDbContext)
        {
        }

        public override async Task<Account> Find(int id)
        {
            return await _db.Accounts.Include(e => e.Profiles)
                                     .FirstOrDefaultAsync(e => e.Id == id);
        }
        public override async Task<Account> Find(Expression<Func<Account, bool>> predicate)
        {
            return await _db.Accounts.Include(e => e.Profiles)
                                     .FirstOrDefaultAsync(predicate);
        }
    }
}
