using Dapper;
using Dapper.Contrib.Extensions;
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
            const string sql = @"INSERT INTO dbo.[User]
                                     (Code, 
                                      Name, 
                                      Email, 
                                      Password, 
                                      Gender, 
                                      BirthDate, 
                                      CreateAt, 
                                      Situation)
                                 VALUES
                                     (@p0,
                                      @p1,
                                      @p2,
                                      @p3,
                                      @p4,
                                      @p5,
                                      @p6,
                                      @p7";


            await _dbConnector.DbConnection.ExecuteAsync(sql, new
            {
                @p0 = new Guid(),
                @p1 = user.Name,
                @p2 = user.Email,
                @p3 = user.Password,
                @p4 = user.Gender,
                @p5 = user.BirthDate,
                @p6 = user.CreateAt,
                @p7 = user.Situation
            });
        }

        public void Update(User user)
        {
            _dbConnector.DbConnection.Update(user);
        }
    }
}