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
    public class HistoricoController : Controller
    {
        private DB db = new DB();

        // GET: Historico
        public ActionResult Index()
        {
            IEnumerable<Pessoa> pessoas;

            using (var db = new DB())
            {
                pessoas = db.pessoas.Include(p => p.Chamada).Include(p => p.Historico).ToList();
            }
            
            foreach (var p in pessoas)
            {
                if (p.Chamada != null)
                {
                    if (p.Chamada.Data_inicio < DateTime.Now.AddDays(-60))
                    {
                        Historico historico = new Historico();
                        historico.Data_inicio = p.Chamada.Data_inicio;
                        historico.Falta = p.Falta;
                        historico.pessoaid = p.Id;
                        db.historico.Add(historico);                        
                        db.SaveChanges();
                    }
                }
                
            }
            return View(db.historico.ToList());
        }

        // GET: Historico/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Historico historico = db.historico.Find(id);
            if (historico == null)
            {
                return HttpNotFound();
            }
            return View(historico);
        }

        // GET: Historico/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Historico/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "historicoid,Data_inicio,Falta")] Historico historico)
        {
            if (ModelState.IsValid)
            {
                db.historico.Add(historico);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(historico);
        }

        // GET: Historico/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Historico historico = db.historico.Find(id);
            if (historico == null)
            {
                return HttpNotFound();
            }
            return View(historico);
        }

        // POST: Historico/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "historicoid,Data_inicio,Falta")] Historico historico)
        {
            if (ModelState.IsValid)
            {
                db.Entry(historico).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(historico);
        }

        // GET: Historico/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Historico historico = db.historico.Find(id);
            if (historico == null)
            {
                return HttpNotFound();
            }
            return View(historico);
        }

        // POST: Historico/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Historico historico = db.historico.Find(id);
            db.historico.Remove(historico);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

       

        // POST: Historico/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult listahistorico([Bind(Include = "Historico")] Pessoa pessoa)
        {
            if (ModelState.IsValid)
            {

                db.Entry(pessoa).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(pessoa);
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
