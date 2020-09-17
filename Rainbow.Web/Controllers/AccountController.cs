using Rainbow.Core.Models;
using Rainbow.Web.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace Rainbow.Web.Controllers
{
    [Authorize]
    public class AccountController : Controller
    {
        private readonly UserManager<User> _userManager;
        private readonly SignInManager<User> _signInManager;

        public AccountController(
            UserManager<User> userManager,
            SignInManager<User> signInManager)
        {
            _userManager = userManager;
            _signInManager = signInManager;
        }

        public async Task<IActionResult> Logoff()
        {
            await _signInManager.SignOutAsync();
            return Redirect("/Account/Login");
        }


        [Authorize(Policy = "Administrator")]
        public IActionResult Administrator()
        {
            return Redirect("/Administrator/Profile");
        }

        [AllowAnonymous]
        [HttpPost]
        public async Task<IActionResult> Login(LoginViewModel model)
        {
            model.ExternalProviders = await _signInManager.GetExternalAuthenticationSchemesAsync();

            if (!ModelState.IsValid)
                return View(model);

            var user = await _userManager.FindByNameAsync(model.Username);
            if (user == null)
            {
                ModelState.AddModelError("", "User not found");
                return View(model);
            }

            var result = await _signInManager.PasswordSignInAsync(user, model.Password, false, false);
            if (result.Succeeded)
                return Redirect(model.ReturnUrl);

            return View(model);
        }


        //[Authorize(Policy = "User")]
        //public IActionResult User()
        //{
        //    return Redirect("/User/Profile");
        //}
    }
}
