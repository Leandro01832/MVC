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
        public ActionResult Index()
        {
            livro livro = new livro();
            ViewBag.livro = livro.listarlivros();
            //versiculo vers = new versiculo();
            //ViewBag.capitulo = vers.capitulos(nome);            
            return View();
        }

        public ActionResult capitulo(string nome)
        {
            livro livro = new livro();
            ViewBag.livro = livro.listarlivros();
            versiculo vers = new versiculo();
            ViewBag.capitulo = vers.capitulos(nome);            
            return View();
        }

        public ActionResult versiculo(string nome, int capitulo)
        {
            livro livro = new livro();
            ViewBag.livro = livro.listarlivros();
            versiculo vers = new versiculo();
            ViewBag.capitulo = vers.capitulos(nome);
            ViewBag.versiculo = vers.listar_versiculos(nome, capitulo);
            return View();
        }

    }
}