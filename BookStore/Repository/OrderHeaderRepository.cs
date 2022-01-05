using BookStore.Models;
using BookStore.Repository.IRepository;

namespace BookStore.Repository
{
    public class OrderHeaderRepository : Repository<OrderHeader>, IOrderHeaderRepository
    {
        private Context _db;
        public OrderHeaderRepository(Context  db) : base(db)
        {
            _db = db;
        }

        public void Update(OrderHeader obj)
        {
            _db.OrderHeaders.Update(obj);
        }

        public void UpdateStatus(int id, string orderStatus, string? paymentStatus = null)
        {
            var orderFromDB = _db.OrderHeaders.FirstOrDefault(u => u.Id == id);
            if(orderFromDB != null)
            {
                orderFromDB.OrderStatus = orderStatus;
                if (paymentStatus != null) { 
                    orderFromDB.PaymentStatus = paymentStatus;
                }
            }
        }

        public void UpdateStripePaymentID(int id, string sessionId, string paymentIntentId)
        {
            var orderFromDB = _db.OrderHeaders.FirstOrDefault(u => u.Id == id);
            orderFromDB.PaymentDate = DateTime.Now;
            orderFromDB.SessionId = sessionId;
            orderFromDB.PaymentIntentId = paymentIntentId;
        }
    }
}
