using BigProje.BL.Abstract;
using BigProje.DAL.Abstract;
using BigProje.DAL.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BigProje.BL.Concerete
{
    public class ManaBase<T> : IManaBase<T> where T : class, new()
    {
        protected IRepoBase<T> repo;
        public ManaBase()
        {
            repo = new RepoBase<T>();
        }
        public virtual int Add(T input)
        {
            return repo.Add(input);
        }

        public virtual int Delete(T input)
        {
            return repo.Delete(input);
        }

        public virtual T Find(int id)
        {
            return repo.Find(id);
        }

        public virtual IList<T> GetAll(System.Linq.Expressions.Expression<Func<T, bool>> filter = null)
        {
            return repo.GetAll(null);
        }

        public virtual IQueryable<T> GetAllInclude(System.Linq.Expressions.Expression<Func<T, bool>> filter = null, params System.Linq.Expressions.Expression<Func<T, object>>[] include)
        {
            return repo.GetAllInclude(filter, include);
        }

        public virtual int Update(T input)
        {
            return repo.Update(input);
        }
    }
}
