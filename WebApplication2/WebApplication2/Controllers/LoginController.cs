using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication2.Models;
namespace WebApplication2.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login
        public ActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Login(string name, string password)
        {
            if ("admin".Equals(name) && "123".Equals(password))
            {
                Session["user"] = new User() { Login = name, Name = "Nigar Hacibabayeva" };
                return RedirectToAction("Index", "Home");
            }
            return View();
        }
    }
}