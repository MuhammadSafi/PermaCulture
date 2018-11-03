using PermaCulture.Model;
using PermaCulture.Repository;
using PermaCulture.Shared;
using PermaCulture.Shared.Enums;
using PermaCulture.Shared.Requests;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace PermaCulture.Context
{
    public interface ICategoryContext
    {
        Task<ApiResponse<IEnumerable<PermaCulture.Entities.Category>>> GetCategories();
        Task<SuccessResponse> DeleteCategoryAsync(int categoryId);
        Task<ApiResponse<CategoryDto>> CreateArtistAsync(CategoryRequest request, int userId);
    }
    public class CategoryContext : ICategoryContext
    {
        private readonly ICategoryRepository _categoryRepository;


        public async Task<ApiResponse<CategoryDto>> CreateArtistAsync(CategoryRequest request, int userId)
        {
           // _logger.LogInformation("Admin with ID {id} creating an artist...", userId);

            try
            {
                var result = await _categoryRepository.CreateCategoryAsync(request, userId);
                return new ApiResponse<CategoryDto>(result, null, null, null, true);
            }

            catch (Exception ex)
            {
                //_logger.LogError(ex, "Exception caught while trying to create an artist.");
                return new ApiResponse<CategoryDto>(StatusCode.UnhandledException, ex);
            }
        }

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

        public async Task<SuccessResponse> DeleteCategoryAsync(int categoryId)
        {
            try
            {
                if (!await _categoryRepository.ExistsAsync(categoryId))
                {
                    return new SuccessResponse(new Error(StatusCode.ArtistNotFound));
                }

                await _categoryRepository.DeleteAsync(categoryId);
                return new SuccessResponse();
            }
            catch (Exception ex)
            {
                //_logger.LogError(ex, "Exception caught while trying to delete artist with ID {0}; user ID {1}", categoryId, "userId");
                return new SuccessResponse(StatusCode.UnhandledException, ex);
            }
        }
    }
}
