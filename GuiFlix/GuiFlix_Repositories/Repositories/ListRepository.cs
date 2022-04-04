using GuiFlix_Models.Models;
using GuiFlix_Repositories.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace GuiFlix_Repositories.Repositories
{
    public class ListRepository : GenericRepository<List>
    {
        public ListRepository(ApplicationDbContext applicationDbContext) : base(applicationDbContext)
        {
        }

        public override async Task<List> Find(int id)
        {
            return await _db.Lists.Include(e => e.Medias)
                .FirstOrDefaultAsync(e => e.Id == id);
        }

        public override async Task<List> Find(Expression<Func<List, bool>> predicate)
        {
            return await _db.Lists.Include(e => e.Medias)
                .FirstOrDefaultAsync(predicate);
        }
    }
}
