using GuiFlix_Models.Models;
using GuiFlix_Repositories.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace GuiFlix_Repositories.Repositories
{
    public class AccountRepository : GenericRepository<Account>
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
