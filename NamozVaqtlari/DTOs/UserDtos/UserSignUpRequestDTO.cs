using NamozVaqtlari.Model.Users;
using NamozVaqtlari.Validation;
using System.ComponentModel.DataAnnotations;

namespace NamozVaqtlari.DTOs.UserDtos
{
    public class UserSignUpRequestDTO
    {

        [Required, UzbekistanPhoneNumber(ErrorMessage = "Telefon raqami noto'g'ri.")]
        public string? PhoneNumber { get; set; }

        [Required , PasswordValidation(ErrorMessage = "Password noto'g'ri.")]
        public string? Password { get; set; }
    }
}
