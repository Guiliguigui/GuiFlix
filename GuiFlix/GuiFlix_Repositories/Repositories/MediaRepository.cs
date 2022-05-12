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
    public class MediaRepository : GenericRepository<Media>
    {
        public MediaRepository(ApplicationDbContext applicationDbContext) : base(applicationDbContext)
        {
        }

        public override async Task<Media> Find(int id)
        {
            var media = await _db.Medias.FirstOrDefaultAsync(e => e.Id == id);
            if(media.Type == nameof(Film))
                return await _db.Films.Include(e => e.Categories)
                    .Include(e => e.CrewMembers)
                    .ThenInclude(e => e.CrewMember)
                    .FirstOrDefaultAsync(e => e.Id == id);
            else
                return await _db.TVShows.Include(e => e.Categories)
                    .Include(e => e.CrewMembers)
                    .ThenInclude(e => e.CrewMember)
                    .Include(e => e.Episodes)
                    .FirstOrDefaultAsync(e => e.Id == id);
        }

        public override async Task<Media> Find(Expression<Func<Media, bool>> predicate)
        {

            var media = await _db.Medias.FirstOrDefaultAsync(predicate);
            if (media.Type == nameof(Film))
                return await _db.Films.Include(e => e.Categories)
                    .Include(e => e.CrewMembers)
                    .ThenInclude(e => e.CrewMember)
                    .FirstOrDefaultAsync(predicate);
            else
                return await _db.TVShows.Include(e => e.Categories)
                    .Include(e => e.CrewMembers)
                    .ThenInclude(e => e.CrewMember)
                    .Include(e => e.Episodes)
                    .FirstOrDefaultAsync(predicate);
        }

        public override async Task<IEnumerable<Media>> FindRandom(int quantity)
        {
            return await _db.Medias.OrderBy(r => Guid.NewGuid()).Take(quantity).ToListAsync();
        }

        public override async Task<IEnumerable<Media>> FindRandom(int quantity, Expression<Func<Media, bool>> predicate = null)
        {
            return await _db.Medias.Where(predicate).OrderBy(r => Guid.NewGuid()).Take(quantity).ToListAsync();
        }
    }
}