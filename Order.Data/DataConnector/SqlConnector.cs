using Order.Domain.Interfaces.DataConnector;
using System.Data;
using System.Data.SqlClient;

namespace Order.Infra.DataConnector
{
    public class SqlConnector : IDbConnector
    {
        public SqlConnector(string connectionString) 
        {
            DbConnection = SqlClientFactory.Instance.CreateConnection();
            DbConnection.ConnectionString = connectionString;
        }

        public IDbConnection DbConnection { get; }
        public IDbTransaction DbTransaction { get; set; }

        public void Dispose()
        {
            DbConnection?.Dispose();
            DbTransaction?.Dispose();
        }
    }
}