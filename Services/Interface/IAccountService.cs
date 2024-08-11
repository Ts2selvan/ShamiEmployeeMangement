using ShamiEmployeeMangement.Models.DTO;

namespace ShamiEmployeeMangement.Services.Interface
{
    public interface IAccountService
    {
        Task<bool> RegisterUser(SignupDTO signupDTO);
        Task<bool> IsUsernameExists(string username);
    }
}
