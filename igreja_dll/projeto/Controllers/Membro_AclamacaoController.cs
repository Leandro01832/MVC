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
    public class Membro_AclamacaoController : Controller
    {
        private DB db = new DB();

        // GET: Membro_Aclamacao
        [AllowAnonymous]
        public ActionResult Index()
        {
            var pessoas = db.membro_aclamacao.Include(m => m.Cargo_Lider).Include(m => m.Cargo_Lider_Treinamento).Include(m => m.Cargo_Supervisor).Include(m => m.Cargo_Supervisor_Treinamento).Include(m => m.Celula).Include(m => m.Endereco).Include(m => m.Telefone);
            return View(pessoas.ToList());
        }

        // GET: Membro_Aclamacao/Details/5
        [AllowAnonymous]
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Membro_Aclamacao membro_Aclamacao = db.membro_aclamacao.Find(id);
            if (membro_Aclamacao == null)
            {
                return HttpNotFound();
            }
            return PartialView(membro_Aclamacao);
        }

        // GET: Membro_Aclamacao/Create
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

        // POST: Membro_Aclamacao/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Nome,Data_nascimento,Rg,Cpf,Estado_civil,Sexo_masculino,Sexo_feminino,Falescimento,Status,Email,Falta,celula_,Img,imgtipo,classe,Data_batismo,Desligamento,Denominacao,Endereco,Telefone,Chamada")] Membro_Aclamacao membro_Aclamacao, HttpPostedFileBase upload)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    if (upload != null && upload.ContentLength > 0)
                    {
                        membro_Aclamacao.imgtipo = upload.ContentType;

                        using (var reader = new BinaryReader(upload.InputStream))
                        {
                            membro_Aclamacao.Img = reader.ReadBytes(upload.ContentLength);
                        }
                    }

                    membro_Aclamacao.Chamada.Numero_chamada = db.celula.First(c => c.Celulaid == membro_Aclamacao.celula_).Pessoas.Count + 1;
                    membro_Aclamacao.classe = "Membro por aclamacao";
                    db.membro_aclamacao.Add(membro_Aclamacao);
                    db.SaveChanges();
                    return RedirectToAction("Index");
                }

                catch (Exception ex)
                {
                    ViewBag.email = User.Identity.GetUserName();
                    ViewBag.error = "Você já foi cadastrado. " + ex.Message;
                    ViewBag.celula_ = new SelectList(db.celula, "Celulaid", "Cel_nome");
                    return View(membro_Aclamacao);
                }

            }

            ViewBag.Id = new SelectList(db.lider, "Liderid", "Liderid", membro_Aclamacao.Id);
            ViewBag.Id = new SelectList(db.lider_treinamento, "Lidertreinamentoid", "Lidertreinamentoid", membro_Aclamacao.Id);
            ViewBag.Id = new SelectList(db.supervisor, "Supervisorid", "Supervisorid", membro_Aclamacao.Id);
            ViewBag.Id = new SelectList(db.supervisor_treinamento, "Supervisortreinamentoid", "Supervisortreinamentoid", membro_Aclamacao.Id);
            ViewBag.celula_ = new SelectList(db.celula, "Celulaid", "Cel_nome", membro_Aclamacao.celula_);
            ViewBag.Id = new SelectList(db.endereco, "EnderecoId", "Pais", membro_Aclamacao.Id);
            ViewBag.Id = new SelectList(db.telefone, "telefoneid", "Fone", membro_Aclamacao.Id);
            return View(membro_Aclamacao);
        }

        // GET: Membro_Aclamacao/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Membro_Aclamacao membro_Aclamacao = db.membro_aclamacao.Find(id);
            if (membro_Aclamacao == null)
            {
                return HttpNotFound();
            }

            ViewBag.email = User.Identity.GetUserName();
            ViewBag.Id = new SelectList(db.lider, "Liderid", "Liderid", membro_Aclamacao.Id);
            ViewBag.Id = new SelectList(db.lider_treinamento, "Lidertreinamentoid", "Lidertreinamentoid", membro_Aclamacao.Id);
            ViewBag.Id = new SelectList(db.supervisor, "Supervisorid", "Supervisorid", membro_Aclamacao.Id);
            ViewBag.Id = new SelectList(db.supervisor_treinamento, "Supervisortreinamentoid", "Supervisortreinamentoid", membro_Aclamacao.Id);
            ViewBag.celula_ = new SelectList(db.celula, "Celulaid", "Cel_nome", membro_Aclamacao.celula_);
            ViewBag.Id = new SelectList(db.endereco, "EnderecoId", "Pais", membro_Aclamacao.Id);
            ViewBag.Id = new SelectList(db.telefone, "telefoneid", "Fone", membro_Aclamacao.Id);
            return View(membro_Aclamacao);
        }

        // POST: Membro_Aclamacao/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Nome,Data_nascimento,Rg,Cpf,Estado_civil,Sexo_masculino,Sexo_feminino,Falescimento,Status,Email,Falta,celula_,Img,imgtipo,classe,Data_batismo,Desligamento,Denominacao")] Membro_Aclamacao membro_Aclamacao, HttpPostedFileBase upload)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    if (upload != null && upload.ContentLength > 0)
                    {
                        membro_Aclamacao.imgtipo = upload.ContentType;

                        using (var reader = new BinaryReader(upload.InputStream))
                        {
                            membro_Aclamacao.Img = reader.ReadBytes(upload.ContentLength);
                        }
                    }

                    membro_Aclamacao.classe = "Membro por aclamacao";
                    db.Entry(membro_Aclamacao.Endereco).State = EntityState.Modified;
                    db.Entry(membro_Aclamacao.Telefone).State = EntityState.Modified;
                    db.Entry(membro_Aclamacao).State = EntityState.Modified;
                    db.SaveChanges();
                    return RedirectToAction("Index");
                }

                catch (Exception ex)
                {
                    ViewBag.email = User.Identity.GetUserName();
                    ViewBag.error = "Você já foi cadastrado. " + ex.Message;
                    ViewBag.celula_ = new SelectList(db.celula, "Celulaid", "Cel_nome");
                    return View(membro_Aclamacao);
                }

            }
            ViewBag.Id = new SelectList(db.lider, "Liderid", "Liderid", membro_Aclamacao.Id);
            ViewBag.Id = new SelectList(db.lider_treinamento, "Lidertreinamentoid", "Lidertreinamentoid", membro_Aclamacao.Id);
            ViewBag.Id = new SelectList(db.supervisor, "Supervisorid", "Supervisorid", membro_Aclamacao.Id);
            ViewBag.Id = new SelectList(db.supervisor_treinamento, "Supervisortreinamentoid", "Supervisortreinamentoid", membro_Aclamacao.Id);
            ViewBag.celula_ = new SelectList(db.celula, "Celulaid", "Cel_nome", membro_Aclamacao.celula_);
            ViewBag.Id = new SelectList(db.endereco, "EnderecoId", "Pais", membro_Aclamacao.Id);
            ViewBag.Id = new SelectList(db.telefone, "telefoneid", "Fone", membro_Aclamacao.Id);
            return View(membro_Aclamacao);
        }

        // GET: Membro_Aclamacao/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Membro_Aclamacao membro_Aclamacao = db.membro_aclamacao.Find(id);
            if (membro_Aclamacao == null)
            {
                return HttpNotFound();
            }
            return View(membro_Aclamacao);
        }

        // POST: Membro_Aclamacao/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Membro_Aclamacao membro_Aclamacao = db.membro_aclamacao.Find(id);
            db.membro_aclamacao.Remove(membro_Aclamacao);
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
