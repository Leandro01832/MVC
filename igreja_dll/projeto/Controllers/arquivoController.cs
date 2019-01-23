using business.classes;
using repositorioEF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace projeto.Controllers
{
    public class arquivoController : Controller
    {
        private DB db = new DB();
        // GET: arquivo
        public ActionResult Exibir(int id)
        {
            Pessoa pessoa = db.pessoas.Find(id);
            return File(pessoa.Img, pessoa.imgtipo);
        }
    }
}