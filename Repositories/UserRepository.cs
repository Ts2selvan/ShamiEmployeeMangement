using Microsoft.EntityFrameworkCore;
using ShamiEmployeeMangement.Databaseconnectivity;
using ShamiEmployeeMangement.Models.DTO;
using ShamiEmployeeMangement.Models;
using ShamiEmployeeMangement.Repositories.Interface;

namespace ShamiEmployeeMangement.Repositories
{
    public class UserRepository:IUserRepository
    {
        private readonly EmployeeShamContext _context;
        public UserRepository(EmployeeShamContext context)
        {
            _context = context;
        }
        public async Task<bool> SignupUser(SignupDTO signupDTO)
        {
            var signup = new Signup
            {
                Username = signupDTO.Username,
                Password = signupDTO.Password,
                Confirmpassword=signupDTO.Confirmpassword
            };

            _context.Signups.Add(signup);
            return await _context.SaveChangesAsync() > 0;
        }

        public async Task<bool> IsUsernameExists(string username)
        {
            return await _context.Signups.AnyAsync(u => u.Username == username);
        }
    }
}
