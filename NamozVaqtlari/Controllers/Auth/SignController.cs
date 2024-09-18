using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using NamozVaqtlari.DTOs.UserDtos;
using NamozVaqtlari.Model.Users;
using NamozVaqtlari.Profilies;
using NamozVaqtlari.Services.AuthService;

namespace NamozVaqtlari.Controllers.Auth
{
    public class SignController:ControllerBase
    {
        private readonly IMapper _mapper;
        private readonly IUserAuthService _userAuthService;

        public SignController(IMapper mapper , IUserAuthService userAuthService) 
        {
            _userAuthService = userAuthService;
            _mapper = mapper;
        }

        [HttpPost("salom")]
        public IActionResult UserSignUp(UserSignUpRequestDTO userSignUpDto)
        {
            User user = _mapper.Map<User>(userSignUpDto);
            user.Id = new Guid();
            _userAuthService.SignUpAsync(user);
            return Ok(_mapper.Map<UserSignUpResponseDTO>(user));
        }


    }
}
