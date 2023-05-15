using Order.Domain.Entities;

namespace Order.Domain.Interfaces.Services
{
    public interface IUserService
    {
        Task CadastrarUsuario(User user);
        Task AlterarUsuario(User user);
        Task DeletarUsuario(Guid userCode);
        Task<User> GetUsuarioByCode(Guid userCode);
    }
}