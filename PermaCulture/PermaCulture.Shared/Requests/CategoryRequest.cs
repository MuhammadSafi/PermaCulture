using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;


namespace PermaCulture.Shared.Requests
{
    public class CategoryRequest
    {
        [Required]
        public string Name { get; set; }
        public int PrentId { get; set; }
        public string ParentName { get; set; }
    }
}
