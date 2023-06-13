using System.Data;

namespace Order.Domain.Interfaces.DataConnector
{
    public interface IDbConnector : IDisposable
    {
        IDbConnection DbConnection { get; }
        IDbTransaction DbTransaction { get; set; }
    }
}