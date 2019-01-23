using database.banco;
using repositorioEF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using web.context;

namespace Web.Controllers
{
    public class HomeController : Controller
    {

        DB banco = new DB();

        public ActionResult Index()
        {
            return View(banco.membro_transferencia.ToList());
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}