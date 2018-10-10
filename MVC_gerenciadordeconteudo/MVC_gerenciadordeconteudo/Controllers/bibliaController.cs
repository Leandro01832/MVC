using negocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC_gerenciadordeconteudo.Controllers
{
    public class bibliaController : Controller
    {
        // GET: biblia
        public ActionResult Index(string nome)
        {
            livro livro = new livro();
            ViewBag.livro = livro.listarlivros();
            versiculo vers = new versiculo();
            ViewBag.capitulo = vers.capitulos(nome);
            return View();
        }

        public void capitulo(string nome)
        {
            livro livro = new livro();
            ViewBag.livro = livro.listarlivros();
            versiculo vers = new versiculo();
            ViewBag.capitulo = vers.capitulos(nome);
            
        }
    }
}