﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ISW_GASISW.Models;

namespace ISW_GASISW.Controllers
{
    public class TipoCompraController : Controller
    {
        private gasiswEntities db = new gasiswEntities();

        //
        // GET: /TipoCompra/

        public ActionResult Index()
        {
            return View(db.tipo_compra.ToList());
        }

        //
        // GET: /TipoCompra/Details/5

        public ActionResult Details(long id = 0)
        {
            tipo_compra tipo_compra = db.tipo_compra.Find(id);
            if (tipo_compra == null)
            {
                return HttpNotFound();
            }
            return View(tipo_compra);
        }

        //
        // GET: /TipoCompra/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /TipoCompra/Create

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(tipo_compra tipo_compra)
        {
            if (ModelState.IsValid)
            {
                db.tipo_compra.Add(tipo_compra);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(tipo_compra);
        }

        //
        // GET: /TipoCompra/Edit/5

        public ActionResult Edit(long id = 0)
        {
            tipo_compra tipo_compra = db.tipo_compra.Find(id);
            if (tipo_compra == null)
            {
                return HttpNotFound();
            }
            return View(tipo_compra);
        }

        //
        // POST: /TipoCompra/Edit/5

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(tipo_compra tipo_compra)
        {
            if (ModelState.IsValid)
            {
                db.Entry(tipo_compra).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(tipo_compra);
        }

        //
        // GET: /TipoCompra/Delete/5

        public ActionResult Delete(long id = 0)
        {
            tipo_compra tipo_compra = db.tipo_compra.Find(id);
            if (tipo_compra == null)
            {
                return HttpNotFound();
            }
            return View(tipo_compra);
        }

        //
        // POST: /TipoCompra/Delete/5

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(long id)
        {
            tipo_compra tipo_compra = db.tipo_compra.Find(id);
            db.tipo_compra.Remove(tipo_compra);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            db.Dispose();
            base.Dispose(disposing);
        }
    }
}