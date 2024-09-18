using NamozVaqtlari.Model.Users;
using System.ComponentModel.DataAnnotations;

namespace NamozVaqtlari.DTOs.UserDtos
{
    public class UserSignUpRequestDTO
    {

        [Length(9, 9), Required]
        public string? PhoneNumber { get; set; }
        [Length(10, 10), Required]
        public string? Password { get; set; }
    }
}
