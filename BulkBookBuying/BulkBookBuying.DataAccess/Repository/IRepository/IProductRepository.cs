﻿using System;
using System.Collections.Generic;
using System.Text;
using BulkBookBuying.Models;

namespace BulkBookBuying.DataAccess.Repository.IRepository
{
    public interface IProductRepository : IRepository<Product>
    {
        void Update(Product product);
    }
}