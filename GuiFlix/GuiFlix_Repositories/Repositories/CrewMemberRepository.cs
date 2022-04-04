using GuiFlix_Models.Models;
using GuiFlix_Repositories.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace GuiFlix_Repositories.Repositories
{
    public class CrewMemberRepository : GenericRepository<CrewMember>
    {
        public CrewMemberRepository(ApplicationDbContext applicationDbContext) : base(applicationDbContext)
        {
        }

        public override async Task<CrewMember> Find(int id)
        {
            return await _db.CrewMembers.Include(e => e.Medias)
                .ThenInclude(e => e.Media)
                .FirstOrDefaultAsync(e => e.Id == id);
        }

        public override async Task<CrewMember> Find(Expression<Func<CrewMember, bool>> predicate)
        {
            return await _db.CrewMembers.Include(e => e.Medias)
                .ThenInclude(e => e.Media)
                .FirstOrDefaultAsync(predicate);
        }
    }
}