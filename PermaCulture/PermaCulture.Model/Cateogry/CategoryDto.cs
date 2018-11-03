using System;
using System.Collections.Generic;
using System.Text;

namespace PermaCulture.Model
{
    public class CategoryDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string ParentName { get; set; }
        public int ParentId { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? CreatedOn { get; set; }
        public int? UpdatedBy { get; set; }
        public DateTime? UpdatedOn { get; set; }
    }
}
