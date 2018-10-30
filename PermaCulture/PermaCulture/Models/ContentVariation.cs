using System;
using System.Collections.Generic;

namespace PermaCulture.Api.Models
{
    public partial class ContentVariation
    {
        public int Id { get; set; }
        public int ContentId { get; set; }
        public int Price { get; set; }

        public Content Content { get; set; }
    }
}
