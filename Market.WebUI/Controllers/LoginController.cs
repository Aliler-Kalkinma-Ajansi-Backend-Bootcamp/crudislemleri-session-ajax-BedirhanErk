using Market.WebUI.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Market.WebUI.Controllers
{
    public class LoginController : Controller
    {
        public static string Email = "admin@gmail.com";
        public string Password = "admin";
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Login(LoginModel data)
        {
            if (!ModelState.IsValid)
            {
                return RedirectToAction("Index", "Login");
            }
            if (SignIn(data.Email, data.Password))
            {
                if (HttpContext.Session.Get("returnUrl") != null)
                {
                    return Redirect(HttpContext.Session.GetString("returnUrl"));
                }
                return RedirectToAction("List", "Product");
            }
            else
            {
                return RedirectToAction("Index", "Login");
            }           
        }
        private bool SignIn(string email, string password)
        {
            bool result = true;
            result = CheckEmail(email) && CheckPassword(password) ? true : false;
            if (result)
            {
                HttpContext.Session.SetString("Login", email);

            }
            return result;
        }

        private bool CheckEmail(string _email)
        {
            if (_email != Email)
            {
                return false;
            }
            return true;
        }

        private bool CheckPassword(string _password)
        {
            if (_password != Password)
            {
                return false;
            }
            return true;
        }
    }
}
