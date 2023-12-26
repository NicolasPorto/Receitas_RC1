using Dapper;
using Order.Domain.Entities;
using Order.Domain.Interfaces.DataConnector;
using Order.Domain.Interfaces.Repositories;

namespace Order.Infra.Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly IDbConnector _dbConnector;

        public UserRepository(IDbConnector dbConnector) 
        {
            _dbConnector = dbConnector;
        }

        public async Task Delete(Guid userCode)
        {
            throw new NotImplementedException();
        }

        public async Task<bool> ExistById(Guid userCode)
        {
            throw new NotImplementedException();
        }

        public async Task<User> GetById(Guid userCode)
        {
            const string sql = @"DECLARE @code UNIQUEIDENTIFIER = @p0

                                SELECT *
                                FROM dbo.[User]
                                WHERE Code = @code";

            return await _dbConnector.DbConnection.QueryFirstOrDefaultAsync<User>(sql, new { @p0 = userCode });
        }

        public async Task Insert(User user)
        {
            throw new NotImplementedException();
        }

        public async Task Update(User user)
        {
            throw new NotImplementedException();
        }
    }
}