using Microsoft.AspNetCore.Identity;
using NamozVaqtlari.Model.Users;
using System.Security.Claims;

namespace NamozVaqtlari.Services.AuthService
{
    public interface IUserAuthService
    {
        Task SignUpAsync(User user);
    }
}
