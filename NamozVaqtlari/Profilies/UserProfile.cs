using AutoMapper;
using NamozVaqtlari.DTOs.UserDtos;
using NamozVaqtlari.Model.Users;

namespace NamozVaqtlari.Profilies
{
    public class UserProfile:Profile
    {
        public UserProfile() 
        {
            CreateMap<User, UserSignUpRequestDTO>();
            CreateMap<UserSignUpResponseDTO, User>();
        }

    }
}
