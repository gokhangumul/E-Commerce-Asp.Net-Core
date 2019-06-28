using Microsoft.EntityFrameworkCore;
using ShoppingCore.DataAccessLayer.Abstract;
using ShoppingCore.DataAccessLayer.Concrete.EfCore.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ShoppingCore.DataAccessLayer.Concrete.EfCore.Repository
{
    public class GenericRepository<T> : IGenericRepository<T> where T : class
    {
        public readonly ShopContext shopContext;
        private DbSet<T> entities;
        public GenericRepository(ShopContext shop)
        {
            this.shopContext = shop;
            entities = shop.Set<T>();
        }
        public T Add(T entity)
        {
            throw new NotImplementedException();
        }

        public bool Delete(int id)
        {
            throw new NotImplementedException();
        }

        public bool Delete(T entity)
        {
            throw new NotImplementedException();
        }

        public T Get(int id)
        {
            throw new NotImplementedException();
        }

        public List<T> GetAll()
        {
            return entities.ToList();
        }

        public List<T> GetAll(System.Linq.Expressions.Expression<Func<T, bool>> expression)
        {
            throw new NotImplementedException();
        }

        public void Save()
        {
            shopContext.SaveChanges();
        }

        public T Update(T entity)
        {
            throw new NotImplementedException();
        }
    }
}
