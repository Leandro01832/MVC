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
using projeto.Models;

namespace projeto.Controllers
{
    public class CelulaController : Controller
    {
        private DB db = new DB();

        // GET: Celula
        public ActionResult Index()
        {
            var celula = db.celula.Include(c => c.Endereco_Celula).Include(c => c.Lider.Pessoa).Include(c => c.Lider_treinamento.Pessoa).Include(c => c.Supervisor.Pessoa).Include(c => c.Supervisor_treianamento.Pessoa);
            return View(celula.ToList());
        }

        // GET: Celula/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Celula celula = db.celula.Find(id);
            if (celula == null)
            {
                return HttpNotFound();
            }
            return PartialView(celula);
        }

        // GET: Celula/Create
        public ActionResult Create()
        {
            ViewBag.Celulaid = new SelectList(db.endereco_celula, "enderecoid", "Cel_bairro");
            ViewBag.Lider_ = new SelectList(db.pessoas.Where(p => p.Cargo_Lider != null && db.celula.FirstOrDefault(c => c.Lider_ == p.Id) == null), "Id", "Nome");
            ViewBag.Lidertreinamento_ = new SelectList(db.pessoas.Where(p => p.Cargo_Lider_Treinamento != null && db.celula.FirstOrDefault(c => c.Lidertreinamento_ == p.Id) == null), "Id", "Nome");
            ViewBag.Supervisor_ = new SelectList(db.pessoas.Where(p => p.Cargo_Supervisor != null), "Id", "Nome");
            ViewBag.Supervisortreinamento_ = new SelectList(db.pessoas.Where(p => p.Cargo_Supervisor_Treinamento != null), "Id", "Nome");
            return View();
        }

        // POST: Celula/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Celulaid,Cel_nome,Dia_semana,Horario,Maximo_pessoa,Lider_,Lidertreinamento_,Supervisor_,Supervisortreinamento_,Endereco_Celula")] Celula celula)
        {
            if (ModelState.IsValid)
            {
                db.celula.Add(celula);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.Celulaid = new SelectList(db.endereco_celula, "enderecoid", "Cel_bairro", celula.Celulaid);
            ViewBag.Lider_ = new SelectList(db.lider, "Liderid", "Liderid", celula.Lider_);
            ViewBag.Lidertreinamento_ = new SelectList(db.lider_treinamento, "Lidertreinamentoid", "Lidertreinamentoid", celula.Lidertreinamento_);
            ViewBag.Supervisor_ = new SelectList(db.supervisor, "Supervisorid", "Supervisorid", celula.Supervisor_);
            ViewBag.Supervisortreinamento_ = new SelectList(db.supervisor_treinamento, "Supervisortreinamentoid", "Supervisortreinamentoid", celula.Supervisortreinamento_);
            return View(celula);
        }

        // GET: Celula/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Celula celula = db.celula.Find(id);
            if (celula == null)
            {
                return HttpNotFound();
            }
            ViewBag.Celulaid = new SelectList(db.endereco_celula, "enderecoid", "Cel_bairro", celula.Celulaid);
            ViewBag.Lider_ = new SelectList(db.pessoas.Where(p => p.Cargo_Lider != null && db.celula.FirstOrDefault(c => c.Lider_ == p.Id) == null), "Id", "Nome");
            ViewBag.Lidertreinamento_ = new SelectList(db.pessoas.Where(p => p.Cargo_Lider_Treinamento != null && db.celula.FirstOrDefault(c => c.Lidertreinamento_ == p.Id) == null), "Id", "Nome");
            ViewBag.Supervisor_ = new SelectList(db.pessoas.Where(p => p.Cargo_Supervisor != null), "Id", "Nome");
            ViewBag.Supervisortreinamento_ = new SelectList(db.pessoas.Where(p => p.Cargo_Supervisor_Treinamento != null), "Id", "Nome");
            return View(celula);
        }

        // POST: Celula/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Celulaid,Cel_nome,Dia_semana,Horario,Maximo_pessoa,Lider_,Lidertreinamento_,Supervisor_,Supervisortreinamento_,Endereco_Celula")] Celula celula)
        {
            if (ModelState.IsValid)
            {
                db.Entry(celula.Endereco_Celula).State = EntityState.Modified;
                db.Entry(celula).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.Celulaid = new SelectList(db.endereco_celula, "enderecoid", "Cel_bairro", celula.Celulaid);
            ViewBag.Lider_ = new SelectList(db.lider, "Liderid", "Liderid", celula.Lider_);
            ViewBag.Lidertreinamento_ = new SelectList(db.lider_treinamento, "Lidertreinamentoid", "Lidertreinamentoid", celula.Lidertreinamento_);
            ViewBag.Supervisor_ = new SelectList(db.supervisor, "Supervisorid", "Supervisorid", celula.Supervisor_);
            ViewBag.Supervisortreinamento_ = new SelectList(db.supervisor_treinamento, "Supervisortreinamentoid", "Supervisortreinamentoid", celula.Supervisortreinamento_);
            return View(celula);
        }

        // GET: Celula/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Celula celula = db.celula.Find(id);
            if (celula == null)
            {
                return HttpNotFound();
            }
            return View(celula);
        }

        // POST: Celula/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Celula celula = db.celula.Find(id);
            db.celula.Remove(celula);
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
