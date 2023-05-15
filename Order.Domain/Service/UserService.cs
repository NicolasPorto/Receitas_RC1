using Order.Domain.Entities;
using Order.Domain.Interfaces.Repositories;
using Order.Domain.Interfaces.Services;

namespace Order.Domain.Service
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _userRepository;

        public UserService(IUserRepository userRepository) 
        {
            _userRepository = userRepository;
        }

        public Task CadastrarUsuario(User user)
        {

        }

        public Task AlterarUsuario(User user)
        {

        }

        public Task DeletarUsuario(Guid userCode)
        {

        }

        public Task<User> GetUsuarioByCode(Guid userCode)
        {

        }
    }
}