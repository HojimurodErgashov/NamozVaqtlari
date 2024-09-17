namespace NamozVaqtlari.Model.Users
{
    public class User
    {
        public Guid Id { get; set; }
        public string? Email { get; set; }
        public string? PhoneNumber { get; set; }
        public string? Password { get; set; }
        public bool IsActived { get; set; }
        public int SmsCode { get; set; }
        public string? Token { get; set; }
        public List<UserRole>? Role { get; set; }
    }
}