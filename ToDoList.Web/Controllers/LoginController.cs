using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using ToDoList.Web.Models.ViewModels;

namespace ToDoList.Web.Controllers
{
    [AllowAnonymous]
    public class LoginController : Controller
    {
        
        // GET: Login
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Index(LoginViewModel login, string ReturnUrl)
        {
            if (login.Account.Equals("Admin") && login.Password.Equals("123"))
            {
                FormsAuthentication.RedirectFromLoginPage(login.Account, false);

                return Redirect(ReturnUrl ?? "/Home/Index");
            }

            return View();
        }

    }
}