using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PermaCulture.Shared.Extensions
{
    public static class LinqExtensions
    {
        public static PagedCollection<T> ToPagedCollection<T>(this IQueryable<T> source, int total)
        {
            var collection = new PagedCollection<T>(total, source);
            return collection;
        }

        public static PagedCollection<T> ToPagedCollection<T>(this IEnumerable<T> source, int total)
        {
            var collection = new PagedCollection<T>(total, source);
            return collection;
        }


    }
}
