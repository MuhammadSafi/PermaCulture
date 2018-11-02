using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PermaCulture.Entities;
using PermaCulture.Shared;
using Microsoft.EntityFrameworkCore;

namespace PermaCulture.Repository
{
    public interface ICategoryRepository
    {
       Task <List<Category>> GetCategoryAsync(int categoryId, int limit, int offset);
    }
    public class CategoryRepository : DefaultRepository<Category>, ICategoryRepository
    {
        public CategoryRepository(PermaCultureContext context) : base(context)
        {
           // _entityType = EntityType.Artist;
        }
        //public async Task<IEnumerable<Category>> GetCategoryAsync() => await _dbSet.OrderBy(a => a.Name).Select(a => ArtistDtoBuilder.BuildBasic(a)).ToArrayAsync();

        public  async Task<List<Category>> GetCategoryAsync(int categoryId, int limit, int offset)
        {
            var aa =  await _dbSet.OrderBy(a => a.Name).ToListAsync();
            return aa;
        }
    }
}
