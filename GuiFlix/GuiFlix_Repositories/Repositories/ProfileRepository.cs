using GuiFlix_Models.Models;
using GuiFlix_Repositories.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace GuiFlix_Repositories.Repositories
{
    public class ProfileRepository : GenericRepository<Profile>
    {
        public ProfileRepository(ApplicationDbContext applicationDbContext) : base(applicationDbContext)
        {
        }

        public override async Task<Profile> Find(int id)
        {
            return await _db.Profiles.Include(e => e.Likes)
                .Include(e => e.Lists)
                .ThenInclude(l => l.Medias)
                .FirstOrDefaultAsync(e => e.Id == id);
        }
        public override async Task<Profile> Find(Expression<Func<Profile, bool>> predicate)
        {
            return await _db.Profiles.Include(e => e.Likes)
                .Include(e => e.Lists)
                .ThenInclude(l => l.Medias)
                .FirstOrDefaultAsync(predicate);
        }
    }
}
