using PermaCulture.Repository;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace PermaCulture.Context
{
    public interface ICategoryContext
    {
        Task<List<PermaCulture.Entities.Category>> GetCategories();
    }
    public class CategoryContext   : ICategoryContext 
    {
        private readonly ICategoryRepository _categoryRepository;

        public CategoryContext(ICategoryRepository categoryRepository) {

            _categoryRepository = categoryRepository;


        }
        public async Task<List<PermaCulture.Entities.Category>> GetCategories()
        {
            var ret =await _categoryRepository.GetCategoryAsync(0, 0, 0);
            return ret;
        }
    }
}
