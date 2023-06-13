using Order.Domain.Entities;
using Order.Domain.Interfaces.Repositories;
using System.Data;

namespace Order.Infra.Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly IDbConnection _dbConnection;

        public UserRepository(IDbConnection dbConnection) 
        {
            _dbConnection = dbConnection;
        }

        public Task Delete(Guid userCode)
        {
            throw new NotImplementedException();
        }

        public Task<bool> ExistById(Guid userCode)
        {
            throw new NotImplementedException();
        }

        public Task<User> GetById(Guid userCode)
        {
            throw new NotImplementedException();
        }

        public Task Insert(User user)
        {
            throw new NotImplementedException();
        }

        public Task Update(User user)
        {
            throw new NotImplementedException();
        }
    }
}