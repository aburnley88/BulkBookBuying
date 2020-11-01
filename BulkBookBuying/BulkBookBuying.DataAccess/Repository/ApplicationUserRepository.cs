using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BulkBookBuying.DataAccess.Data;
using BulkBookBuying.DataAccess.Repository.IRepository;
using BulkBookBuying.Models;
using BulkyookBuying.Models;

namespace BulkBookBuying.DataAccess.Repository
{
    public class ApplicationUserRepository : Repository<ApplicationUser>, IApplicationUserRepository
    {
        private readonly ApplicationDbContext _db;

        public ApplicationUserRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }

    }
}
