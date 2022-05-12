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
    public class CategoryRepository : GenericRepository<Category>
    {
        public CategoryRepository(ApplicationDbContext applicationDbContext) : base(applicationDbContext)
        {
        }

        public override async Task<Category> Find(int id)
        {
            return await _db.Categories.Include(e => e.Medias)
                .FirstOrDefaultAsync(e => e.Id == id);
        }

        public override async Task<Category> Find(Expression<Func<Category, bool>> predicate)
        {
            return await _db.Categories.Include(e => e.Medias)
                .FirstOrDefaultAsync(predicate);
        }

        public override async Task<IEnumerable<Category>> FindRandom(int quantity)
        {
            return await _db.Categories.OrderBy(r => Guid.NewGuid()).Take(quantity)
            .Include(e => e.Medias)
            .ToListAsync();
        }
        public override async Task<IEnumerable<Category>> FindRandom(int quantity, Expression<Func<Category, bool>> predicate)
        {
            return await _db.Categories.Where(predicate).OrderBy(r => Guid.NewGuid()).Take(quantity)
            .Include(e => e.Medias)
            .ToListAsync();
        }
    }
}
