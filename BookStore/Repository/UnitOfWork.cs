using BookStore.Models;
using BookStore.Repository.IRepository;

namespace BookStore.Repository
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly Context _db;
        public UnitOfWork(Context db)
        {
            _db = db;
            Category = new CategoryRepository(_db);
            CoverType = new CoverTypeRepository(_db);
        }
        public ICategoryRepository Category { get; private set; }
        public ICoverTypeRepository CoverType { get; private set; }

        public void Save()
        {
            _db.SaveChanges();
        }
    }
}
