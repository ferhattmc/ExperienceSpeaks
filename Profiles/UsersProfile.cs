using AutoMapper;
using ExperienceSpeaks.Dtos;
using ExperienceSpeaks.Models;

namespace ExperienceSpeaks.Profiles
{
    public class UsersProfile : Profile
    {
        public UsersProfile()
        {
            //Source -> Target
            CreateMap<User, UserReadDto>();
            CreateMap<UserCreateDto, User>();
            CreateMap<UserUpdateDto, User>();
            CreateMap<User, UserUpdateDto>();
        }
    }
}