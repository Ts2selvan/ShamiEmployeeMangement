using System.ComponentModel.DataAnnotations;

namespace ShamiEmployeeMangement.Models.DTO
{
    public class SignupDTO
    {
        [Required(ErrorMessage = "UserName is Required")]
        public string Username { get; set; } = null!;
        [Required(ErrorMessage = "Password is required")]
        [StringLength(100, ErrorMessage = "Password length must be 6", MinimumLength = 6)]
        public string? Password { get; set; }
        [Required(ErrorMessage = "ConfirmPassword is required")]
        [Compare("Password", ErrorMessage = "Password does not match")]
        public string? Confirmpassword { get; set; }
    }
}
