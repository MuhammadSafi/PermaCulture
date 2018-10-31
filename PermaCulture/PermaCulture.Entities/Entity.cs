using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace PermaCulture.Entities
{

    public interface IEntity
    {
        long Id { get; set; }
    }

    public abstract class Entity : IEntity
    {
        public Entity()
        {
            CreatedOn = DateTime.UtcNow;
        }

        [Key]
        public long Id { get; set; }

        ////public virtual User CreatedBy { get; set; }
        public virtual long? CreatedBy { get; set; }

        public virtual DateTime CreatedOn { get; set; }

        ////public virtual User UpdatedBy { get; set; }
        public virtual long? UpdatedBy { get; set; }

        public virtual DateTime? UpdatedOn { get; set; }
    }
}
