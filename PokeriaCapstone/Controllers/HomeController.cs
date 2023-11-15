using PokeriaCapstone.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace PokeriaCapstone.Controllers
{
    public class HomeController : Controller
    {
        private ModelDBContext db = new ModelDBContext();
        public ActionResult Index()
        {
            ViewBag.Title = "Home Page";
            return View();
        }

        
        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(T_User user)
        {
                T_User utente = db.T_User.Where(u => u.Email == user.Email && u.Password == user.Password).FirstOrDefault();
                FormsAuthentication.SetAuthCookie(utente.Username, false);
                Session["Username"] = utente.Username;
                Session["IDUser"] = utente.IDUser;
                Session["UserRole"] = utente.Role.ToString();
                return RedirectToAction("Index");
        }

        public ActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Register([Bind(Exclude = "Role")] T_User user)
        {
            if (ModelState.IsValid)
            {
                user.Role = "User";
                db.T_User.Add(user);
                db.SaveChanges();
                return RedirectToAction("Login", user);
            }
            return View();
        }

        [Authorize]
        public ActionResult Logout()
        {
            FormsAuthentication.SignOut();
            return RedirectToAction("Index");
        }

    }
}
