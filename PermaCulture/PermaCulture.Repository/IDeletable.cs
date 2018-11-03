using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace PermaCulture.Repository
{
    public interface IDeletable
    {
        Task DeleteAsync(int id, bool saveChanges = true);
        Task DeleteRangeAsync(IEnumerable<int> Ids, bool saveChanges = true);
    }
}
