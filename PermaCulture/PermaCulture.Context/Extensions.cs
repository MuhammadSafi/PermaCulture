using PermaCulture.Entities;
using PermaCulture.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace PermaCulture.Context
{
    public static class Extensions
    {
        public static CategoryDto GetCategoryDto(this Category obj, string parentName)
        {
            return new CategoryDto
            {
                Name = obj.Name,
                ParentName = parentName
            };
        }
    }
}
