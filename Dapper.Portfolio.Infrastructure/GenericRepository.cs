using Dapper.Portfolio.Domain.Repository;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dapper.Portfolio.Infrastructure
{
    public class GenericRepository<T> : IGenericRepository<T> where T : class
    {
        private readonly string _connectionString = "Server=DESKTOP-NMRQQJ1\\SQLEXPRESS;initial catalog = DbPortfolio; integrated Security=true";
        public async Task DeleteAsync(string command)
        {
            await using var connection = new SqlConnection(_connectionString);
            await connection.ExecuteAsync(command);
        }

        public async Task<T> GetAsync(string command)
        {
            await using var connection = new SqlConnection(_connectionString);
            return await connection.QueryFirstAsync<T>(command);
        }

        public async Task<List<T>> GetListAsync(string command)
        {
            await using var connection = new SqlConnection(_connectionString);

            return (await connection.QueryAsync<T>(command))
                .AsList();
        }

        public async Task InsertAsync(string command)
        {
            await using var connection = new SqlConnection(_connectionString);
            await connection.ExecuteAsync(command);
        }

        public async Task UpdateAsync(string command)
        {
            await using var connection = new SqlConnection(_connectionString);
            await connection.ExecuteAsync(command);
        }
    }
}
