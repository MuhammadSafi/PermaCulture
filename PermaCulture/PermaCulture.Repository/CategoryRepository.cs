using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PermaCulture.Entities;
using PermaCulture.Shared;
using Microsoft.EntityFrameworkCore;
using PermaCulture.Shared.Extensions;
using PermaCulture.Model;
using PermaCulture.Shared.Requests;

namespace PermaCulture.Repository
{
    public interface ICategoryRepository : IExist, IDeletable
    {
        Task<PagedCollection<Category>> GetCategoryAsync(int categoryId, int limit, int offset);
        Task<CategoryDto> CreateCategoryAsync(CategoryRequest request, int userId);
    }
    public class CategoryRepository : DefaultRepository<Category>, ICategoryRepository
    {
        public CategoryRepository(PermaCultureContext context) : base(context)
        {
            // _entityType = EntityType.Artist;
        }

        public async Task<CategoryDto> CreateCategoryAsync(CategoryRequest request, int userId)
        {
            var obj = new Category
            {
                Name = request.Name,
                ParentId = request.PrentId
            };
            await InsertAsync(obj, userId);
            return new CategoryDto ();
        }

        //public async Task<IEnumerable<Category>> GetCategoryAsync() => await _dbSet.OrderBy(a => a.Name).Select(a => ArtistDtoBuilder.BuildBasic(a)).ToArrayAsync();

        public async Task<PagedCollection<Category>> GetCategoryAsync(int categoryId, int limit, int offset)
        {
            var total = await _dbSet.CountAsync();
            var aa = _dbSet.OrderBy(a => a.Name).ToPagedCollection(total);
            return aa;
        }
    }
}
