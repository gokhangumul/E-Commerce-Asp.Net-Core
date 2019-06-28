using ShoppingCore.BusinessLayer.Abstract;
using ShoppingCore.DataAccessLayer.Abstract;
using ShoppingCore.EntityLayer.DbModels;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace ShoppingCore.BusinessLayer.Concrete
{
    public class GenericManager<T> : IServices<T> where T : class
    {
        private IGenericRepository<T> genericRepository;
        public GenericManager(IGenericRepository<T> genericRepository)
        {
            this.genericRepository = genericRepository;
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
            return genericRepository.GetAll();
        }

        public List<T> GetAll(Expression<Func<T, bool>> expression)
        {
            throw new NotImplementedException();
        }

        public void Save()
        {
             genericRepository.Save();
        }

        public T Update(T entity)
        {
            throw new NotImplementedException();
        }
    }
}
