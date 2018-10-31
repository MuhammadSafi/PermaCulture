using PermaCulture.Repository;
using System;
using System.Collections.Generic;
using System.Text;

namespace PermaCulture.Context
{
    public interface ICategoryContext
    {
        List<PermaCulture.Entities.Category> GetCategories();
    }
    public class CategoryContext   : ICategoryContext 
    {
        private readonly CategoryRepository _categoryRepository;

        public CategoryContext(CategoryRepository categoryRepository) {

            _categoryRepository = categoryRepository;


        }
        public List<PermaCulture.Entities.Category> GetCategories()
        {
            var ret = _categoryRepository.GetCategoryAsync(0, 0, 0);
            return ret;
        }
    }
}
