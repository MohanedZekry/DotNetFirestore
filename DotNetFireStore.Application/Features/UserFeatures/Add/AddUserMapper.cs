using AutoMapper;
using DotNetFireStore.Domain.Entities;

namespace DotNetFireStore.Application.Features.UserFeatures.Add
{
    public sealed class AddUserMapper : Profile
    {
        public AddUserMapper()
        {
            CreateMap<AddUserRequest, User>();
            CreateMap<User, AddUserResponse>();
        }
    }
}
