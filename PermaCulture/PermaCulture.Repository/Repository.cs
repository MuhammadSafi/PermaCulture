using Microsoft.EntityFrameworkCore;
using PermaCulture.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PermaCulture.Repository
{
    public abstract class Repository<T> where T : Entity
    {
        protected readonly PermaCultureContext _context;
        protected readonly DbSet<T> _dbSet;

        protected Repository(PermaCultureContext context)
        {
            _context = context;
            _dbSet = context.Set<T>();
        }


        public async Task<bool> ExistsAsync(int id) => await _dbSet.AnyAsync(e => e.Id == id);


        public virtual async Task DeleteAsync(int id, bool saveChanges = true)
        {
            var entity = await _dbSet.FindAsync(id);
            _context.Remove(entity);

            if (saveChanges)
            {
                await _context.SaveChangesAsync();
            }
        }


        public virtual async Task DeleteRangeAsync(IEnumerable<int> Ids, bool saveChanges = true)
        {
            var Entities = _dbSet.Where(a => Ids.Contains(a.Id));
            _context.RemoveRange(Entities);

            if (saveChanges)
            {
                await _context.SaveChangesAsync();
            }
        }


        protected virtual async Task<T> GetAsync(int id) => await _dbSet.FindAsync(id);


        protected virtual IEnumerable<T> Get(IEnumerable<int> ids) => _dbSet.Where(e => ids.Contains(e.Id)).AsEnumerable();


        protected virtual async Task SaveChangesAsync() => await _context.SaveChangesAsync();


        protected virtual async Task<long> InsertAsync(T entity, int userId, bool saveChanges = true)
        {
            entity.CreatedBy = userId;
            await _dbSet.AddAsync(entity);

            if (saveChanges)
            {
                await _context.SaveChangesAsync();
            }

            return entity.Id;
        }


        protected virtual async Task InsertAsync(IEnumerable<T> entities, int userId, bool saveChanges = true)
        {
            foreach (var item in entities)
            {
                item.CreatedBy = userId;
            }

            await _dbSet.AddRangeAsync(entities);

            if (saveChanges)
            {
                await _context.SaveChangesAsync();
            }
        }


        protected virtual async Task UpdateAsync(T entity, int userId, bool saveChanges = true)
        {
            entity.UpdatedBy = userId;
            entity.UpdatedOn = DateTime.UtcNow;

            _dbSet.Update(entity);

            if (saveChanges)
            {
                await _context.SaveChangesAsync();
            }
        }


        protected virtual async Task UpdateAsync(IEnumerable<T> entities, int userId, bool saveChanges = true)
        {
            var now = DateTime.UtcNow;

            foreach (var item in entities)
            {
                item.UpdatedBy = userId;
                item.UpdatedOn = now;
            }

            _dbSet.UpdateRange(entities);

            if (saveChanges)
            {
                await _context.SaveChangesAsync();
            }
        }


        protected virtual async Task DeleteAsync(T entity, bool saveChanges = true)
        {
            _context.Remove(entity);

            if (saveChanges)
            {
                await _context.SaveChangesAsync();
            }
        }


        protected virtual async Task DeleteRangeAsync(IEnumerable<T> entities, bool saveChanges = true)
        {
            _dbSet.RemoveRange(entities);

            if (saveChanges)
            {
                await SaveChangesAsync();
            }
        }




    }

}

