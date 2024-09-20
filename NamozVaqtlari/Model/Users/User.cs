using NamozVaqtlari.Validation;
using System.ComponentModel.DataAnnotations;

namespace NamozVaqtlari.Model.Users
{
    public class User
    {
        [Key]
        public Guid Id { get; set; }
        [EmailAddress]
        public string? Email { get; set; }
        [UzbekistanPhoneNumber , Required]
        public string? PhoneNumber { get; set; }

        [Required , PasswordValidation]
        public string? Password { get; set; }

        public bool IsActived { get; set; } = false;

        [Length(4 , 4)]
        public int SmsCode { get; set; }

        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

        public string? Token { get; set; }

        public List<UserRole>? Role { get; set; } = new List<UserRole>() { UserRole.User};
    }
}