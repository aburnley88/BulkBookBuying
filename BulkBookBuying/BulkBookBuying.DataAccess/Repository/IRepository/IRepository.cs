using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
/*This interface can take any class object and will be used to perform most CRUD operations. It will not have save and update.
 Save method will be in the IUnitOfWork, which acts as a container and gateway for all the models*/

namespace BulkBookBuying.DataAccess.Repository.IRepository
{
    public interface IRepository<T> where T :class
    {
        //retrieve T based off Id column in db
        T Get(int id);

        //dynamic GetAll
        IEnumerable<T> GetAll(
            Expression<Func<T, bool>> filter = null,
            //The next line of code is in the case of orderby
            Func<IQueryable<T>, IOrderedQueryable<T>> orderby = null,
            //stored procs, foreign key references, etc
            string includeProperties = null
        );

        //GetFirstOrDefault is a more generic version of Get
        T GetFirstOrDefault(
            Expression<Func<T, bool>> filter = null,
            string includeProperties = null
        );

        void Add(T entity);
        void Remove(int id);
        void Remove(T entity);

        void RemoveRange(IEnumerable<T> entity);

    }
}
