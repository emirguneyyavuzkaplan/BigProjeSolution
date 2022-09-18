using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BigProje.BL.Abstract
{
    public interface IManaBase<T> where T : class, new()
    {
        int Add(T input);
        int Delete(T input);
        int Update(T input);
        T Find(int id);
        IList<T> GetAll(Expression<Func<T, bool>> filter = null);
        IQueryable<T> GetAllInclude(Expression<Func<T, bool>> filter = null,
                                    params Expression<Func<T, object>>[] include);
    }
}
