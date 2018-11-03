using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace PermaCulture.Repository
{
    public interface IExist
    {
        /// <summary>
        /// Checks if a record with that ID exists
        /// </summary>
        /// <param name="id">Identifier.</param>
        /// <returns>Boolean value indicating whether the record exists</returns>
        Task<bool> ExistsAsync(int id);
    }
}
