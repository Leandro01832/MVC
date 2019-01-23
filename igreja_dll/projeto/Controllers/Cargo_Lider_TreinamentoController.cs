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
    public class Cargo_Lider_TreinamentoController : Controller
    {
        private DB db = new DB();

        // GET: Cargo_Lider_Treinamento
        [AllowAnonymous]
        public ActionResult Index()
        {
            var lider_treinamento = db.lider_treinamento.Include(c => c.Pessoa);
            return View(lider_treinamento.ToList());
        }

        // GET: Cargo_Lider_Treinamento/Details/5
        [AllowAnonymous]
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Cargo_Lider_Treinamento cargo_Lider_Treinamento = db.lider_treinamento.Find(id);
            if (cargo_Lider_Treinamento == null)
            {
                return HttpNotFound();
            }
            return PartialView(cargo_Lider_Treinamento);
        }

        // GET: Cargo_Lider_Treinamento/Create
        public ActionResult Create()
        {
            ViewBag.Lidertreinamentoid = new SelectList(db.pessoas, "Id", "Nome");
            return View();
        }

        // POST: Cargo_Lider_Treinamento/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Lidertreinamentoid")] Cargo_Lider_Treinamento cargo_Lider_Treinamento)
        {
            if (ModelState.IsValid)
            {
                var email = User.Identity.GetUserName();
                var id = db.pessoas.First(e => e.Email == email).Id;
                cargo_Lider_Treinamento.Lidertreinamentoid = id;
                db.lider_treinamento.Add(cargo_Lider_Treinamento);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.Lidertreinamentoid = new SelectList(db.pessoas, "Id", "Nome", cargo_Lider_Treinamento.Lidertreinamentoid);
            return View(cargo_Lider_Treinamento);
        }

        // GET: Cargo_Lider_Treinamento/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Cargo_Lider_Treinamento cargo_Lider_Treinamento = db.lider_treinamento.Find(id);
            if (cargo_Lider_Treinamento == null)
            {
                return HttpNotFound();
            }
            ViewBag.Lidertreinamentoid = new SelectList(db.pessoas, "Id", "Nome", cargo_Lider_Treinamento.Lidertreinamentoid);
            return View(cargo_Lider_Treinamento);
        }

        // POST: Cargo_Lider_Treinamento/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Lidertreinamentoid")] Cargo_Lider_Treinamento cargo_Lider_Treinamento)
        {
            if (ModelState.IsValid)
            {
                db.Entry(cargo_Lider_Treinamento).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.Lidertreinamentoid = new SelectList(db.pessoas, "Id", "Nome", cargo_Lider_Treinamento.Lidertreinamentoid);
            return View(cargo_Lider_Treinamento);
        }

        // GET: Cargo_Lider_Treinamento/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Cargo_Lider_Treinamento cargo_Lider_Treinamento = db.lider_treinamento.Find(id);
            if (cargo_Lider_Treinamento == null)
            {
                return HttpNotFound();
            }
            return View(cargo_Lider_Treinamento);
        }

        // POST: Cargo_Lider_Treinamento/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Cargo_Lider_Treinamento cargo_Lider_Treinamento = db.lider_treinamento.Find(id);
            db.lider_treinamento.Remove(cargo_Lider_Treinamento);
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
