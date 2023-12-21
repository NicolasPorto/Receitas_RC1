using AutoMapper;
using Order.Application.DataContract.Request.User;
using Order.Application.DataContract.Response.User;
using Order.Application.Interfaces.Services;
using Order.Domain.Entities;
using Order.Domain.Interfaces.Repositories;
using Order.Domain.Validations;
using Order.Domain.Validations.Base;
using Order.Infra.Exceptions;

namespace Order.Application.ApplicationServices
{
    public class UserService : IUserApplicationService
    {
        private readonly IUserRepository _userRepository;
        private readonly IMapper _mapper;

        public UserService(IUserRepository userRepository, IMapper mapper) 
        {
            _userRepository = userRepository;
            _mapper = mapper;
        }

        public async Task<UserResponse> CreateUser(UserRequest request)
        {
            var userRequest = _mapper.Map<User>(request);

            var validation = new UserValidation();
            var errors = validation.Validate(userRequest).GetErrors();

            if (errors.Report.Count > 0)
                throw new RCException(errors.Report.First().Message);  

            await _userRepository.Insert(userRequest);

            return _mapper.Map<UserResponse>(userRequest);
        }

        public async Task<UserResponse> UpdateUser(UserRequest request)
        {
            var userRequest = _mapper.Map<User>(request);

            var validation = new UserValidation();
            var errors = validation.Validate(userRequest).GetErrors();

            if (errors.Report.Count > 0)
                throw new RCException(errors.Report.First().Message);

            var exists = await _userRepository.ExistById(userRequest.Codigo);

            if(!exists)
                throw new RCException("User not found.");

            await _userRepository.Update(userRequest);

            return _mapper.Map<UserResponse>(userRequest);
        }

        public async Task DeleteUser(Guid userCode)
        {
            await _userRepository.Delete(userCode);
        }

        public async Task<UserResponse> GetUserByCode(Guid userCode)
        {
            var user = await _userRepository.GetById(userCode);

            return _mapper.Map<UserResponse>(user);
        }
    }     
}