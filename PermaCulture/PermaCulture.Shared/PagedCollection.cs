using System.Collections.Generic;
using System.Linq;

namespace PermaCulture.Shared
{
	public class PagedCollection<T>
	{
		public PagedCollection()
		{
		}

		public PagedCollection(int total, IQueryable<T> items)
		{
			Total = total;
			Items = items;
		}

		public PagedCollection(int total, IEnumerable<T> items)
		{
			Total = total;
			Items = items;
		}

		public static PagedCollection<T> Empty { get { return new PagedCollection<T>(0, Enumerable.Empty<T>()); } }

		public int Total { get; }

		public IEnumerable<T> Items { get; }
	}
}
