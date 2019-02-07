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
    [Authorize(Roles ="Reuniao")]
    public class ReuniaoController : Controller
    {
        private DB db = new DB();

        // GET: Reuniao
        public ActionResult Index()
        {
            return View(db.reuniao.ToList());
        }

        // GET: Reuniao/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Reuniao reuniao = db.reuniao.Find(id);
            if (reuniao == null)
            {
                return HttpNotFound();
            }
            return View(reuniao);
        }

        // GET: Reuniao/Create
        public ActionResult Create()
        {
            ViewBag.ministerio = db.ministerio;
            return View();
        }

        // POST: Reuniao/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "cronologiaid,Data_reuniao,Horario_inicio,Horario_fim,Local_reuniao,Pessoas")] Reuniao reuniao)
        {
            if (ModelState.IsValid)
            {
                var lider = Request["lider"];
                var lider_treinamento = Request["lider_treinamento"];
                var supervisor = Request["supervisor"];
                var supervisor_treinamento = Request["supervisor_treinamento"];

                reuniao.Pessoas = new List<Pessoa>();

                if (lider != null)
                {                    
                    reuniao.Pessoas.AddRange(db.pessoas.Where(p => p.Cargo_Lider != null));
                }

                if (lider_treinamento != null)
                {                    
                    reuniao.Pessoas.AddRange(db.pessoas.Where(p => p.Cargo_Lider_Treinamento != null));
                }

                if (supervisor != null)
                {
                    reuniao.Pessoas.AddRange(db.pessoas.Where(p => p.Cargo_Supervisor != null));
                }

                if (supervisor_treinamento != null)
                {
                    reuniao.Pessoas.AddRange(db.pessoas.Where(p => p.Cargo_Supervisor_Treinamento != null));
                }

                IEnumerable<Ministerio> ministerios = db.ministerio;

                foreach (var m in ministerios)
                {
                    List<string> valores = new List<string>();
                    valores.Add(Request[m.Nome]);

                    for (int i = 0; i < valores.Count(); i++)
                    {
                        if (valores[i] != null)
                        {
                            var lista = db.ministerio.FirstOrDefault(mi => mi.Nome == valores[i]).Pessoas;
                            reuniao.Pessoas.AddRange(lista);
                        }
                    }
                }               

                db.reuniao.Add(reuniao);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(reuniao);
        }

        // GET: Reuniao/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Reuniao reuniao = db.reuniao.Find(id);
            if (reuniao == null)
            {
                return HttpNotFound();
            }
            return View(reuniao);
        }

        // POST: Reuniao/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "cronologiaid,Data_reuniao,Horario_inicio,Horario_fim,Local_reuniao")] Reuniao reuniao)
        {
            if (ModelState.IsValid)
            {
                db.Entry(reuniao).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(reuniao);
        }

        // GET: Reuniao/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Reuniao reuniao = db.reuniao.Find(id);
            if (reuniao == null)
            {
                return HttpNotFound();
            }
            return View(reuniao);
        }

        // POST: Reuniao/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Reuniao reuniao = db.reuniao.Find(id);
            db.reuniao.Remove(reuniao);
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
