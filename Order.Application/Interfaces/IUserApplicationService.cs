using Order.Application.DataContract.Request.User;
using Order.Application.DataContract.Response.User;
using Order.Domain.Entities;
using Order.Domain.Validations.Base;

namespace Order.Application.Interfaces.Services
{
    public interface IUserApplicationService
    {
        Task<UserResponse> CadastrarUsuario(UserRequest request);
        Task<UserResponse> AlterarUsuario(UserRequest request);
        Task DeletarUsuario(Guid userCode);
        Task<UserResponse> GetUsuarioByCode(Guid userCode);
    }
}