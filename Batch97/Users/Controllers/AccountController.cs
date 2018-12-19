using Microsoft.AspNetCore.Mvc;
using Piranha;
using Piranha.Areas.Manager.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JFA.Yearbook.Web.Users.Controllers
{
    public class AccountController: Controller
    {
        private readonly IApi _api;
        private readonly ISecurity _security;

        public AccountController(IApi api, ISecurity security)
        {
            _api = api;
            _security = security;
        }

        [Route("login/{returnurl?}")]
        public IActionResult Login(string returnurl = null)
        {
            return View("Users/Views/Account/Login.cshtml", returnurl);
        }

        [Route("logout")]
        public async Task<IActionResult> Logout(string returnurl = null)
        {
            await _security.SignOut(HttpContext);

            return RedirectToAction("Login", "Account");
        }

        [HttpPost]
        [Route("login")]
        public async Task<IActionResult> Login(LoginModel model)
        {
            if (!string.IsNullOrWhiteSpace(model.UserName) && !string.IsNullOrWhiteSpace(model.Password))
            {
                var result = await _security.SignIn(HttpContext, model.UserName, model.Password);

                if (result)
                {
                    if (!string.IsNullOrWhiteSpace(model.ReturnUrl))
                        return Redirect(model.ReturnUrl);
                    else return RedirectToAction("Index", "Sections");
                }
            }
            ViewBag.Message = "You have entered an invalid username or password ";
            return Login(model.ReturnUrl);
        }
    }
}
