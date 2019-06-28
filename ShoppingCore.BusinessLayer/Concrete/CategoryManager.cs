using ShoppingCore.BusinessLayer.Abstract;
using ShoppingCore.DataAccessLayer.Abstract;
using ShoppingCore.EntityLayer.DbModels;
using ShoppingCore.EntityLayer.PocoModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace ShoppingCore.BusinessLayer.Concrete
{
    public class CategoryManager : GenericManager<Category>, ICategoryServices
    {
        readonly ICategoryRepository categoryRepository;

        public CategoryManager(ICategoryRepository categoryRepository):base(categoryRepository)
        {
            this.categoryRepository = categoryRepository ?? throw new ArgumentNullException(nameof(categoryRepository));
        }

        public IEnumerable<PocoCategory> GetAllProductCount()
        {
            return categoryRepository.GetAllProductCount();
        }
    }
}

