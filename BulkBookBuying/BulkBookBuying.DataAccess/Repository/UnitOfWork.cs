﻿using System;
using System.Collections.Generic;
using System.Text;
using BulkBookBuying.DataAccess.Data;
using BulkBookBuying.DataAccess.Repository.IRepository;
using BulkBookBuying.Models;

namespace BulkBookBuying.DataAccess.Repository
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly ApplicationDbContext _db;

        public UnitOfWork(ApplicationDbContext db)
        {
            _db = db;
            Category = new CategoryRepository(_db);
            CoverType = new CoverTypeRepository(_db);
            //Company = new CompanyRepository(_db);
            //Product = new ProductRepository(_db);
            //ApplicationUser = new ApplicationUserRepository(_db);
            SP_Call = new SP_Call(_db);
         
        }

       // public IApplicationUserRepository ApplicationUser { get; private set; }
        public ICategoryRepository Category { get; private set; }
        //public ICompanyRepository Company { get; private set; }
        //public IProductRepository Product { get; private set; }
        public ICoverTypeRepository CoverType { get; private set; }
        //public IShoppingCartRepository ShoppingCart { get; private set; }
        //public IOrderDetailsRepository OrderDetails { get; private set; }
        public ISP_Call SP_Call { get; private set; }

        public void Dispose()
        {
            _db.Dispose();
        }

        public void Save()
        {
            _db.SaveChanges();
        }
    }
}
