using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using BulkBookBuying.DataAccess.Data;
using BulkBookBuying.DataAccess.Repository.IRepository;
using Microsoft.EntityFrameworkCore;

namespace BulkBookBuying.DataAccess.Repository
{
    public class Repository<T> : IRepository<T> where T : class
    {
        //this object will be modifying the databse
        private readonly ApplicationDbContext _db;
        internal DbSet<T> dbSet;

        public Repository(ApplicationDbContext db)
        {
            _db = db;
            this.dbSet = _db.Set<T>();

        }

        public void Add(T entity)
        {
            dbSet.Add(entity);
        }

        public T Get(int id)
        {
            return dbSet.Find();
        }

        public IEnumerable<T> GetAll(Expression<Func<T, bool>> filter = null, Func<IQueryable<T>, IOrderedQueryable<T>> orderby = null, string includeProperties = null)
        {
            IQueryable<T> query = dbSet;

            if (filter != null)
                query = query.Where(filter);

            if(includeProperties != null)
                foreach (var includeProp in includeProperties.Split(new char[]{','}, StringSplitOptions.RemoveEmptyEntries))
                {
                    query = query.Include(includeProp);
                }

            if (orderby != null)
            {
                return orderby(query).ToList();
            }

            return query.ToList();
        }

        public IEnumerable<T> GetFirstOrDefault(Expression<Func<T, bool>> filter = null, string includeProperties = null)
        { IQueryable<T> query = dbSet;

            if (filter != null)
                query = query.Where(filter);

            if(includeProperties != null)
                foreach (var includeProp in includeProperties.Split(new char[]{','}, StringSplitOptions.RemoveEmptyEntries))
                {
                    query = query.Include(includeProp);
                }

            yield return query.FirstOrDefault();
        }

        public void Remove(int id)
        {
            T entity = dbSet.Find(id);
        }

        public void Remove(T entity)
        {
            dbSet.Remove(entity);
        }

        public void RemoveRange(IEnumerable<T> entity)
        {
           dbSet.RemoveRange(entity);
        }
    }
}
