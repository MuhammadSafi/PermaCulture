using System;
using System.Collections.Generic;

namespace PermaCulture.Api.Models
{
    public partial class Content
    {
        public Content()
        {
            ContentVariation = new HashSet<ContentVariation>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Header { get; set; }
        public string Content1 { get; set; }
        public int CategoryId { get; set; }
        public string Footer { get; set; }
        public int Order { get; set; }

        public Category Category { get; set; }
        public ICollection<ContentVariation> ContentVariation { get; set; }
    }
}
