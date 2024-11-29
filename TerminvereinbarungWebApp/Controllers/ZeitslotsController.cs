using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using TerminvereinbarungLib;

namespace TerminvereinbarungWebApp.Controllers
{
    public class ZeitslotsController : Controller
    {
        private TerminvereinbarungModelContainer db = new TerminvereinbarungModelContainer();

        // GET: Zeitslots
        public ActionResult Index()
        {
            return View(db.ZeitslotSet.ToList());
        }

        // GET: Zeitslots/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Zeitslot zeitslot = db.ZeitslotSet.Find(id);
            if (zeitslot == null)
            {
                return HttpNotFound();
            }
            return View(zeitslot);
        }

        // GET: Zeitslots/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Zeitslots/Create
        // Aktivieren Sie zum Schutz vor Angriffen durch Overposting die jeweiligen Eigenschaften, mit denen eine Bindung erfolgen soll. Weitere Informationen 
        // finden Sie unter https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Startzeitpunkt,Dauer")] Zeitslot zeitslot)
        {
            if (ModelState.IsValid)
            {
                db.ZeitslotSet.Add(zeitslot);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(zeitslot);
        }

        // GET: Zeitslots/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Zeitslot zeitslot = db.ZeitslotSet.Find(id);
            if (zeitslot == null)
            {
                return HttpNotFound();
            }
            return View(zeitslot);
        }

        // POST: Zeitslots/Edit/5
        // Aktivieren Sie zum Schutz vor Angriffen durch Overposting die jeweiligen Eigenschaften, mit denen eine Bindung erfolgen soll. Weitere Informationen 
        // finden Sie unter https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Startzeitpunkt,Dauer")] Zeitslot zeitslot)
        {
            if (ModelState.IsValid)
            {
                db.Entry(zeitslot).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(zeitslot);
        }

        // GET: Zeitslots/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Zeitslot zeitslot = db.ZeitslotSet.Find(id);
            if (zeitslot == null)
            {
                return HttpNotFound();
            }
            return View(zeitslot);
        }

        // POST: Zeitslots/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Zeitslot zeitslot = db.ZeitslotSet.Find(id);
            db.ZeitslotSet.Remove(zeitslot);
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
