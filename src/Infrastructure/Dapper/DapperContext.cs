using Application.Common.Interfaces;
using Microsoft.Data.SqlClient;
using System.Data;

namespace Infrastructure.Dapper
{
    public class DapperContext : IDapperContext
    {
        private readonly string _connectionString;

        public DapperContext(string connectionString)
        {
            _connectionString = connectionString;
        }

        public IDbConnection CreateConnection()
            => new SqlConnection(_connectionString);
    }
}
