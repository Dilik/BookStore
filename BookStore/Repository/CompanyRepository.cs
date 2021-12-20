using BookStore.Models;
using BookStore.Repository.IRepository;

namespace BookStore.Repository
{
    public class CompanyRepository : Repository<Company>, ICompanyRepository
    {
        private Context _db;
        public CompanyRepository(Context  db) : base(db)
        {
            _db = db;
        }

        public void Update(Company obj)
        {
            _db.Companies.Update(obj);
        }
    }
}
