using BookStore.Models;
using BookStore.Repository.IRepository;

namespace BookStore.Repository
{
    public class ProductRepository : Repository<Product>, IProductRepository
    {
        private Context _db;
        public ProductRepository(Context  db) : base(db)
        {
            _db = db;
        }

        public void Update(Product obj)
        {
            var objFromDB = _db.Products.FirstOrDefault(u => u.Id == obj.Id);
            if (objFromDB != null) 
            {
                objFromDB.Title = obj.Title;
                objFromDB.ISBN = obj.ISBN;
                objFromDB.Price = obj.Price;
                objFromDB.Price50 = obj.Price50;
                objFromDB.Price100 = obj.Price100;
                objFromDB.ListPrice = obj.ListPrice;
                objFromDB.Description = obj.Description;
                objFromDB.Author = obj.Author;
                objFromDB.CategoryId = obj.CategoryId;
                objFromDB.CoverTypeId = obj.CoverTypeId;
                if (objFromDB.ImageUrl != null) {
                    objFromDB.ImageUrl = obj.ImageUrl;
                }
            }
        }
    }
}
