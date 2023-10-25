using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.IO;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using PokeriaCapstone.Models;

namespace PokeriaCapstone.Views.Home
{
    [Authorize(Roles = "Admin")]
    public class T_IngredientiController : Controller
    {
        private ModelDBContext db = new ModelDBContext();

        // GET: T_Ingredienti
        public ActionResult Index()
        {
            return View(db.T_Ingredienti.ToList());
        }

        // GET: T_Ingredienti/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            T_Ingredienti t_Ingredienti = db.T_Ingredienti.Find(id);
            if (t_Ingredienti == null)
            {
                return HttpNotFound();
            }
            return View(t_Ingredienti);
        }

        // GET: T_Ingredienti/Create
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(T_Ingredienti t_Ingredienti)
        {
            t_Ingredienti.FotoIngrediente = "";

                if (t_Ingredienti.Immagine != null && t_Ingredienti.Immagine.ContentLength > 0) 
                {
                    var immagine = Path.GetFileName(t_Ingredienti.Immagine.FileName);
                    var path = Path.Combine(Server.MapPath("~/Content/Assets/FotoIngredienti/"), immagine);
                    t_Ingredienti.Immagine.SaveAs(path);

                    t_Ingredienti.FotoIngrediente = immagine;
                }
                db.T_Ingredienti.Add(t_Ingredienti);
                db.SaveChanges();
                return RedirectToAction("Index");

        }

        // GET: T_Ingredienti/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            T_Ingredienti t_Ingredienti = db.T_Ingredienti.Find(id);
            if (t_Ingredienti == null)
            {
                return HttpNotFound();
            }
            return View(t_Ingredienti);
        }

        // POST: T_Ingredienti/Edit/5
        // Per la protezione da attacchi di overposting, abilitare le proprietà a cui eseguire il binding. 
        // Per altri dettagli, vedere https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "IDIngrediente,NomeIngrediente,TipoIngrediente,PrezzoAggiuntivo,FotoIngrediente")] T_Ingredienti t_Ingredienti)
        {
            if (ModelState.IsValid)
            {
                db.Entry(t_Ingredienti).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(t_Ingredienti);
        }

        // GET: T_Ingredienti/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            T_Ingredienti t_Ingredienti = db.T_Ingredienti.Find(id);
            if (t_Ingredienti == null)
            {
                return HttpNotFound();
            }
            return View(t_Ingredienti);
        }

        // POST: T_Ingredienti/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            T_Ingredienti t_Ingredienti = db.T_Ingredienti.Find(id);
            db.T_Ingredienti.Remove(t_Ingredienti);
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
