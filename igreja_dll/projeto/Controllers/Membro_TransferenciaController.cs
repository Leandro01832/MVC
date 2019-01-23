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
using System.IO;
using Microsoft.AspNet.Identity;

namespace projeto.Controllers
{
    [Authorize]
    public class Membro_TransferenciaController : Controller
    {
        private DB db = new DB();

        // GET: Membro_Transferencia
        [AllowAnonymous]
        public ActionResult Index()
        {
            var pessoas = db.membro_transferencia.Include(m => m.Cargo_Lider).Include(m => m.Cargo_Lider_Treinamento).Include(m => m.Cargo_Supervisor).Include(m => m.Cargo_Supervisor_Treinamento).Include(m => m.Celula).Include(m => m.Endereco).Include(m => m.Telefone);
            return View(pessoas.ToList());
        }

        // GET: Membro_Transferencia/Details/5
        [AllowAnonymous]
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Membro_Transferencia membro_Transferencia = db.membro_transferencia.Find(id);
            if (membro_Transferencia == null)
            {
                return HttpNotFound();
            }
            return PartialView(membro_Transferencia);
        }

        // GET: Membro_Transferencia/Create
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

        // POST: Membro_Transferencia/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Nome,Data_nascimento,Rg,Cpf,Estado_civil,Sexo_masculino,Sexo_feminino,Falescimento,Status,Email,Falta,celula_,Img,imgtipo,classe,Data_batismo,Desligamento,Nome_cidade_transferencia,Estado_transferencia,Nome_igreja_transferencia,Endereco,Telefone,Chamada")] Membro_Transferencia membro_Transferencia, HttpPostedFileBase upload)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    if (upload != null && upload.ContentLength > 0)
                    {
                        membro_Transferencia.imgtipo = upload.ContentType;

                        using (var reader = new BinaryReader(upload.InputStream))
                        {
                            membro_Transferencia.Img = reader.ReadBytes(upload.ContentLength);
                        }
                    }

                    membro_Transferencia.Chamada.Numero_chamada = db.celula.First(c => c.Celulaid == membro_Transferencia.celula_).Pessoas.Count + 1;
                    membro_Transferencia.classe = "Membro por transferencia";
                    db.membro_transferencia.Add(membro_Transferencia);
                    db.SaveChanges();
                    return RedirectToAction("Index");
                }

                catch (Exception ex)
                {
                    ViewBag.email = User.Identity.GetUserName();
                    ViewBag.error = "Você já foi cadastrado. " + ex.Message;
                    ViewBag.celula_ = new SelectList(db.celula, "Celulaid", "Cel_nome");
                    return View(membro_Transferencia);
                }

            }

            ViewBag.Id = new SelectList(db.lider, "Liderid", "Liderid", membro_Transferencia.Id);
            ViewBag.Id = new SelectList(db.lider_treinamento, "Lidertreinamentoid", "Lidertreinamentoid", membro_Transferencia.Id);
            ViewBag.Id = new SelectList(db.supervisor, "Supervisorid", "Supervisorid", membro_Transferencia.Id);
            ViewBag.Id = new SelectList(db.supervisor_treinamento, "Supervisortreinamentoid", "Supervisortreinamentoid", membro_Transferencia.Id);
            ViewBag.celula_ = new SelectList(db.celula, "Celulaid", "Cel_nome", membro_Transferencia.celula_);
            ViewBag.Id = new SelectList(db.endereco, "EnderecoId", "Pais", membro_Transferencia.Id);
            ViewBag.Id = new SelectList(db.telefone, "telefoneid", "Fone", membro_Transferencia.Id);
            return View(membro_Transferencia);
        }

        // GET: Membro_Transferencia/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Membro_Transferencia membro_Transferencia = db.membro_transferencia.Find(id);
            if (membro_Transferencia == null)
            {
                return HttpNotFound();
            }

            ViewBag.email = User.Identity.GetUserName();
            ViewBag.Id = new SelectList(db.lider, "Liderid", "Liderid", membro_Transferencia.Id);
            ViewBag.Id = new SelectList(db.lider_treinamento, "Lidertreinamentoid", "Lidertreinamentoid", membro_Transferencia.Id);
            ViewBag.Id = new SelectList(db.supervisor, "Supervisorid", "Supervisorid", membro_Transferencia.Id);
            ViewBag.Id = new SelectList(db.supervisor_treinamento, "Supervisortreinamentoid", "Supervisortreinamentoid", membro_Transferencia.Id);
            ViewBag.celula_ = new SelectList(db.celula, "Celulaid", "Cel_nome", membro_Transferencia.celula_);
            ViewBag.Id = new SelectList(db.endereco, "EnderecoId", "Pais", membro_Transferencia.Id);
            ViewBag.Id = new SelectList(db.telefone, "telefoneid", "Fone", membro_Transferencia.Id);
            return View(membro_Transferencia);
        }

        // POST: Membro_Transferencia/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Nome,Data_nascimento,Rg,Cpf,Estado_civil,Sexo_masculino,Sexo_feminino,Falescimento,Status,Email,Falta,celula_,Img,imgtipo,classe,Data_batismo,Desligamento,Nome_cidade_transferencia,Estado_transferencia,Nome_igreja_transferencia,Endereco,Telefone")] Membro_Transferencia membro_Transferencia, HttpPostedFileBase upload)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    if (upload != null && upload.ContentLength > 0)
                    {
                        membro_Transferencia.imgtipo = upload.ContentType;

                        using (var reader = new BinaryReader(upload.InputStream))
                        {
                            membro_Transferencia.Img = reader.ReadBytes(upload.ContentLength);
                        }
                    }

                    membro_Transferencia.classe = "Membro por transferencia";
                    db.Entry(membro_Transferencia.Endereco).State = EntityState.Modified;
                    db.Entry(membro_Transferencia.Telefone).State = EntityState.Modified;
                    db.Entry(membro_Transferencia).State = EntityState.Modified;
                    db.SaveChanges();
                    return RedirectToAction("Index");
                }

                catch (Exception ex)
                {
                    ViewBag.email = User.Identity.GetUserName();
                    ViewBag.error = "Você já foi cadastrado. " + ex.Message;
                    ViewBag.celula_ = new SelectList(db.celula, "Celulaid", "Cel_nome");
                    return View(membro_Transferencia);
                }

            }
            ViewBag.Id = new SelectList(db.lider, "Liderid", "Liderid", membro_Transferencia.Id);
            ViewBag.Id = new SelectList(db.lider_treinamento, "Lidertreinamentoid", "Lidertreinamentoid", membro_Transferencia.Id);
            ViewBag.Id = new SelectList(db.supervisor, "Supervisorid", "Supervisorid", membro_Transferencia.Id);
            ViewBag.Id = new SelectList(db.supervisor_treinamento, "Supervisortreinamentoid", "Supervisortreinamentoid", membro_Transferencia.Id);
            ViewBag.celula_ = new SelectList(db.celula, "Celulaid", "Cel_nome", membro_Transferencia.celula_);
            ViewBag.Id = new SelectList(db.endereco, "EnderecoId", "Pais", membro_Transferencia.Id);
            ViewBag.Id = new SelectList(db.telefone, "telefoneid", "Fone", membro_Transferencia.Id);
            return View(membro_Transferencia);
        }

        // GET: Membro_Transferencia/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Membro_Transferencia membro_Transferencia = db.membro_transferencia.Find(id);
            if (membro_Transferencia == null)
            {
                return HttpNotFound();
            }
            return View(membro_Transferencia);
        }

        // POST: Membro_Transferencia/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Membro_Transferencia membro_Transferencia = db.membro_transferencia.Find(id);
            db.pessoas.Remove(membro_Transferencia);
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
