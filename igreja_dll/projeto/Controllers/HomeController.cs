
using repositorioEF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Microsoft.AspNet.Identity;

namespace projeto.Controllers
{
    [Authorize]
    public class HomeController : Controller
    {
        public HomeController()
        {

        }

        DB db = new DB();

        [AllowAnonymous]
        public ActionResult Index()
        {
            return View();
        }

        [Authorize]
        public ActionResult Perfil()
        {
            try
            {
                ViewBag.email = User.Identity.GetUserName();
                string email = ViewBag.email;
                ViewBag.id = db.pessoas.First(p => p.Email == email).Id;
                ViewBag.classe = db.pessoas.First(p => p.Email == email).classe;
            }
            catch (InvalidOperationException)
            {
                ViewBag.condicao = false;                
                return View();
            }

            ViewBag.condicao = true;
            return View();
        }

        public ActionResult Contact()
        {
            return View();
        }

        public ActionResult About()
        {
            return View();
        }




    }
}
