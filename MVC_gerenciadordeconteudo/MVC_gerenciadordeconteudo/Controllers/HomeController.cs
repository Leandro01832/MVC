
using negocio;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC_gerenciadordeconteudo.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {            
            return View();
        }

        public ActionResult Novo()
        {
            return View();
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

        [HttpPost]
        public void logar()
        {
            banco.bank b = new banco.bank();
            senha s = new senha();
            string _email = Request["email"];
            string _senha = Request["senha"]; ;
            string valor = s.criptografadaSHA512(_senha);
            DataTable data = b.loguin(_email, valor);

            if(data.Rows.Count > 0)
            {
                foreach (DataRow dtrow in data.Rows)
                {
                    Session["id"] = dtrow["pes_id"].ToString();
                }
                Session["start"] = 1;
                ViewBag.sessao = Session["start"];
                Response.Redirect("/Home/perfil/"+Session["id"]);
            }
            else
            {
                Response.Redirect("/Home");
            }
        }

        public void sair()
        {           
          Session["start"] = 0;
            ViewBag.sessao = Session["start"];                     
          Response.Redirect("/Home");            
        }

        public ActionResult perfil(int id)
        {
            gerenciamento g = new gerenciamento();
            var pessoa = g.pessoa(id);
            ViewBag.pessoa = pessoa;
            return View();
        }
    }
}