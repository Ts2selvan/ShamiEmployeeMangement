using ShamiEmployeeMangement.Models.DTO;

namespace ShamiEmployeeMangement.Repositories.Interface
{
    public interface IUserRepository
    {
        Task<bool> SignupUser(SignupDTO signupDTO);
        Task<bool> IsUsernameExists(string username);
    }
}
