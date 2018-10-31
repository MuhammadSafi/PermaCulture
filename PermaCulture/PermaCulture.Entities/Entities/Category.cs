using System;
using System.Collections.Generic;

namespace PermaCulture.Entities
{
    public partial class Category: Entity
    {
        public Category()
        {
            Content = new HashSet<Content>();
        }

        //public int Id { get; set; }
        public string Name { get; set; }
        public int ParentId { get; set; }
        //public int? CreatedBy { get; set; }
        //public DateTime? CreatedOn { get; set; }
        //public int? UpdatedBy { get; set; }
        //public DateTime? UpdatedOn { get; set; }

        public ICollection<Content> Content { get; set; }
    }
}
