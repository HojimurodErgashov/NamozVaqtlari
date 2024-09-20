using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using NamozVaqtlari.DTOs.UserDtos;
using NamozVaqtlari.Model.Users;
using NamozVaqtlari.Profilies;
using NamozVaqtlari.Services.AuthService;
using NamozVaqtlari.Services.SmsService;

namespace NamozVaqtlari.Controllers.Auth
{
    public class SignController:ControllerBase
    {
        private readonly IMapper _mapper;
        private readonly IUserAuthService _userAuthService;
        private readonly ISmsService _smsService;

        public SignController(IMapper mapper , IUserAuthService userAuthService , ISmsService smsService) 
        {
            _userAuthService = userAuthService;
            _mapper = mapper;
            _smsService = smsService;
        }

        [HttpPost("salom")]
        public async Task<IActionResult>  UserSignUp(UserSignUpRequestDTO userSignUpDto)
        {
            if (!ModelState.IsValid) 
            {

                // Validatsiya xatolarini to'plash
                var errors = ModelState.Values
                    .SelectMany(v => v.Errors)
                    .Select(e => e.ErrorMessage)
                    .ToList();

                // Xatolik haqida JSON javob yaratish
                var response = new
                {
                    Status = "Error",
                    Errors = errors,
                    SubmittedData = userSignUpDto // Foydalanuvchi yuborgan ma'lumotlar
                };

                // BadRequest() yordamida 400 status kodi qaytarish
                return BadRequest(response);

            }

            User user = _mapper.Map<User>(userSignUpDto);
            user.Id = new Guid();
            user.SmsCode = _smsService.GenerateSmsCode();
            await _userAuthService.SignUpAsync(user);
            return Ok(_mapper.Map<UserSignUpResponseDTO>(user));
        }


    }
}
