using System;
using System.Collections.Generic;
using System.Text;
using BulkBookBuying.Models;
using BulkBookBuying.Models.Models;

namespace BulkBookBuying.DataAccess.Repository.IRepository
{
    public interface IOrderHeaderRepository : IRepository<OrderHeader>
    {
        void Update(OrderHeader orderHeader);
    }
}
