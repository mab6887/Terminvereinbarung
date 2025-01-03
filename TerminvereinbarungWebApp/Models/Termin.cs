using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using TerminvereinbarungLib;

namespace TerminvereinbarungWebApp.Models
{
    public class Termin : Controller
    {
        private TerminvereinbarungModelContainer db = new TerminvereinbarungModelContainer();

        // GET: Termin
        public ActionResult Index()
        {
            var terminSet = db.TerminSet.Include(t => t.Arzt).Include(t => t.Patient).Include(t => t.Behandlung).Include(t => t.Zeitslot);
            return View(terminSet.ToList());
        }

        // GET: Termin/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Termin termin = db.TerminSet.Find(id);
            if (termin == null)
            {
                return HttpNotFound();
            }
            return View(termin);
        }

        // GET: Termin/Create
        public ActionResult Create()
        {
            ViewBag.ArztId = new SelectList(db.UserSet, "Id", "Vorname");
            ViewBag.PatientId = new SelectList(db.UserSet, "Id", "Vorname");
            ViewBag.BehandlungId = new SelectList(db.BehandlungSet, "Id", "Behandlungart");
            ViewBag.ZeitslotId = new SelectList(db.ZeitslotSet, "Id", "Id");
            return View();
        }

        // POST: Termin/Create
        // Aktivieren Sie zum Schutz vor Angriffen durch Overposting die jeweiligen Eigenschaften, mit denen eine Bindung erfolgen soll. Weitere Informationen 
        // finden Sie unter https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,ArztId,PatientId,angefragt,bestätigt,abgeschlossen,BehandlungId,ZeitslotId")] Termin termin)
        {
            if (ModelState.IsValid)
            {
                db.TerminSet.Add(termin);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.ArztId = new SelectList(db.UserSet, "Id", "Vorname", termin.ArztId);
            ViewBag.PatientId = new SelectList(db.UserSet, "Id", "Vorname", termin.PatientId);
            ViewBag.BehandlungId = new SelectList(db.BehandlungSet, "Id", "Behandlungart", termin.BehandlungId);
            ViewBag.ZeitslotId = new SelectList(db.ZeitslotSet, "Id", "Id", termin.ZeitslotId);
            return View(termin);
        }

        // GET: Termin/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Termin termin = db.TerminSet.Find(id);
            if (termin == null)
            {
                return HttpNotFound();
            }
            ViewBag.ArztId = new SelectList(db.UserSet, "Id", "Vorname", termin.ArztId);
            ViewBag.PatientId = new SelectList(db.UserSet, "Id", "Vorname", termin.PatientId);
            ViewBag.BehandlungId = new SelectList(db.BehandlungSet, "Id", "Behandlungart", termin.BehandlungId);
            ViewBag.ZeitslotId = new SelectList(db.ZeitslotSet, "Id", "Id", termin.ZeitslotId);
            return View(termin);
        }

        // POST: Termin/Edit/5
        // Aktivieren Sie zum Schutz vor Angriffen durch Overposting die jeweiligen Eigenschaften, mit denen eine Bindung erfolgen soll. Weitere Informationen 
        // finden Sie unter https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,ArztId,PatientId,angefragt,bestätigt,abgeschlossen,BehandlungId,ZeitslotId")] Termin termin)
        {
            if (ModelState.IsValid)
            {
                db.Entry(termin).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.ArztId = new SelectList(db.UserSet, "Id", "Vorname", termin.ArztId);
            ViewBag.PatientId = new SelectList(db.UserSet, "Id", "Vorname", termin.PatientId);
            ViewBag.BehandlungId = new SelectList(db.BehandlungSet, "Id", "Behandlungart", termin.BehandlungId);
            ViewBag.ZeitslotId = new SelectList(db.ZeitslotSet, "Id", "Id", termin.ZeitslotId);
            return View(termin);
        }

        // GET: Termin/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Termin termin = db.TerminSet.Find(id);
            if (termin == null)
            {
                return HttpNotFound();
            }
            return View(termin);
        }

        // POST: Termin/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Termin termin = db.TerminSet.Find(id);
            db.TerminSet.Remove(termin);
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
