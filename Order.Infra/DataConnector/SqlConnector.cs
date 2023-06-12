using Order.Domain.Interfaces.DataConnector;
using System.Data;

namespace Order.Infra.DataConnector
{
    public class SqlConnector : IDbConnector
    {
        public IDbConnection dbConnection { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public IDbTransaction transaction { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }
}