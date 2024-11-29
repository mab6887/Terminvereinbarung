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
    public class BehandlungsController : Controller
    {
        private TerminvereinbarungModelContainer db = new TerminvereinbarungModelContainer();

        // GET: Behandlungs
        public ActionResult Index()
        {
            return View(db.BehandlungSet.ToList());
        }

        // GET: Behandlungs/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Behandlung behandlung = db.BehandlungSet.Find(id);
            if (behandlung == null)
            {
                return HttpNotFound();
            }
            return View(behandlung);
        }

        // GET: Behandlungs/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Behandlungs/Create
        // Aktivieren Sie zum Schutz vor Angriffen durch Overposting die jeweiligen Eigenschaften, mit denen eine Bindung erfolgen soll. Weitere Informationen 
        // finden Sie unter https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Behandlungart,Behandlungsdauer")] Behandlung behandlung)
        {
            if (ModelState.IsValid)
            {
                db.BehandlungSet.Add(behandlung);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(behandlung);
        }

        // GET: Behandlungs/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Behandlung behandlung = db.BehandlungSet.Find(id);
            if (behandlung == null)
            {
                return HttpNotFound();
            }
            return View(behandlung);
        }

        // POST: Behandlungs/Edit/5
        // Aktivieren Sie zum Schutz vor Angriffen durch Overposting die jeweiligen Eigenschaften, mit denen eine Bindung erfolgen soll. Weitere Informationen 
        // finden Sie unter https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Behandlungart,Behandlungsdauer")] Behandlung behandlung)
        {
            if (ModelState.IsValid)
            {
                db.Entry(behandlung).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(behandlung);
        }

        // GET: Behandlungs/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Behandlung behandlung = db.BehandlungSet.Find(id);
            if (behandlung == null)
            {
                return HttpNotFound();
            }
            return View(behandlung);
        }

        // POST: Behandlungs/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Behandlung behandlung = db.BehandlungSet.Find(id);
            db.BehandlungSet.Remove(behandlung);
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
