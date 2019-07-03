using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace ShoppingCore.DataAccessLayer.Abstract
{
    public interface IGenericRepository<T> where T:class
    {
        T Add(T entity);
        T Get(int id);
        IQueryable<T> GetAll();
        List<T> GetAll(Expression<Func<T, bool>> expression);
        bool Delete(int id);
        bool Delete(T entity);
        T Update(T entity);
        void Save();
    }
}
