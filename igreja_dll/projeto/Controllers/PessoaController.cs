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
    public class PessoaController : Controller
    {
        private DB db = new DB();

        // GET: Pessoa
        public ActionResult Index()
        {
            var pessoas = db.pessoas.Include(p => p.Cargo_Lider).Include(p => p.Cargo_Lider_Treinamento).Include(p => p.Cargo_Supervisor).Include(p => p.Cargo_Supervisor_Treinamento).Include(p => p.Celula).Include(p => p.Chamada).Include(p => p.Endereco).Include(p => p.Telefone);
            return View(pessoas.ToList());
        }

        // GET: Pessoa/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Pessoa pessoa = db.pessoas.Find(id);
            if (pessoa == null)
            {
                return HttpNotFound();
            }
            return View(pessoa);
        }

        // GET: Pessoa/Create
        public ActionResult Create()
        {
            ViewBag.Id = new SelectList(db.lider, "Liderid", "Liderid");
            ViewBag.Id = new SelectList(db.lider_treinamento, "Lidertreinamentoid", "Lidertreinamentoid");
            ViewBag.Id = new SelectList(db.supervisor, "Supervisorid", "Supervisorid");
            ViewBag.Id = new SelectList(db.supervisor_treinamento, "Supervisortreinamentoid", "Supervisortreinamentoid");
            ViewBag.celula_ = new SelectList(db.celula, "Celulaid", "Cel_nome");
            ViewBag.Id = new SelectList(db.Chamadas, "chamadaid", "chamadaid");
            ViewBag.Id = new SelectList(db.endereco, "EnderecoId", "Pais");
            ViewBag.Id = new SelectList(db.telefone, "telefoneid", "Fone");
            return View();
        }

        // POST: Pessoa/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Nome,Data_nascimento,Rg,Cpf,Estado_civil,Sexo_masculino,Sexo_feminino,Falescimento,Status,Email,Falta,celula_,Img,imgtipo,classe")] Pessoa pessoa)
        {
            if (ModelState.IsValid)
            {
                db.pessoas.Add(pessoa);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.Id = new SelectList(db.lider, "Liderid", "Liderid", pessoa.Id);
            ViewBag.Id = new SelectList(db.lider_treinamento, "Lidertreinamentoid", "Lidertreinamentoid", pessoa.Id);
            ViewBag.Id = new SelectList(db.supervisor, "Supervisorid", "Supervisorid", pessoa.Id);
            ViewBag.Id = new SelectList(db.supervisor_treinamento, "Supervisortreinamentoid", "Supervisortreinamentoid", pessoa.Id);
            ViewBag.celula_ = new SelectList(db.celula, "Celulaid", "Cel_nome", pessoa.celula_);
            ViewBag.Id = new SelectList(db.Chamadas, "chamadaid", "chamadaid", pessoa.Id);
            ViewBag.Id = new SelectList(db.endereco, "EnderecoId", "Pais", pessoa.Id);
            ViewBag.Id = new SelectList(db.telefone, "telefoneid", "Fone", pessoa.Id);
            return View(pessoa);
        }

        // GET: Pessoa/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Pessoa pessoa = db.pessoas.Find(id);
            if (pessoa == null)
            {
                return HttpNotFound();
            }
            ViewBag.Id = new SelectList(db.lider, "Liderid", "Liderid", pessoa.Id);
            ViewBag.Id = new SelectList(db.lider_treinamento, "Lidertreinamentoid", "Lidertreinamentoid", pessoa.Id);
            ViewBag.Id = new SelectList(db.supervisor, "Supervisorid", "Supervisorid", pessoa.Id);
            ViewBag.Id = new SelectList(db.supervisor_treinamento, "Supervisortreinamentoid", "Supervisortreinamentoid", pessoa.Id);
            ViewBag.celula_ = new SelectList(db.celula, "Celulaid", "Cel_nome", pessoa.celula_);
            ViewBag.Id = new SelectList(db.Chamadas, "chamadaid", "chamadaid", pessoa.Id);
            ViewBag.Id = new SelectList(db.endereco, "EnderecoId", "Pais", pessoa.Id);
            ViewBag.Id = new SelectList(db.telefone, "telefoneid", "Fone", pessoa.Id);
            return View(pessoa);
        }

        // POST: Pessoa/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Nome,Data_nascimento,Rg,Cpf,Estado_civil,Sexo_masculino,Sexo_feminino,Falescimento,Status,Email,Falta,celula_,Img,imgtipo,classe")] Pessoa pessoa)
        {
            if (ModelState.IsValid)
            {
                db.Entry(pessoa).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.Id = new SelectList(db.lider, "Liderid", "Liderid", pessoa.Id);
            ViewBag.Id = new SelectList(db.lider_treinamento, "Lidertreinamentoid", "Lidertreinamentoid", pessoa.Id);
            ViewBag.Id = new SelectList(db.supervisor, "Supervisorid", "Supervisorid", pessoa.Id);
            ViewBag.Id = new SelectList(db.supervisor_treinamento, "Supervisortreinamentoid", "Supervisortreinamentoid", pessoa.Id);
            ViewBag.celula_ = new SelectList(db.celula, "Celulaid", "Cel_nome", pessoa.celula_);
            ViewBag.Id = new SelectList(db.Chamadas, "chamadaid", "chamadaid", pessoa.Id);
            ViewBag.Id = new SelectList(db.endereco, "EnderecoId", "Pais", pessoa.Id);
            ViewBag.Id = new SelectList(db.telefone, "telefoneid", "Fone", pessoa.Id);
            return View(pessoa);
        }

        [Authorize(Roles ="Lider")]
        [Authorize(Roles = "Lider_treinamento")]
        public ActionResult Edit_falescimento(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Pessoa pessoa = db.pessoas.Find(id);
            if (pessoa == null)
            {
                return HttpNotFound();
            }

            ViewBag.email = User.Identity.GetUserName();
            ViewBag.Id = new SelectList(db.lider, "Liderid", "Liderid", pessoa.Id);
            ViewBag.Id = new SelectList(db.lider_treinamento, "Lidertreinamentoid", "Lidertreinamentoid", pessoa.Id);
            ViewBag.Id = new SelectList(db.supervisor, "Supervisorid", "Supervisorid", pessoa.Id);
            ViewBag.Id = new SelectList(db.supervisor_treinamento, "Supervisortreinamentoid", "Supervisortreinamentoid", pessoa.Id);
            ViewBag.celula_ = new SelectList(db.celula, "Celulaid", "Cel_nome", pessoa.celula_);
            ViewBag.Id = new SelectList(db.endereco, "EnderecoId", "Pais", pessoa.Id);
            ViewBag.Id = new SelectList(db.telefone, "telefoneid", "Fone", pessoa.Id);
            return View(pessoa);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize(Roles = "Lider")]
        [Authorize(Roles = "Lider_treinamento")]
        public ActionResult Edit_falescimento([Bind(Include = "Id,Nome,Data_nascimento,Rg,Cpf,Estado_civil,Sexo_masculino,Sexo_feminino,Falescimento,Status,Email,Falta,celula_,Img,imgtipo,classe,Endereco,Telefone")] Pessoa pessoa, HttpPostedFileBase upload)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    db.Entry(pessoa).State = EntityState.Modified;
                    db.SaveChanges();
                    return RedirectToAction("Index");
                }

                catch (Exception ex)
                {
                    ViewBag.email = User.Identity.GetUserName();
                    ViewBag.error = "Você já foi cadastrado. " + ex.Message;
                    ViewBag.celula_ = new SelectList(db.celula, "Celulaid", "Cel_nome");
                    return View(pessoa);
                }

            }
            ViewBag.Id = new SelectList(db.lider, "Liderid", "Liderid", pessoa.Id);
            ViewBag.Id = new SelectList(db.lider_treinamento, "Lidertreinamentoid", "Lidertreinamentoid", pessoa.Id);
            ViewBag.Id = new SelectList(db.supervisor, "Supervisorid", "Supervisorid", pessoa.Id);
            ViewBag.Id = new SelectList(db.supervisor_treinamento, "Supervisortreinamentoid", "Supervisortreinamentoid", pessoa.Id);
            ViewBag.celula_ = new SelectList(db.celula, "Celulaid", "Cel_nome", pessoa.celula_);
            ViewBag.Id = new SelectList(db.endereco, "EnderecoId", "Pais", pessoa.Id);
            ViewBag.Id = new SelectList(db.telefone, "telefoneid", "Fone", pessoa.Id);
            return View(pessoa);
        }

        [Authorize(Roles = "Lider")]
        [Authorize(Roles = "Lider_treinamento")]
        public ActionResult Edit_falta(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Pessoa pessoa = db.pessoas.Find(id);
            if (pessoa == null)
            {
                return HttpNotFound();
            }

            ViewBag.email = User.Identity.GetUserName();
            ViewBag.Id = new SelectList(db.lider, "Liderid", "Liderid", pessoa.Id);
            ViewBag.Id = new SelectList(db.lider_treinamento, "Lidertreinamentoid", "Lidertreinamentoid", pessoa.Id);
            ViewBag.Id = new SelectList(db.supervisor, "Supervisorid", "Supervisorid", pessoa.Id);
            ViewBag.Id = new SelectList(db.supervisor_treinamento, "Supervisortreinamentoid", "Supervisortreinamentoid", pessoa.Id);
            ViewBag.celula_ = new SelectList(db.celula, "Celulaid", "Cel_nome", pessoa.celula_);
            ViewBag.Id = new SelectList(db.endereco, "EnderecoId", "Pais", pessoa.Id);
            ViewBag.Id = new SelectList(db.telefone, "telefoneid", "Fone", pessoa.Id);
            return View(pessoa);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize(Roles = "Lider")]
        [Authorize(Roles = "Lider_treinamento")]
        public ActionResult Edit_falta([Bind(Include = "Id,Nome,Data_nascimento,Rg,Cpf,Estado_civil,Sexo_masculino,Sexo_feminino,Falescimento,Status,Email,Falta,celula_,Img,imgtipo,classe,Endereco,Telefone")] Pessoa pessoa, HttpPostedFileBase upload)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    pessoa.Falta += 1;
                    db.Entry(pessoa).State = EntityState.Modified;
                    db.SaveChanges();
                    return RedirectToAction("Index");
                }

                catch (Exception ex)
                {
                    ViewBag.email = User.Identity.GetUserName();
                    ViewBag.error = "Você já foi cadastrado. " + ex.Message;
                    ViewBag.celula_ = new SelectList(db.celula, "Celulaid", "Cel_nome");
                    return View(pessoa);
                }

            }
            ViewBag.Id = new SelectList(db.lider, "Liderid", "Liderid", pessoa.Id);
            ViewBag.Id = new SelectList(db.lider_treinamento, "Lidertreinamentoid", "Lidertreinamentoid", pessoa.Id);
            ViewBag.Id = new SelectList(db.supervisor, "Supervisorid", "Supervisorid", pessoa.Id);
            ViewBag.Id = new SelectList(db.supervisor_treinamento, "Supervisortreinamentoid", "Supervisortreinamentoid", pessoa.Id);
            ViewBag.celula_ = new SelectList(db.celula, "Celulaid", "Cel_nome", pessoa.celula_);
            ViewBag.Id = new SelectList(db.endereco, "EnderecoId", "Pais", pessoa.Id);
            ViewBag.Id = new SelectList(db.telefone, "telefoneid", "Fone", pessoa.Id);
            return View(pessoa);
        }

        // GET: Pessoa/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Pessoa pessoa = db.pessoas.Find(id);
            if (pessoa == null)
            {
                return HttpNotFound();
            }
            return View(pessoa);
        }

        // POST: Pessoa/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Pessoa pessoa = db.pessoas.Find(id);
            db.pessoas.Remove(pessoa);
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
