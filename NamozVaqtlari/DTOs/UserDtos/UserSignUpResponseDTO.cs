using NamozVaqtlari.Model.Users;
using System.ComponentModel.DataAnnotations;

namespace NamozVaqtlari.DTOs.UserDtos
{
    public class UserSignUpResponseDTO
    {
        public Guid Id { get; set; }
        public string? Email { get; set; }
        public string? PhoneNumber { get; set; }
        public string? Password { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}
