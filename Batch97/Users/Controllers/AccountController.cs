using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JFA.Yearbook.Web.Users.Controllers
{
    public class AccountController: Controller
    {

        public AccountController()
        {
        }

        [Route("login/{returnurl?}")]
        public IActionResult Login(string returnurl = null)
        {
            return View("~/Users/Views/Account/Login.cshtml", returnurl);
        }

        [Route("logout")]
        public IActionResult Logout(string returnurl = null)
        {
            return RedirectToAction("Login", "Account");
        }

        [HttpPost]
        [Route("login")]
        public async Task<IActionResult> Login(LoginModel model)
        {
            if (!string.IsNullOrWhiteSpace(model.Username) && !string.IsNullOrWhiteSpace(model.Password))
            {
                //var result = await _security.SignIn(HttpContext, model.UserName, model.Password);

//                if (result)
//                {
//                    if (!string.IsNullOrWhiteSpace(model.ReturnUrl))
//                        return Redirect(model.ReturnUrl);
//                    else return RedirectToAction("Index", "Sections");
//                }
            }
            ViewBag.Message = "You have entered an invalid username or password ";
            //return Login(model.ReturnUrl);
            return View("~/Users/Views/Account/Login.cshtml");
        }
        
        [HttpGet]
        [Route("register")]
        public IActionResult Register()
        {
            return View("~/Users/Views/Account/Register.cshtml");
        }
    }
}
