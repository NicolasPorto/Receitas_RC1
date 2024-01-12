using Order.Domain.Entities;

namespace Order.Domain.Interfaces.Repositories
{
    public interface IUserRepository
    {
        Task Insert(User user);
        void Update(User user);
        Task Delete(Guid userCode);
        Task<User> GetById(Guid userCode);
        Task<bool> ExistById(Guid userCode);
    }
}