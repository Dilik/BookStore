using BookStore.Models;
using BookStore.Repository.IRepository;

namespace BookStore.Repository
{
    public class CoverTypeRepository : Repository<CoverType>, ICoverTypeRepository
    {
        private Context _db;
        public CoverTypeRepository(Context  db) : base(db)
        {
            _db = db;
        }

        public void Update(CoverType obj)
        {
            _db.CoverTypes.Update(obj);
        }
    }
}
