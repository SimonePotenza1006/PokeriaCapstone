using PokeriaCapstone.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PokeriaCapstone.Controllers
{
    public class CreazionePokeController : Controller
    {
        private ModelDBContext db = new ModelDBContext();

        public ActionResult Index()
        {
            return View();
        }
    }
}