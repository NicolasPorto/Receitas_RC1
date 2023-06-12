using System.Data;

namespace Order.Domain.Interfaces.DataConnector
{
    public interface IDbConnector : IDisposable
    {
        IDbConnection dbConnection { get; set; }
        IDbTransaction transaction { get; set; }
    }
}