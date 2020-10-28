using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BulkBookBuying.DataAccess.Data;
using BulkBookBuying.DataAccess.Repository.IRepository;
using BulkBookBuying.Models;
using BulkBookBuying.Models.Models;

namespace BulkBookBuying.DataAccess.Repository
{
    public class OrderDetailsRepository : Repository<OrderDetails>, IOrderDetailsRepository
    {
        private readonly ApplicationDbContext _db;
        public OrderDetailsRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }

        public void Update(OrderDetails orderDetails)
        {
           _db.Update(orderDetails);
        }
    }
}
