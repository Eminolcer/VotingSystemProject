using Microsoft.AspNetCore.Mvc;
using VotingSystemProject.Models;
using VotingSystemProject.Services;

namespace VotingSystemProject.Controllers
{
    public class LoginController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult ProcessLogin(UserModel userModel)
        {
            SecurityService securityService = new SecurityService();

            if (securityService.IsValid(userModel))
            { 
                return View("LoginSuccess", userModel);
            } else
            {
                return View("LoginFailure", userModel);
            }

        }
    }
}
