using BookStore.Models;
using BookStore.Repository.IRepository;

namespace BookStore.Repository
{
    public class CategoryRepository : Repository<Category>, ICategoryRepository
    {
        private Context _db;
        public CategoryRepository(Context  db) : base(db)
        {
            _db = db;
        }

        public void Update(Category obj)
        {
            _db.Categories.Update(obj);
        }
    }
}
