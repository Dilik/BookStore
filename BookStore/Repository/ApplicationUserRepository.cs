using BookStore.Models;
using BookStore.Repository.IRepository;

namespace BookStore.Repository
{
    public class ApplicationUserRepository : Repository<ApplicationUser>, IApplicationUserRepository
    {
        private Context _db;
        public ApplicationUserRepository(Context  db) : base(db)
        {
            _db = db;
        }
    }
}
