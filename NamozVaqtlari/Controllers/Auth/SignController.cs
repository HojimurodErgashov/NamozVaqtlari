using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using NamozVaqtlari.DTOs.UserDtos;
using NamozVaqtlari.Model.Users;
using NamozVaqtlari.Profilies;

namespace NamozVaqtlari.Controllers.Auth
{
    public class SignController:ControllerBase
    {
        private readonly IMapper _mapper;

        public SignController(IMapper mapper) 
        {
            _mapper = mapper;
        }

        [HttpPost("salom")]
        public IActionResult UserSignUp(UserSignUpRequestDTO userSignUpDto)
        {
            User user = _mapper.Map<User>(userSignUpDto);
            user.Id = new Guid();
            return Ok(_mapper.Map<UserSignUpResponseDTO>(user));
        }


    }
}
