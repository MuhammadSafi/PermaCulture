using PermaCulture.Repository;
using PermaCulture.Shared;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace PermaCulture.Context
{
    public interface ICategoryContext
    {
        Task<ApiResponse<IEnumerable<PermaCulture.Entities.Category>>> GetCategories();
    }
    public class CategoryContext : ICategoryContext
    {
        private readonly ICategoryRepository _categoryRepository;

        public CategoryContext(ICategoryRepository categoryRepository)
        {

            _categoryRepository = categoryRepository;


        }
        public async Task<ApiResponse<IEnumerable<PermaCulture.Entities.Category>>> GetCategories()
        {
            var result = await _categoryRepository.GetCategoryAsync(0, 0, 0);
            return new ApiResponse<IEnumerable<PermaCulture.Entities.Category>>(result.Items, 0, 0, result.Total);
            //return ret;
        }
    }
}
