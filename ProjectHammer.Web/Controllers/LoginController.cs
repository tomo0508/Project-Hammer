using AutoMapper;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using ProjectHammer.Service.Interfaces;
using ProjectHammer.Service.Models;
using System.Security.Claims;
using System.Threading.Tasks;

namespace ProjectHammer.Web.Controllers
{

    public class LoginController : Controller
    {
        private readonly ILoginService loginService;
        private readonly IConfiguration config;
        private readonly IMapper mapper;

        public LoginController(ILoginService loginService,IConfiguration config, IMapper mapper)
        {
            this.loginService = loginService;
            this.config = config;
            this.mapper = mapper;
        }

        public ViewResult Index()
        {
            return View();
        }

        public IActionResult Login(string returnUrl = null)
        {
           
            TempData["returnUrl"] = returnUrl;
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Login(LoginPoco user, string returnUrl= null)
        {
            const string badUserNameOrPasswordMessage = "Username or password is incorrect.";
           
            var userFromLogin = loginService.Login(user.LoginUserName.ToLower(), user.LoginPassword);

            if (userFromLogin == null)
            {
                return BadRequest(badUserNameOrPasswordMessage);
            }

                var identity = new ClaimsIdentity(CookieAuthenticationDefaults.AuthenticationScheme);
                identity.AddClaim(new Claim(ClaimTypes.Name, userFromLogin.LoginUserName));

            await HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, new ClaimsPrincipal(identity));

                if (returnUrl == null)
                {
                    returnUrl = TempData["returnUrl"]?.ToString();
                }

                if (returnUrl != null)
                {
                    return Redirect(returnUrl);
                }

            return RedirectToAction(nameof(HomeController.Index), "Home");
        }

        public async Task<IActionResult> Logout()
        {
            await HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);
            return RedirectToAction(nameof(HomeController.Index), "Home");
        }
    }
}