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
    public class CriancaController : Controller
    {
        private DB db = new DB();

        // GET: Crianca
        [AllowAnonymous]
        public ActionResult Index()
        {
            var pessoas = db.crianca.Include(c => c.Cargo_Lider).Include(c => c.Cargo_Lider_Treinamento).Include(c => c.Cargo_Supervisor).Include(c => c.Cargo_Supervisor_Treinamento).Include(c => c.Celula).Include(c => c.Endereco).Include(c => c.Telefone);
            return View(pessoas.ToList());
        }

        // GET: Crianca/Details/5
        [AllowAnonymous]
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Crianca crianca = db.crianca.Include(c => c.Ministerios).First(c => c.Id == id);
            if (crianca == null)
            {
                return HttpNotFound();
            }
            return PartialView(crianca);
        }

        // GET: Crianca/Create
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

        // POST: Crianca/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Nome,Data_nascimento,Rg,Cpf,Estado_civil,Sexo_masculino,Sexo_feminino,Falescimento,Status,Email,Falta,celula_,Img,imgtipo,classe,Nome_pai,Nome_mae,Endereco,Telefone,Chamada")] Crianca crianca, HttpPostedFileBase upload)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    if (upload != null && upload.ContentLength > 0)
                    {

                        crianca.imgtipo = upload.ContentType;

                        using (var reader = new BinaryReader(upload.InputStream))
                        {
                            crianca.Img = reader.ReadBytes(upload.ContentLength);
                        }
                    }

                    crianca.Chamada.Numero_chamada = db.celula.First(c => c.Celulaid == crianca.celula_).Pessoas.Count + 1;
                    crianca.classe = "Crianca";
                    db.crianca.Add(crianca);
                    db.SaveChanges();
                    return RedirectToAction("Index");
                }

                catch (Exception ex)
                {
                    ViewBag.email = User.Identity.GetUserName();
                    ViewBag.error = "Você já foi cadastrado. " + ex.Message;
                    ViewBag.celula_ = new SelectList(db.celula, "Celulaid", "Cel_nome");
                    return View(crianca);
                }
            
            }

            ViewBag.Id = new SelectList(db.lider, "Liderid", "Liderid", crianca.Id);
            ViewBag.Id = new SelectList(db.lider_treinamento, "Lidertreinamentoid", "Lidertreinamentoid", crianca.Id);
            ViewBag.Id = new SelectList(db.supervisor, "Supervisorid", "Supervisorid", crianca.Id);
            ViewBag.Id = new SelectList(db.supervisor_treinamento, "Supervisortreinamentoid", "Supervisortreinamentoid", crianca.Id);
            ViewBag.celula_ = new SelectList(db.celula, "Celulaid", "Cel_nome", crianca.celula_);
            ViewBag.Id = new SelectList(db.endereco, "EnderecoId", "Pais", crianca.Id);
            ViewBag.Id = new SelectList(db.telefone, "telefoneid", "Fone", crianca.Id);
            return View(crianca);
        }

        // GET: Crianca/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Crianca crianca = db.crianca.Find(id);
            if (crianca == null)
            {
                return HttpNotFound();
            }

            ViewBag.email = User.Identity.GetUserName();
            ViewBag.Id = new SelectList(db.lider, "Liderid", "Liderid", crianca.Id);
            ViewBag.Id = new SelectList(db.lider_treinamento, "Lidertreinamentoid", "Lidertreinamentoid", crianca.Id);
            ViewBag.Id = new SelectList(db.supervisor, "Supervisorid", "Supervisorid", crianca.Id);
            ViewBag.Id = new SelectList(db.supervisor_treinamento, "Supervisortreinamentoid", "Supervisortreinamentoid", crianca.Id);
            ViewBag.celula_ = new SelectList(db.celula, "Celulaid", "Cel_nome", crianca.celula_);
            ViewBag.Id = new SelectList(db.endereco, "EnderecoId", "Pais", crianca.Id);
            ViewBag.Id = new SelectList(db.telefone, "telefoneid", "Fone", crianca.Id);
            return View(crianca);
        }

        // POST: Crianca/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Nome,Data_nascimento,Rg,Cpf,Estado_civil,Sexo_masculino,Sexo_feminino,Falescimento,Status,Email,Falta,celula_,Img,imgtipo,classe,Nome_pai,Nome_mae,Endereco,Telefone")] Crianca crianca, HttpPostedFileBase upload)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    if (upload != null && upload.ContentLength > 0)
                    {
                        crianca.imgtipo = upload.ContentType;

                        using (var reader = new BinaryReader(upload.InputStream))
                        {
                            crianca.Img = reader.ReadBytes(upload.ContentLength);
                        }
                    }

                    crianca.classe = "Crianca";
                    db.Entry(crianca.Endereco).State = EntityState.Modified;
                    db.Entry(crianca.Telefone).State = EntityState.Modified;
                    db.Entry(crianca).State = EntityState.Modified;
                    db.SaveChanges();
                    return RedirectToAction("Index");
                }

                catch (Exception ex)
                {
                    ViewBag.email = User.Identity.GetUserName();
                    ViewBag.error = "Você já foi cadastrado. " + ex.Message;
                    ViewBag.celula_ = new SelectList(db.celula, "Celulaid", "Cel_nome");
                    return View(crianca);
                }

            }
            ViewBag.Id = new SelectList(db.lider, "Liderid", "Liderid", crianca.Id);
            ViewBag.Id = new SelectList(db.lider_treinamento, "Lidertreinamentoid", "Lidertreinamentoid", crianca.Id);
            ViewBag.Id = new SelectList(db.supervisor, "Supervisorid", "Supervisorid", crianca.Id);
            ViewBag.Id = new SelectList(db.supervisor_treinamento, "Supervisortreinamentoid", "Supervisortreinamentoid", crianca.Id);
            ViewBag.celula_ = new SelectList(db.celula, "Celulaid", "Cel_nome", crianca.celula_);
            ViewBag.Id = new SelectList(db.endereco, "EnderecoId", "Pais", crianca.Id);
            ViewBag.Id = new SelectList(db.telefone, "telefoneid", "Fone", crianca.Id);
            return View(crianca);
        }

        // GET: Crianca/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Crianca crianca = db.crianca.Find(id);
            if (crianca == null)
            {
                return HttpNotFound();
            }
            return View(crianca);
        }

        // POST: Crianca/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Crianca crianca = db.crianca.Find(id);
            db.pessoas.Remove(crianca);
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
