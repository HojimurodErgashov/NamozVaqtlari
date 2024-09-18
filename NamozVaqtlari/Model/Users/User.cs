using System.ComponentModel.DataAnnotations;

namespace NamozVaqtlari.Model.Users
{
    public class User
    {
        [Key]
        public Guid Id { get; set; }
        [EmailAddress]
        public string? Email { get; set; }
        [Length(9 , 9) , Required]
        public string? PhoneNumber { get; set; }
        [Length (10 , 10) , Required]
        public string? Password { get; set; }
        public bool IsActived { get; set; } = false;
        [Length(4 , 4)]
        public int SmsCode { get; set; }
        public string? Token { get; set; }
        public List<UserRole>? Role { get; set; } = new List<UserRole>() { UserRole.User};
    }
}