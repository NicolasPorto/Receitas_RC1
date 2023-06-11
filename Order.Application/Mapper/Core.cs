using AutoMapper;
using Order.Application.DataContract.Request.User;
using Order.Application.DataContract.Response.User;
using Order.Domain.Entities;

namespace Order.Application.Mapper
{
    public class Core : Profile
    {
        public Core() { ClientMap(); }

        private void ClientMap()
        {
            CreateMap<UserRequest, User>();
            CreateMap<User, UserResponse>();
        }
    }
}
