using ShamiEmployeeMangement.Models.DTO;
using ShamiEmployeeMangement.Repositories.Interface;
using ShamiEmployeeMangement.Services.Interface;

namespace ShamiEmployeeMangement.Services
{
    public class AccountService:IAccountService
    {
        private readonly IUserRepository _userRepository;

        public AccountService(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public async Task<bool> RegisterUser(SignupDTO signupDTO)
        {
            if (await _userRepository.IsUsernameExists(signupDTO.Username))
            {
                return false;
            }

            return await _userRepository.SignupUser(signupDTO);
        }

        public async Task<bool> IsUsernameExists(string username)
        {
            return await _userRepository.IsUsernameExists(username);
        }
    }
}
