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
    public class Membro_ReconciliacaoController : Controller
    {
        private DB db = new DB();

        // GET: Membro_Reconciliacao
        [AllowAnonymous]
        public ActionResult Index()
        {
            var pessoas = db.membro_reconciliacao.Include(m => m.Cargo_Lider).Include(m => m.Cargo_Lider_Treinamento).Include(m => m.Cargo_Supervisor).Include(m => m.Cargo_Supervisor_Treinamento).Include(m => m.Celula).Include(m => m.Endereco).Include(m => m.Telefone);
            return View(pessoas.ToList());
        }

        // GET: Membro_Reconciliacao/Details/5
        [AllowAnonymous]
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Membro_Reconciliacao membro_Reconciliacao = db.membro_reconciliacao.Find(id);
            if (membro_Reconciliacao == null)
            {
                return HttpNotFound();
            }
            return PartialView(membro_Reconciliacao);
        }

        // GET: Membro_Reconciliacao/Create
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

        // POST: Membro_Reconciliacao/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Nome,Data_nascimento,Rg,Cpf,Estado_civil,Sexo_masculino,Sexo_feminino,Falescimento,Status,Email,Falta,celula_,Img,imgtipo,classe,Data_batismo,Desligamento,Data_reconciliacao,Endereco,Telefone,Chamada")] Membro_Reconciliacao membro_Reconciliacao, HttpPostedFileBase upload)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    if (upload != null && upload.ContentLength > 0)
                    {
                        membro_Reconciliacao.imgtipo = upload.ContentType;

                        using (var reader = new BinaryReader(upload.InputStream))
                        {
                            membro_Reconciliacao.Img = reader.ReadBytes(upload.ContentLength);
                        }
                    }

                    membro_Reconciliacao.Chamada.Numero_chamada = db.celula.First(c => c.Celulaid == membro_Reconciliacao.celula_).Pessoas.Count + 1;
                    membro_Reconciliacao.classe = "Membro por reconciliacao";
                    db.pessoas.Add(membro_Reconciliacao);
                    db.SaveChanges();
                    return RedirectToAction("Index");
                }

                catch (Exception ex)
                {
                    ViewBag.email = User.Identity.GetUserName();
                    ViewBag.error = "Você já foi cadastrado. " + ex.Message;
                    ViewBag.celula_ = new SelectList(db.celula, "Celulaid", "Cel_nome");
                    return View(membro_Reconciliacao);
                }

            }

            ViewBag.Id = new SelectList(db.lider, "Liderid", "Liderid", membro_Reconciliacao.Id);
            ViewBag.Id = new SelectList(db.lider_treinamento, "Lidertreinamentoid", "Lidertreinamentoid", membro_Reconciliacao.Id);
            ViewBag.Id = new SelectList(db.supervisor, "Supervisorid", "Supervisorid", membro_Reconciliacao.Id);
            ViewBag.Id = new SelectList(db.supervisor_treinamento, "Supervisortreinamentoid", "Supervisortreinamentoid", membro_Reconciliacao.Id);
            ViewBag.celula_ = new SelectList(db.celula, "Celulaid", "Cel_nome", membro_Reconciliacao.celula_);
            ViewBag.Id = new SelectList(db.endereco, "EnderecoId", "Pais", membro_Reconciliacao.Id);
            ViewBag.Id = new SelectList(db.telefone, "telefoneid", "Fone", membro_Reconciliacao.Id);
            return View(membro_Reconciliacao);
        }

        // GET: Membro_Reconciliacao/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Membro_Reconciliacao membro_Reconciliacao = db.membro_reconciliacao.Find(id);
            if (membro_Reconciliacao == null)
            {
                return HttpNotFound();
            }

            ViewBag.email = User.Identity.GetUserName();
            ViewBag.Id = new SelectList(db.lider, "Liderid", "Liderid", membro_Reconciliacao.Id);
            ViewBag.Id = new SelectList(db.lider_treinamento, "Lidertreinamentoid", "Lidertreinamentoid", membro_Reconciliacao.Id);
            ViewBag.Id = new SelectList(db.supervisor, "Supervisorid", "Supervisorid", membro_Reconciliacao.Id);
            ViewBag.Id = new SelectList(db.supervisor_treinamento, "Supervisortreinamentoid", "Supervisortreinamentoid", membro_Reconciliacao.Id);
            ViewBag.celula_ = new SelectList(db.celula, "Celulaid", "Cel_nome", membro_Reconciliacao.celula_);
            ViewBag.Id = new SelectList(db.endereco, "EnderecoId", "Pais", membro_Reconciliacao.Id);
            ViewBag.Id = new SelectList(db.telefone, "telefoneid", "Fone", membro_Reconciliacao.Id);
            return View(membro_Reconciliacao);
        }

        // POST: Membro_Reconciliacao/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Nome,Data_nascimento,Rg,Cpf,Estado_civil,Sexo_masculino,Sexo_feminino,Falescimento,Status,Email,Falta,celula_,Img,imgtipo,classe,Data_batismo,Desligamento,Data_reconciliacao,Endereco,Telefone")] Membro_Reconciliacao membro_Reconciliacao, HttpPostedFileBase upload)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    if (upload != null && upload.ContentLength > 0)
                    {
                        membro_Reconciliacao.imgtipo = upload.ContentType;

                        using (var reader = new BinaryReader(upload.InputStream))
                        {
                            membro_Reconciliacao.Img = reader.ReadBytes(upload.ContentLength);
                        }
                    }

                    membro_Reconciliacao.classe = "Membro por reconciliacao";
                    db.Entry(membro_Reconciliacao.Endereco).State = EntityState.Modified;
                    db.Entry(membro_Reconciliacao.Telefone).State = EntityState.Modified;
                    db.Entry(membro_Reconciliacao).State = EntityState.Modified;
                    db.SaveChanges();
                    return RedirectToAction("Index");
                }

                catch (Exception ex)
                {
                    ViewBag.email = User.Identity.GetUserName();
                    ViewBag.error = "Você já foi cadastrado. " + ex.Message;
                    ViewBag.celula_ = new SelectList(db.celula, "Celulaid", "Cel_nome");
                    return View(membro_Reconciliacao);
                }

            }
            ViewBag.Id = new SelectList(db.lider, "Liderid", "Liderid", membro_Reconciliacao.Id);
            ViewBag.Id = new SelectList(db.lider_treinamento, "Lidertreinamentoid", "Lidertreinamentoid", membro_Reconciliacao.Id);
            ViewBag.Id = new SelectList(db.supervisor, "Supervisorid", "Supervisorid", membro_Reconciliacao.Id);
            ViewBag.Id = new SelectList(db.supervisor_treinamento, "Supervisortreinamentoid", "Supervisortreinamentoid", membro_Reconciliacao.Id);
            ViewBag.celula_ = new SelectList(db.celula, "Celulaid", "Cel_nome", membro_Reconciliacao.celula_);
            ViewBag.Id = new SelectList(db.endereco, "EnderecoId", "Pais", membro_Reconciliacao.Id);
            ViewBag.Id = new SelectList(db.telefone, "telefoneid", "Fone", membro_Reconciliacao.Id);
            return View(membro_Reconciliacao);
        }

        // GET: Membro_Reconciliacao/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Membro_Reconciliacao membro_Reconciliacao = db.membro_reconciliacao.Find(id);
            if (membro_Reconciliacao == null)
            {
                return HttpNotFound();
            }
            return View(membro_Reconciliacao);
        }

        // POST: Membro_Reconciliacao/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Membro_Reconciliacao membro_Reconciliacao = db.membro_reconciliacao.Find(id);
            db.membro_reconciliacao.Remove(membro_Reconciliacao);
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
