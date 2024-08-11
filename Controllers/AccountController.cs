using Microsoft.AspNetCore.Mvc;
using ShamiEmployeeMangement.Models.DTO;
using ShamiEmployeeMangement.Services.Interface;

namespace ShamiEmployeeMangement.Controllers
{
    public class AccountController : Controller
    {
        private readonly IAccountService _accountService;

        public AccountController(IAccountService accountService)
        {
            _accountService = accountService;
        }
        [HttpGet]
        public IActionResult Signup()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Signup(SignupDTO signupDTO)
        {
            if (ModelState.IsValid)
            {
                if (await _accountService.IsUsernameExists(signupDTO.Username))
                {
                    ModelState.AddModelError("Username", "Username already exists.");
                    return PartialView("_SignupPartial", signupDTO);
                }

                bool isSignupSuccess = await _accountService.RegisterUser(signupDTO);
                if (isSignupSuccess)
                {
                    return Json(new { success = true });
                }
            }
            return PartialView("_SignupPartial", signupDTO);
        }
    }
}
