using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dapper.Portfolio.Domain.Repository
{
    public interface IGenericRepository<T> where T : class
    {
        Task<List<T>> GetListAsync(string command);

        Task<T> GetAsync(string command);

        Task InsertAsync(string command);

        Task UpdateAsync(string command);

        Task DeleteAsync(string command);
    }
}
