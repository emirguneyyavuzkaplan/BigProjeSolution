using BigProje.DAL.Abstract;
using BigProje.DAL.Contexts;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BigProje.DAL.Concrete
{
    public class RepoBase<T> : IRepoBase<T> where T : class, new()
    {
        protected SqlDbContext db;
        public RepoBase()
        {
            db = new SqlDbContext();
        }
        public virtual int Add(T input)
        {
            db.Set<T>().Add(input);
            return db.SaveChanges();
        }

        public virtual int Delete(T input)
        {
            db.Set<T>().Remove(input);
            return db.SaveChanges();
        }

        public virtual T Find(int id)
        {
            return db.Set<T>().Find(id);
        }

        public virtual IList<T> GetAll(Expression<Func<T, bool>> filter = null)
        {
            if (filter == null)
            {
                return db.Set<T>().ToList();
            }
            else
            {
                return db.Set<T>().Where(filter).ToList();
            }
        }

        public virtual IQueryable<T> GetAllInclude(Expression<Func<T,
                                                   bool>> filter = null,
                                                   params Expression<Func<T, object>>[] include)
        {
            var query = db.Set<T>().Where(filter);
            return include.Aggregate(query, (current, includeProperty) => current.Include(includeProperty));
        }

        public virtual int Update(T input)
        {
            db.Set<T>().Update(input);
            return db.SaveChanges();
        }
    }
}
