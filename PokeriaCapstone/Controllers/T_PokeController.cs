using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Security.Cryptography.X509Certificates;
using System.Security.Policy;
using System.Web;
using System.Web.Mvc;
using System.Web.UI;
using Newtonsoft.Json;
using PokeriaCapstone.Models;

namespace PokeriaCapstone.Controllers
{
    
    public class T_PokeController : Controller
    {
        private ModelDBContext db = new ModelDBContext();

        // GET: T_Poke
        public ActionResult Index()
        {
            return View(db.T_Poke.ToList());
        }

        // GET: T_Poke/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            T_Poke t_Poke = db.T_Poke.Find(id);
            if (t_Poke == null)
            {
                return HttpNotFound();
            }
            return View(t_Poke);
        }

        // GET: T_Poke/Create
        public ActionResult Create()
        {
            return View();
        }


        public ActionResult RecapPoke()
        {
            return View();
        }

        

        [HttpGet]
        public ActionResult CreateNewPokeComposta(string Prezzi, string Ingredienti)
        {

            List<decimal> PrezziList = JsonConvert.DeserializeObject<List<decimal>>(Prezzi);
            List<int> IngredientiList = JsonConvert.DeserializeObject<List<int>>(Ingredienti);
            decimal PrezzoTotale = 11;
            foreach (decimal prezzo in PrezziList)
            {
                PrezzoTotale += prezzo;
            }
            T_Poke Poke = new T_Poke("La tua poke", true, PrezzoTotale, "");
            db.T_Poke.Add(Poke);
            db.SaveChanges();
            foreach (int ingrediente in IngredientiList)
            {
                db.T_RelazionePokeIngredienti.Add(new T_RelazionePokeIngredienti
                {
                    FKIDPoke = Poke.IDPoke,
                    FKIDIngrediente = ingrediente,
                });
            }
            db.SaveChanges();
            T_Ordini Ordine = new T_Ordini(Convert.ToInt32(Session["IDUser"]), Poke.IDPoke);
            db.T_Ordini.Add(Ordine);
            db.SaveChanges();

            return View("Index", "T_Ordini");
        }

        // GET: T_Poke/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            T_Poke t_Poke = db.T_Poke.Find(id);
            if (t_Poke == null)
            {
                return HttpNotFound();
            }
            return View(t_Poke);
        }

        // POST: T_Poke/Edit/5
        // Per la protezione da attacchi di overposting, abilitare le proprietà a cui eseguire il binding. 
        // Per altri dettagli, vedere https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "IDPoke,NomePoke,IsComposta,Prezzo,FotoPoke")] T_Poke t_Poke)
        {
            if (ModelState.IsValid)
            {
                db.Entry(t_Poke).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(t_Poke);
        }

        // GET: T_Poke/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            T_Poke t_Poke = db.T_Poke.Find(id);
            if (t_Poke == null)
            {
                return HttpNotFound();
            }
            return View(t_Poke);
        }

        // POST: T_Poke/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            T_Poke t_Poke = db.T_Poke.Find(id);
            db.T_Poke.Remove(t_Poke);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
