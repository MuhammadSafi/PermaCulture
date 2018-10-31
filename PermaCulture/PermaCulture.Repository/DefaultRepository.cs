using Microsoft.EntityFrameworkCore;
using PermaCulture.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PermaCulture.Repository
{
    public abstract class DefaultRepository<T> : Repository<T> where T : Entity
    {
        protected readonly DbSet<Entity> _entities;

        protected DefaultRepository(PermaCultureContext context) : base(context)
        {
            _entities = context.Set<Entity>();
        }
    }
}
