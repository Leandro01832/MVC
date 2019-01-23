using projeto.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace projeto.Controllers
{
    public class bibliaController : Controller
    {
        // GET: biblia
        public ActionResult Index()
        {
            biblia biblia = new biblia();
            ViewBag.livro = biblia.listarlivros();
            return View();
        }

        public ActionResult capitulo(string nome)
        {
            biblia biblia = new biblia();
            ViewBag.livro = biblia.listarlivros();            
            ViewBag.capitulo = biblia.capitulos(nome);
            return View();
        }


        [Authorize]
        public ActionResult versiculo(string nome, int capitulo)
        {
            biblia biblia = new biblia();
            ViewBag.livro = biblia.listarlivros();            
            ViewBag.capitulo = biblia.capitulos(nome);
            ViewBag.versiculo = biblia.listar_versiculos(nome, capitulo);
            return View();
        }

    }
}