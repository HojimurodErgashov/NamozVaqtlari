using Microsoft.EntityFrameworkCore;
using NamozVaqtlari.Model.Users;
using NamozVaqtlari.Repositoreis;

namespace NamozVaqtlari.Services.AuthService
{
    public class UserAuthService : IUserAuthService
    {
        private readonly IGenericRepository<User> _repository;
        public UserAuthService(IGenericRepository<User> repository)
        {
            _repository = repository;
        }

        public async Task<User> SignUpAsync(User? user)   
        {
            if (user == null && null != (await _repository.GetAll().FirstOrDefaultAsync(u => u.PhoneNumber == user.PhoneNumber))) { 
                throw new ArgumentNullException("Bu tefeon raqamli foydalanuvchi mavjud " + nameof(user));
            }
            return await _repository.AddAsync(user);
        }
    }
}
