using AutoMapper;
using NamozVaqtlari.DTOs.UserDtos;
using NamozVaqtlari.Model.Users;

namespace NamozVaqtlari.Profilies
{
    public class UserProfile:Profile
    {
        public UserProfile() 
        {
            CreateMap<UserSignUpRequestDTO, User>();/*
                .ForMember(dest => dest.Id, opt => opt.Ignore())          // Ignoring Id
                .ForMember(dest => dest.Email, opt => opt.Ignore())       // Ignoring Email
                .ForMember(dest => dest.IsActived, opt => opt.Ignore())   // Ignoring IsActived
                .ForMember(dest => dest.SmsCode, opt => opt.Ignore())     // Ignoring SmsCode
                .ForMember(dest => dest.Token, opt => opt.Ignore())       // Ignoring Token
                .ForMember(dest => dest.Role, opt => opt.Ignore());*/
            CreateMap<User, UserSignUpResponseDTO>();
        }

    }
}
