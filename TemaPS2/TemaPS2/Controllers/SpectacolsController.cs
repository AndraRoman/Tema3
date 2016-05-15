using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using TemaPS2.Models;

namespace TemaPS2.Controllers
{
    public class SpectacolsController : Controller
    {
        private SpectacolDbContext db = new SpectacolDbContext();

        // GET: Spectacols
        public ActionResult Index()
        {
            return View(db.Spectacole.ToList());
        }

        // GET: Spectacols/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Spectacol spectacol = db.Spectacole.Find(id);
            if (spectacol == null)
            {
                return HttpNotFound();
            }
            return View(spectacol);
        }

        // GET: Spectacols/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Spectacols/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "SpectacolID,Titlul,Regia,Distributia,DataPremierei,NrBilete")] Spectacol spectacol)
        {
            if (ModelState.IsValid)
            {
                db.Spectacole.Add(spectacol);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(spectacol);
        }

        // GET: Spectacols/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Spectacol spectacol = db.Spectacole.Find(id);
            if (spectacol == null)
            {
                return HttpNotFound();
            }
            return View(spectacol);
        }

        // POST: Spectacols/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "SpectacolID,Titlul,Regia,Distributia,DataPremierei,NrBilete")] Spectacol spectacol)
        {
            if (ModelState.IsValid)
            {
                db.Entry(spectacol).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(spectacol);
        }

        // GET: Spectacols/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Spectacol spectacol = db.Spectacole.Find(id);
            if (spectacol == null)
            {
                return HttpNotFound();
            }
            return View(spectacol);
        }

        // POST: Spectacols/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Spectacol spectacol = db.Spectacole.Find(id);
            db.Spectacole.Remove(spectacol);
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
