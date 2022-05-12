using GuiFlix_Models.Models;
using GuiFlix_Repositories.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
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

        public override async Task<IEnumerable<List>> FindRandom(int quantity)
        {
            return await _db.Lists.OrderBy(r => Guid.NewGuid()).Take(quantity)
            .Include(e => e.Medias)
            .ToListAsync();
        }

        public override async Task<IEnumerable<List>> FindRandom(int quantity, Expression<Func<List, bool>> predicate = null)
        {
            return await _db.Lists.Where(predicate).OrderBy(r => Guid.NewGuid()).Take(quantity)
            .Include(e => e.Medias)
            .ToListAsync();
        }
    }
}
