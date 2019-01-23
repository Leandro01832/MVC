using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web.Mvc;
using business.classes;
using repositorioEF;
using Microsoft.AspNet.Identity;

namespace projeto.Controllers
{
    [Authorize]
    public class Cargo_LiderController : Controller
    {
        private DB db = new DB();

        // GET: Cargo_Lider
        [AllowAnonymous]
        public ActionResult Index()
        {
            var lider = db.lider.Include(c => c.Pessoa);
            return View(lider.ToList());
        }

        // GET: Cargo_Lider/Details/5
        [AllowAnonymous]
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Cargo_Lider cargo_Lider = db.lider.Find(id);
            if (cargo_Lider == null)
            {
                return HttpNotFound();
            }
            return PartialView(cargo_Lider);
        }

        // GET: Cargo_Lider/Create
        public ActionResult Create()
        {
            ViewBag.Liderid = new SelectList(db.pessoas, "Id", "Nome");
            return View();
        }

        // POST: Cargo_Lider/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Liderid")] Cargo_Lider cargo_Lider)
        {
            if (ModelState.IsValid)
            {
                var email = User.Identity.GetUserName();
                var id = db.pessoas.First(e => e.Email == email).Id;
                cargo_Lider.Liderid = id;
                db.lider.Add(cargo_Lider);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.Liderid = new SelectList(db.pessoas, "Id", "Nome", cargo_Lider.Liderid);
            return View(cargo_Lider);
        }

        // GET: Cargo_Lider/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Cargo_Lider cargo_Lider = db.lider.Find(id);
            if (cargo_Lider == null)
            {
                return HttpNotFound();
            }
            ViewBag.Liderid = new SelectList(db.pessoas, "Id", "Nome", cargo_Lider.Liderid);
            return View(cargo_Lider);
        }

        // POST: Cargo_Lider/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Liderid")] Cargo_Lider cargo_Lider)
        {
            if (ModelState.IsValid)
            {
                db.Entry(cargo_Lider).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.Liderid = new SelectList(db.pessoas, "Id", "Nome", cargo_Lider.Liderid);
            return View(cargo_Lider);
        }

        // GET: Cargo_Lider/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Cargo_Lider cargo_Lider = db.lider.Find(id);
            if (cargo_Lider == null)
            {
                return HttpNotFound();
            }
            return View(cargo_Lider);
        }

        // POST: Cargo_Lider/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Cargo_Lider cargo_Lider = db.lider.Find(id);
            db.lider.Remove(cargo_Lider);
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
