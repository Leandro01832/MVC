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
using System.IO;

namespace projeto.Controllers
{
    [Authorize]
    public class VisitanteController : Controller
    {
        private DB db = new DB();

        // GET: Visitante
        [AllowAnonymous]
        public ActionResult Index()
        {
            var pessoas = db.visitante.Include(v => v.Cargo_Lider).Include(v => v.Cargo_Lider_Treinamento).Include(v => v.Cargo_Supervisor).Include(v => v.Cargo_Supervisor_Treinamento).Include(v => v.Celula).Include(v => v.Endereco).Include(v => v.Telefone);
            return View(pessoas.ToList());
        }

        // GET: Visitante/Details/5
        [AllowAnonymous]
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Visitante visitante = db.visitante.Find(id);
            if (visitante == null)
            {
                return HttpNotFound();
            }
            return PartialView(visitante);
        }

        // GET: Visitante/Create
        public ActionResult Create()
        {
            ViewBag.email = User.Identity.GetUserName();
            ViewBag.Id = new SelectList(db.lider, "Liderid", "Liderid");
            ViewBag.Id = new SelectList(db.lider_treinamento, "Lidertreinamentoid", "Lidertreinamentoid");
            ViewBag.Id = new SelectList(db.supervisor, "Supervisorid", "Supervisorid");
            ViewBag.Id = new SelectList(db.supervisor_treinamento, "Supervisortreinamentoid", "Supervisortreinamentoid");
            ViewBag.celula_ = new SelectList(db.celula, "Celulaid", "Cel_nome");
            ViewBag.Id = new SelectList(db.endereco, "EnderecoId", "Pais");
            ViewBag.Id = new SelectList(db.telefone, "telefoneid", "Fone");
            return View();
        }

        // POST: Visitante/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Nome,Data_nascimento,Rg,Cpf,Estado_civil,Sexo_masculino,Sexo_feminino,Falescimento,Status,Email,Falta,celula_,Img,imgtipo,classe,Data_visita,Condicao_religiosa,Endereco,Telefone,Chamada")] Visitante visitante, HttpPostedFileBase upload)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    if (upload != null && upload.ContentLength > 0)
                    {
                        visitante.imgtipo = upload.ContentType;

                        using (var reader = new BinaryReader(upload.InputStream))
                        {
                            visitante.Img = reader.ReadBytes(upload.ContentLength);
                        }
                    }

                    visitante.Chamada.Numero_chamada = db.celula.First(c => c.Celulaid == visitante.celula_).Pessoas.Count + 1;
                    visitante.classe = "Visitante";
                    db.pessoas.Add(visitante);
                    db.SaveChanges();
                    return RedirectToAction("Index");
                }

                catch (Exception ex)
                {
                    ViewBag.email = User.Identity.GetUserName();
                    ViewBag.error = "Você já foi cadastrado. " + ex.Message;
                    ViewBag.celula_ = new SelectList(db.celula, "Celulaid", "Cel_nome");
                    return View(visitante);
                }

            }

            ViewBag.Id = new SelectList(db.lider, "Liderid", "Liderid", visitante.Id);
            ViewBag.Id = new SelectList(db.lider_treinamento, "Lidertreinamentoid", "Lidertreinamentoid", visitante.Id);
            ViewBag.Id = new SelectList(db.supervisor, "Supervisorid", "Supervisorid", visitante.Id);
            ViewBag.Id = new SelectList(db.supervisor_treinamento, "Supervisortreinamentoid", "Supervisortreinamentoid", visitante.Id);
            ViewBag.celula_ = new SelectList(db.celula, "Celulaid", "Cel_nome", visitante.celula_);
            ViewBag.Id = new SelectList(db.endereco, "EnderecoId", "Pais", visitante.Id);
            ViewBag.Id = new SelectList(db.telefone, "telefoneid", "Fone", visitante.Id);
            return View(visitante);
        }

        // GET: Visitante/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Visitante visitante = db.visitante.Find(id);
            if (visitante == null)
            {
                return HttpNotFound();
            }

            ViewBag.email = User.Identity.GetUserName();
            ViewBag.Id = new SelectList(db.lider, "Liderid", "Liderid", visitante.Id);
            ViewBag.Id = new SelectList(db.lider_treinamento, "Lidertreinamentoid", "Lidertreinamentoid", visitante.Id);
            ViewBag.Id = new SelectList(db.supervisor, "Supervisorid", "Supervisorid", visitante.Id);
            ViewBag.Id = new SelectList(db.supervisor_treinamento, "Supervisortreinamentoid", "Supervisortreinamentoid", visitante.Id);
            ViewBag.celula_ = new SelectList(db.celula, "Celulaid", "Cel_nome", visitante.celula_);
            ViewBag.Id = new SelectList(db.endereco, "EnderecoId", "Pais", visitante.Id);
            ViewBag.Id = new SelectList(db.telefone, "telefoneid", "Fone", visitante.Id);
            return View(visitante);
        }

        // POST: Visitante/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Nome,Data_nascimento,Rg,Cpf,Estado_civil,Sexo_masculino,Sexo_feminino,Falescimento,Status,Email,Falta,celula_,Img,imgtipo,classe,Data_visita,Condicao_religiosa,Endereco,Telefone")] Visitante visitante, HttpPostedFileBase upload)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    if (upload != null && upload.ContentLength > 0)
                    {
                        visitante.imgtipo = upload.ContentType;

                        using (var reader = new BinaryReader(upload.InputStream))
                        {
                            visitante.Img = reader.ReadBytes(upload.ContentLength);
                        }
                    }

                    visitante.classe = "Visitante";
                    db.Entry(visitante.Endereco).State = EntityState.Modified;
                    db.Entry(visitante.Telefone).State = EntityState.Modified;
                    db.Entry(visitante).State = EntityState.Modified;
                    db.SaveChanges();
                    return RedirectToAction("Index");
                }

                catch (Exception ex)
                {
                    ViewBag.email = User.Identity.GetUserName();
                    ViewBag.error = "Você já foi cadastrado. " + ex.Message;
                    ViewBag.celula_ = new SelectList(db.celula, "Celulaid", "Cel_nome");
                    return View(visitante);
                }

            }
            ViewBag.Id = new SelectList(db.lider, "Liderid", "Liderid", visitante.Id);
            ViewBag.Id = new SelectList(db.lider_treinamento, "Lidertreinamentoid", "Lidertreinamentoid", visitante.Id);
            ViewBag.Id = new SelectList(db.supervisor, "Supervisorid", "Supervisorid", visitante.Id);
            ViewBag.Id = new SelectList(db.supervisor_treinamento, "Supervisortreinamentoid", "Supervisortreinamentoid", visitante.Id);
            ViewBag.celula_ = new SelectList(db.celula, "Celulaid", "Cel_nome", visitante.celula_);
            ViewBag.Id = new SelectList(db.endereco, "EnderecoId", "Pais", visitante.Id);
            ViewBag.Id = new SelectList(db.telefone, "telefoneid", "Fone", visitante.Id);
            return View(visitante);
        }

        // GET: Visitante/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Visitante visitante = db.visitante.Find(id);
            if (visitante == null)
            {
                return HttpNotFound();
            }
            return View(visitante);
        }

        // POST: Visitante/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Visitante visitante = db.visitante.Find(id);
            db.pessoas.Remove(visitante);
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
