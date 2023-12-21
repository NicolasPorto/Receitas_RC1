using Order.Application.DataContract.Request.User;
using Order.Application.DataContract.Response.User;

namespace Order.Application.Interfaces.Services
{
    public interface IUserApplicationService
    {
        Task<UserResponse> CreateUser(UserRequest request);
        Task<UserResponse> UpdateUser(UserRequest request);
        Task DeleteUser(Guid userCode);
        Task<UserResponse> GetUserByCode(Guid userCode);
    }
}