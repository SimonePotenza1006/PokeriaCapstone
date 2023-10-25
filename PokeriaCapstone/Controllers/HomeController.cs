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
            if (ModelState.IsValid)
            {
                T_User utente = db.T_User.Where(u => u.Username == user.Username && u.Password == user.Password).FirstOrDefault();
                FormsAuthentication.SetAuthCookie(utente.Username, false);
                Session["IDCliente"] = utente.IDUtente;
                return RedirectToAction("Index");
            }
            return View();
        }

    }
}
