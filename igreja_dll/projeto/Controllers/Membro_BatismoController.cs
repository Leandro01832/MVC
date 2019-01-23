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
    public class Membro_BatismoController : Controller
    {
        private DB db = new DB();

        // GET: Membro_Batismo
        [AllowAnonymous]
        public ActionResult Index()
        {
            var pessoas = db.membro_batismo.Include(m => m.Cargo_Lider).Include(m => m.Cargo_Lider_Treinamento).Include(m => m.Cargo_Supervisor).Include(m => m.Cargo_Supervisor_Treinamento).Include(m => m.Celula).Include(m => m.Endereco).Include(m => m.Telefone);
            return View(pessoas.ToList());
        }

        // GET: Membro_Batismo/Details/5
        [AllowAnonymous]
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Membro_Batismo membro_Batismo = db.membro_batismo.Find(id);
            if (membro_Batismo == null)
            {
                return HttpNotFound();
            }
            return PartialView(membro_Batismo);
        }

        // GET: Membro_Batismo/Create
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

        // POST: Membro_Batismo/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Nome,Data_nascimento,Rg,Cpf,Estado_civil,Sexo_masculino,Sexo_feminino,Falescimento,Status,Email,Falta,celula_,Img,imgtipo,classe,Data_batismo,Desligamento,Endereco,Telefone,Chamada")] Membro_Batismo membro_Batismo, HttpPostedFileBase upload)
        {
            
            if (ModelState.IsValid)
            {
                try
                {
                    if (upload != null && upload.ContentLength > 0)
                    {
                        membro_Batismo.imgtipo = upload.ContentType;

                        using (var reader = new BinaryReader(upload.InputStream))
                        {
                            membro_Batismo.Img = reader.ReadBytes(upload.ContentLength);
                        }
                    }
                    
                    membro_Batismo.Chamada.Numero_chamada = db.celula.First(c => c.Celulaid == membro_Batismo.celula_).Pessoas.Count + 1;                                                            
                    membro_Batismo.classe = "Membro por batismo";
                    db.membro_batismo.Add(membro_Batismo);                    
                    db.SaveChanges();
                   
                    return RedirectToAction("Index");
                }

                catch (Exception ex)
                {
                    ViewBag.email = User.Identity.GetUserName();
                    ViewBag.error = "Você já foi cadastrado. " + ex.Message;
                    ViewBag.celula_ = new SelectList(db.celula, "Celulaid", "Cel_nome");
                    return View(membro_Batismo);
                }

            }

            ViewBag.Id = new SelectList(db.lider, "Liderid", "Liderid", membro_Batismo.Id);
            ViewBag.Id = new SelectList(db.lider_treinamento, "Lidertreinamentoid", "Lidertreinamentoid", membro_Batismo.Id);
            ViewBag.Id = new SelectList(db.supervisor, "Supervisorid", "Supervisorid", membro_Batismo.Id);
            ViewBag.Id = new SelectList(db.supervisor_treinamento, "Supervisortreinamentoid", "Supervisortreinamentoid", membro_Batismo.Id);
            ViewBag.celula_ = new SelectList(db.celula, "Celulaid", "Cel_nome", membro_Batismo.celula_);
            ViewBag.Id = new SelectList(db.endereco, "EnderecoId", "Pais", membro_Batismo.Id);
            ViewBag.Id = new SelectList(db.telefone, "telefoneid", "Fone", membro_Batismo.Id);
            return View(membro_Batismo);
        }

        // GET: Membro_Batismo/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Membro_Batismo membro_Batismo = db.membro_batismo.Find(id);
            if (membro_Batismo == null)
            {
                return HttpNotFound();
            }

            ViewBag.email = User.Identity.GetUserName();
            ViewBag.Id = new SelectList(db.lider, "Liderid", "Liderid", membro_Batismo.Id);
            ViewBag.Id = new SelectList(db.lider_treinamento, "Lidertreinamentoid", "Lidertreinamentoid", membro_Batismo.Id);
            ViewBag.Id = new SelectList(db.supervisor, "Supervisorid", "Supervisorid", membro_Batismo.Id);
            ViewBag.Id = new SelectList(db.supervisor_treinamento, "Supervisortreinamentoid", "Supervisortreinamentoid", membro_Batismo.Id);
            ViewBag.celula_ = new SelectList(db.celula, "Celulaid", "Cel_nome", membro_Batismo.celula_);
            ViewBag.Id = new SelectList(db.endereco, "EnderecoId", "Pais", membro_Batismo.Id);
            ViewBag.Id = new SelectList(db.telefone, "telefoneid", "Fone", membro_Batismo.Id);
            return View(membro_Batismo);
        }

        // POST: Membro_Batismo/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Nome,Data_nascimento,Rg,Cpf,Estado_civil,Sexo_masculino,Sexo_feminino,Falescimento,Status,Email,Falta,celula_,Img,imgtipo,classe,Data_batismo,Desligamento,Endereco,Telefone,upload")] Membro_Batismo membro_Batismo, HttpPostedFileBase upload)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    if (upload != null && upload.ContentLength > 0)
                    {
                        membro_Batismo.imgtipo = upload.ContentType;

                        using (var reader = new BinaryReader(upload.InputStream))
                        {
                            membro_Batismo.Img = reader.ReadBytes(upload.ContentLength);
                        }
                    }

                    membro_Batismo.classe = "Membro por batismo";
                    db.Entry(membro_Batismo.Endereco).State = EntityState.Modified;
                    db.Entry(membro_Batismo.Telefone).State = EntityState.Modified;
                    db.Entry(membro_Batismo).State = EntityState.Modified;
                    db.SaveChanges();
                    return RedirectToAction("Index");
                }

                catch (Exception ex)
                {
                    ViewBag.email = User.Identity.GetUserName();
                    ViewBag.error = "Você já foi cadastrado. " + ex.Message;
                    ViewBag.celula_ = new SelectList(db.celula, "Celulaid", "Cel_nome");
                    return View(membro_Batismo);
                }

            }
            ViewBag.Id = new SelectList(db.lider, "Liderid", "Liderid", membro_Batismo.Id);
            ViewBag.Id = new SelectList(db.lider_treinamento, "Lidertreinamentoid", "Lidertreinamentoid", membro_Batismo.Id);
            ViewBag.Id = new SelectList(db.supervisor, "Supervisorid", "Supervisorid", membro_Batismo.Id);
            ViewBag.Id = new SelectList(db.supervisor_treinamento, "Supervisortreinamentoid", "Supervisortreinamentoid", membro_Batismo.Id);
            ViewBag.celula_ = new SelectList(db.celula, "Celulaid", "Cel_nome", membro_Batismo.celula_);
            ViewBag.Id = new SelectList(db.endereco, "EnderecoId", "Pais", membro_Batismo.Id);
            ViewBag.Id = new SelectList(db.telefone, "telefoneid", "Fone", membro_Batismo.Id);
            return View(membro_Batismo);
        }

        // GET: Membro_Batismo/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Membro_Batismo membro_Batismo = db.membro_batismo.Find(id);
            if (membro_Batismo == null)
            {
                return HttpNotFound();
            }
            return View(membro_Batismo);
        }

        // POST: Membro_Batismo/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Membro_Batismo membro_Batismo = db.membro_batismo.Find(id);

            db.pessoas.Remove(membro_Batismo);
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
