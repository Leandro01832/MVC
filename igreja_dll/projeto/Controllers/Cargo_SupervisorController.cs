using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using business.classes;
using repositorioEF;
using Microsoft.AspNet.Identity;

namespace projeto.Controllers
{
    [Authorize]
    public class Cargo_SupervisorController : Controller
    {
        private DB db = new DB();

        // GET: Cargo_Supervisor
        [AllowAnonymous]
        public ActionResult Index()
        {
            var supervisor = db.supervisor.Include(c => c.Pessoa);
            return View(supervisor.ToList());
        }

        // GET: Cargo_Supervisor/Details/5
        [AllowAnonymous]
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Cargo_Supervisor cargo_Supervisor = db.supervisor.Find(id);
            if (cargo_Supervisor == null)
            {
                return HttpNotFound();
            }
            return PartialView(cargo_Supervisor);
        }

        // GET: Cargo_Supervisor/Create
        public ActionResult Create()
        {
            ViewBag.Supervisorid = new SelectList(db.pessoas, "Id", "Nome");
            return View();
        }

        // POST: Cargo_Supervisor/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Supervisorid,Maximo_celula")] Cargo_Supervisor cargo_Supervisor)
        {
            if (ModelState.IsValid)
            {
                var email = User.Identity.GetUserName();
                var id = db.pessoas.First(e => e.Email == email).Id;
                cargo_Supervisor.Supervisorid = id;
                db.supervisor.Add(cargo_Supervisor);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.Supervisorid = new SelectList(db.pessoas, "Id", "Nome", cargo_Supervisor.Supervisorid);
            return View(cargo_Supervisor);
        }

        // GET: Cargo_Supervisor/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Cargo_Supervisor cargo_Supervisor = db.supervisor.Find(id);
            if (cargo_Supervisor == null)
            {
                return HttpNotFound();
            }
            ViewBag.Supervisorid = new SelectList(db.pessoas, "Id", "Nome", cargo_Supervisor.Supervisorid);
            return View(cargo_Supervisor);
        }

        // POST: Cargo_Supervisor/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Supervisorid,Maximo_celula")] Cargo_Supervisor cargo_Supervisor)
        {
            if (ModelState.IsValid)
            {
                db.Entry(cargo_Supervisor).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.Supervisorid = new SelectList(db.pessoas, "Id", "Nome", cargo_Supervisor.Supervisorid);
            return View(cargo_Supervisor);
        }

        // GET: Cargo_Supervisor/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Cargo_Supervisor cargo_Supervisor = db.supervisor.Find(id);
            if (cargo_Supervisor == null)
            {
                return HttpNotFound();
            }
            return View(cargo_Supervisor);
        }

        // POST: Cargo_Supervisor/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Cargo_Supervisor cargo_Supervisor = db.supervisor.Find(id);
            db.supervisor.Remove(cargo_Supervisor);
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
