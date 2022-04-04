using GuiFlix_Repositories.Data;

namespace GuiFlix_Repositories.Repositories
{
    public abstract class BaseRepository
    {
        protected readonly ApplicationDbContext _db;
        public BaseRepository(ApplicationDbContext applicationDbContext)
        {
            _db = applicationDbContext;
        }
    }
}
