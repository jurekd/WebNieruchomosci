using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using WebNieruchomosci.Models;

namespace WebNieruchomosci.Controllers
{
    public class NieruchomosciController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: Nieruchomosci
        public ActionResult Index()
        {
            return View(db.Nieruchomoscs.ToList());
        }

        // GET: Nieruchomosci/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            WebNieruchomosci.Models.Nieruchomosc nieruchomosc = db.Nieruchomoscs.Find(id);
            if (nieruchomosc == null)
            {
                return HttpNotFound();
            }
            return View(nieruchomosc);
        }

        // GET: Nieruchomosci/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Nieruchomosci/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Ulica,Miasto,NrDomu,NrMieszkania,KodPocztowy")] Nieruchomosc nieruchomosc)
        {
            if (ModelState.IsValid)
            {
                db.Nieruchomoscs.Add(nieruchomosc);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(nieruchomosc);
        }

        // GET: Nieruchomosci/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Nieruchomosc nieruchomosc = db.Nieruchomoscs.Find(id);
            if (nieruchomosc == null)
            {
                return HttpNotFound();
            }
            return View(nieruchomosc);
        }

        // POST: Nieruchomosci/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Ulica,Miasto,NrDomu,NrMieszkania,KodPocztowy")] Nieruchomosc nieruchomosc)
        {
            if (ModelState.IsValid)
            {
                db.Entry(nieruchomosc).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(nieruchomosc);
        }

        // GET: Nieruchomosci/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Nieruchomosc nieruchomosc = db.Nieruchomoscs.Find(id);
            if (nieruchomosc == null)
            {
                return HttpNotFound();
            }
            return View(nieruchomosc);
        }

        // POST: Nieruchomosci/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Nieruchomosc nieruchomosc = db.Nieruchomoscs.Find(id);
            db.Nieruchomoscs.Remove(nieruchomosc);
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
