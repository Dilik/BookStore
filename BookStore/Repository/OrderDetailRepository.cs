using BookStore.Models;
using BookStore.Repository.IRepository;

namespace BookStore.Repository
{
    public class OrderDetailRepository : Repository<OrderDetail>, IOrderDetailRepository
    {
        private Context _db;
        public OrderDetailRepository(Context  db) : base(db)
        {
            _db = db;
        }

        public void Update(OrderDetail obj)
        {
            _db.OrderDetail.Update(obj);
        }
    }
}
