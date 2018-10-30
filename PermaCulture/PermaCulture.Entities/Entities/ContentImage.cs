using System;
using System.Collections.Generic;

namespace PermaCulture.Entities
{
    public partial class ContentImage
    {
        public int Id { get; set; }
        public int ContentId { get; set; }
        public string ImagesUrl { get; set; }
        public int Order { get; set; }
    }
}
