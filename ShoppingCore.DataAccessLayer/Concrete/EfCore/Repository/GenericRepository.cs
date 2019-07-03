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
            return entities.Find(id);
        }

        public IQueryable<T> GetAll()
        {
            try
            {
                return entities;
            }
            catch (Exception e)
            {

                throw new Exception(e.Message);
            }
           
        }

        public List<T> GetAll(System.Linq.Expressions.Expression<Func<T, bool>> expression)
        {
            return entities.Where(expression).ToList();
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
