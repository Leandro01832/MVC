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

namespace projeto.Controllers
{
    public class ChamadaController : Controller
    {
        private DB db = new DB();

        // GET: Chamada
        public ActionResult Index()
        {
            return View(db.Chamadas.ToList());
        }

        // GET: Chamada/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Chamada chamada = db.Chamadas.Find(id);
            if (chamada == null)
            {
                return HttpNotFound();
            }
            return View(chamada);
        }

        // GET: Chamada/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Chamada/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Data_inicio")] Chamada chamada)
        {
            if (ModelState.IsValid)
            {
                db.Chamadas.Add(chamada);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(chamada);
        }

        // GET: Chamada/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Chamada chamada = db.Chamadas.Find(id);
            if (chamada == null)
            {
                return HttpNotFound();
            }
            return View(chamada);
        }

        // POST: Chamada/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Data_inicio")] Chamada chamada)
        {
            if (ModelState.IsValid)
            {
                db.Entry(chamada).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(chamada);
        }

        // GET: Chamada/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Chamada chamada = db.Chamadas.Find(id);
            if (chamada == null)
            {
                return HttpNotFound();
            }
            return View(chamada);
        }

        // POST: Chamada/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Chamada chamada = db.Chamadas.Find(id);
            db.Chamadas.Remove(chamada);
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
