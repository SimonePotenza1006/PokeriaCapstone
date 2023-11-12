﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using PokeriaCapstone.Models;

namespace PokeriaCapstone.Controllers
{
    public class T_OrdiniController : Controller
    {
        private ModelDBContext db = new ModelDBContext();

        // GET: T_Ordini
        public ActionResult Index()
        {
            int idUser = Convert.ToInt32(Session["IDUser"]);
            List<T_Ordini> listaOrdini = db.T_Ordini.Where(d => d.DataOrdine == null && d.FKIDUser == idUser).ToList();
            return View(listaOrdini);
        }

        // GET: T_Ordini/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            T_Ordini t_Ordini = db.T_Ordini.Find(id);
            if (t_Ordini == null)
            {
                return HttpNotFound();
            }
            return View(t_Ordini);
        }

        // GET: T_Ordini/Create
        public ActionResult Create()
        {
            ViewBag.FKIDPoke = new SelectList(db.T_Poke, "IDPoke", "NomePoke");
            ViewBag.FKIDUser = new SelectList(db.T_User, "IDUser", "Username");
            return View();
        }

        // POST: T_Ordini/Create
        // Per la protezione da attacchi di overposting, abilitare le proprietà a cui eseguire il binding. 
        // Per altri dettagli, vedere https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "IDOrdine,FKIDUser,FKIDPoke,DataOrdine")] T_Ordini t_Ordini)
        {
            if (ModelState.IsValid)
            {
                db.T_Ordini.Add(t_Ordini);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.FKIDPoke = new SelectList(db.T_Poke, "IDPoke", "NomePoke", t_Ordini.FKIDPoke);
            ViewBag.FKIDUser = new SelectList(db.T_User, "IDUser", "Username", t_Ordini.FKIDUser);
            return View(t_Ordini);
        }

        // GET: T_Ordini/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            T_Ordini t_Ordini = db.T_Ordini.Find(id);
            if (t_Ordini == null)
            {
                return HttpNotFound();
            }
            ViewBag.FKIDPoke = new SelectList(db.T_Poke, "IDPoke", "NomePoke", t_Ordini.FKIDPoke);
            ViewBag.FKIDUser = new SelectList(db.T_User, "IDUser", "Username", t_Ordini.FKIDUser);
            return View(t_Ordini);
        }

        // POST: T_Ordini/Edit/5
        // Per la protezione da attacchi di overposting, abilitare le proprietà a cui eseguire il binding. 
        // Per altri dettagli, vedere https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "IDOrdine,FKIDUser,FKIDPoke,DataOrdine")] T_Ordini t_Ordini)
        {
            if (ModelState.IsValid)
            {
                db.Entry(t_Ordini).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.FKIDPoke = new SelectList(db.T_Poke, "IDPoke", "NomePoke", t_Ordini.FKIDPoke);
            ViewBag.FKIDUser = new SelectList(db.T_User, "IDUser", "Username", t_Ordini.FKIDUser);
            return View(t_Ordini);
        }

        // POST: T_Ordini/Delete/5
        [HttpGet]
        public ActionResult DeleteConfirmed(int id)
        {
            T_Ordini t_Ordini = db.T_Ordini.Find(id);
            db.T_Ordini.Remove(t_Ordini);
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
