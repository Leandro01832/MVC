using business.classes;
using database.banco;
using MVC_gerenciadordeconteudo.Models;
using negocio;
using System;
using System.Collections.Generic;
using System.IO;
using System.Web.Mvc;
using System.Windows.Forms;
using System.Text;
using System.Security.Cryptography;

namespace MVC_gerenciadordeconteudo.Controllers
{
    public class pessoasController : Controller
    {        
        string caminho;        

        public ActionResult Index()
        {
            // Pessoa p = new Pessoa();
            BDcomum bd = new BDcomum();
            gerenciamento g = new gerenciamento();
            ViewBag.gente = g.pessoas("A");
            return View();
        }

        public ActionResult editar(int id)
        {
            gerenciamento g = new gerenciamento();
            var pessoa = g.pessoa(id);
            ViewBag.pessoa = pessoa;
            return View();
        }
        
        public ActionResult visitante()
        {                
            return View();
        }

        public ActionResult crianca()
        {
            return View();
        }

        public ActionResult membro_batismo()
        {
            return View();
        }

        public ActionResult membro_transferencia()
        {
            return View();
        }

        public ActionResult membro_aclamacao()
        {
            return View();
        }

        public ActionResult membro_reconciliacao()
        {
            return View();
        }

        [HttpPost]
        public void Criar_visitante(remessa arq)
        {
            
            
            string nomearquivo;
            if(arq.arquivo.ContentLength > 0)
            {
                nomearquivo = Path.GetFileName(arq.arquivo.FileName);
               caminho  = Path.Combine(Server.MapPath("~/Imagens"), nomearquivo);
                arq.arquivo.SaveAs(caminho);
            }           
                       
            Visitante visi = new Visitante();            
            
            visi.Nome = Request["nome"];
            visi.Rg = Request["rg"];
            visi.Cpf = Request["cpf"];
            var sexo_m = Convert.ToBoolean(Request["sexo"]);            
            visi.Sexo_feminino = !sexo_m;
            visi.Sexo_masculino = sexo_m;
            DateTime data = Convert.ToDateTime(Request["data_nascimento"]);
            string d = data.ToString("yyyy-MM-dd");
            visi.Data_nascimento = Convert.ToDateTime(d);
            visi.Estado_civil = Request["estado_civil"];
            visi.Pais = Request["pais"];
            visi.Cep = long.Parse(Request["cep"]);
            visi.Estado = Request["estado"];
            visi.Cidade = Request["cidade"];
            visi.Bairro = Request["bairro"];
            visi.Rua = Request["rua"];
            visi.Numero_casa = int.Parse(Request["numero"]);
            visi.Complemento = Request["complemento"];
            visi.Email = Request["email"];
            visi.Fone = Request["telefone"];
            visi.Celular = Request["celular"];
            visi.Whatsapp = Request["whatsapp"];
            visi.Img = caminho;
            visi.Data_visita = Convert.ToDateTime(Request["data_visita"]);
            visi.Condicao_religiosa = Request["condicao_religiosa"];
            visi.bd.montar_sql(visi.salvar(), null, null, false);
            PictureBox img = new PictureBox();
            img.ImageLocation = caminho;
            visi.bd.montar_sql("", img, null, true);
            senha s = new senha();
            s.Hash = Request["senha"];
            s.salvar();
            Response.Redirect("/pessoas");
        }

        [HttpPost]
        public void Criar_crianca(remessa arq)
        {
            string nomearquivo;
            if (arq.arquivo.ContentLength > 0)
            {
                nomearquivo = Path.GetFileName(arq.arquivo.FileName);
                caminho = Path.Combine(Server.MapPath("~/Imagens"), nomearquivo);
                arq.arquivo.SaveAs(caminho);
            }

            Crianca cri = new Crianca();
            cri.Nome = Request["nome"];
            cri.Rg = Request["rg"];
            Random random = new Random();
            cri.Cpf = random.Next(10000, 9999999).ToString();
            var sexo_m = Convert.ToBoolean(Request["sexo"]);
            cri.Sexo_feminino = !sexo_m;
            cri.Sexo_masculino = sexo_m;
            DateTime data = Convert.ToDateTime(Request["data_nascimento"]);
            string d = data.ToString("yyyy-MM-dd");
            cri.Data_nascimento = Convert.ToDateTime(d);
            cri.Estado_civil = Request["estado_civil"];
            cri.Pais = Request["pais"];
            cri.Cep = long.Parse(Request["cep"]);
            cri.Estado = Request["estado"];
            cri.Cidade = Request["cidade"];
            cri.Bairro = Request["bairro"];
            cri.Rua = Request["rua"];
            cri.Numero_casa = int.Parse(Request["numero"]);
            cri.Complemento = Request["complemento"];
            cri.Email = Request["email"];
            cri.Fone = Request["telefone"];
            cri.Celular = Request["celular"];
            cri.Whatsapp = Request["whatsapp"];
            cri.Img = Request["foto"];
            cri.Nome_mae = Request["mae"];
            cri.Nome_pai = Request["pai"];
            cri.bd.montar_sql(cri.salvar(), null, null, false);
            PictureBox img = new PictureBox();
            img.ImageLocation = caminho;
            cri.bd.montar_sql("", img, null, true);
            senha s = new senha();
            s.Hash = Request["senha"];
            s.salvar();
            Response.Redirect("/pessoas");
        }

        [HttpPost]
        public void Criar_membro_batismo(remessa arq)
        {
            string nomearquivo;
            if (arq.arquivo.ContentLength > 0)
            {
                nomearquivo = Path.GetFileName(arq.arquivo.FileName);
                caminho = Path.Combine(Server.MapPath("~/Imagens"), nomearquivo);
                arq.arquivo.SaveAs(caminho);
            }

            Membro_Batismo mem = new Membro_Batismo();
            mem.Nome = Request["nome"];
            mem.Rg = Request["rg"];
            mem.Cpf = Request["cpf"];
            var sexo_m = Convert.ToBoolean(Request["sexo"]);
            mem.Sexo_feminino = !sexo_m;
            mem.Sexo_masculino = sexo_m;
            DateTime data = Convert.ToDateTime(Request["data_nascimento"]);
            string d = data.ToString("yyyy-MM-dd");
            mem.Data_nascimento = Convert.ToDateTime(d);
            mem.Estado_civil = Request["estado_civil"];
            mem.Pais = Request["pais"];
            mem.Cep = long.Parse(Request["cep"]);
            mem.Estado = Request["estado"];
            mem.Cidade = Request["cidade"];
            mem.Bairro = Request["bairro"];
            mem.Rua = Request["rua"];
            mem.Numero_casa = int.Parse(Request["numero"]);
            mem.Complemento = Request["complemento"];
            mem.Email = Request["email"];
            mem.Fone = Request["telefone"];
            mem.Celular = Request["celular"];
            mem.Whatsapp = Request["whatsapp"];
            mem.Img = Request["foto"];
            mem.Data_batismo = int.Parse(Request["batismo"]);
            mem.bd.montar_sql(mem.salvar(), null, null, false);
            PictureBox img = new PictureBox();
            img.ImageLocation = caminho;
            mem.bd.montar_sql("", img, null, true);
            senha s = new senha();
            s.Hash = Request["senha"];
            s.salvar();
            Response.Redirect("/pessoas");
        }

        [HttpPost]
        public void Criar_membro_transferencia(remessa arq)
        {
            string nomearquivo;
            if (arq.arquivo.ContentLength > 0)
            {
                nomearquivo = Path.GetFileName(arq.arquivo.FileName);
                caminho = Path.Combine(Server.MapPath("~/Imagens"), nomearquivo);
                arq.arquivo.SaveAs(caminho);
            }

            Membro_Transferencia trans = new Membro_Transferencia();
            trans.Nome = Request["nome"];
            trans.Rg = Request["rg"];
            trans.Cpf = Request["cpf"];
            var sexo_m = Convert.ToBoolean(Request["sexo"]);
            trans.Sexo_feminino = !sexo_m;
            trans.Sexo_masculino = sexo_m;
            DateTime data = Convert.ToDateTime(Request["data_nascimento"]);
            string d = data.ToString("yyyy-MM-dd");
            trans.Data_nascimento = Convert.ToDateTime(d);
            trans.Estado_civil = Request["estado_civil"];
            trans.Pais = Request["pais"];
            trans.Cep = long.Parse(Request["cep"]);
            trans.Estado = Request["estado"];
            trans.Cidade = Request["cidade"];
            trans.Bairro = Request["bairro"];
            trans.Rua = Request["rua"];
            trans.Numero_casa = int.Parse(Request["numero"]);
            trans.Complemento = Request["complemento"];
            trans.Email = Request["email"];
            trans.Fone = Request["telefone"];
            trans.Celular = Request["celular"];
            trans.Whatsapp = Request["whatsapp"];
            trans.Img = Request["foto"];
            trans.Data_batismo = int.Parse(Request["batismo"]);
            trans.Nome_igreja_transferencia = Request["nome_igreja_transferencia"];
            trans.Estado_transferencia = Request["estado_transferencia"];
            trans.Nome_cidade_transferencia = Request["cidade_transferencia"];
            trans.bd.montar_sql(trans.salvar(), null, null, false);
            PictureBox img = new PictureBox();
            img.ImageLocation = caminho;
            trans.bd.montar_sql("", img, null, true);
            senha s = new senha();
            s.Hash = Request["senha"];
            s.salvar();
            Response.Redirect("/pessoas");
        }

        [HttpPost]
        public void Criar_membro_aclamacao(remessa arq)
        {
            string nomearquivo;
            if (arq.arquivo.ContentLength > 0)
            {
                nomearquivo = Path.GetFileName(arq.arquivo.FileName);
                caminho = Path.Combine(Server.MapPath("~/Imagens"), nomearquivo);
                arq.arquivo.SaveAs(caminho);
            }

            Membro_Aclamacao acla = new Membro_Aclamacao();
            acla.Nome = Request["nome"];
            acla.Rg = Request["rg"];
            acla.Cpf = Request["cpf"];
            var sexo_m = Convert.ToBoolean(Request["sexo"]);
            acla.Sexo_feminino = !sexo_m;
            acla.Sexo_masculino = sexo_m;
            DateTime data = Convert.ToDateTime(Request["data_nascimento"]);
            string d = data.ToString("yyyy-MM-dd");
            acla.Data_nascimento = Convert.ToDateTime(d);
            acla.Estado_civil = Request["estado_civil"];
            acla.Pais = Request["pais"];
            acla.Cep = long.Parse(Request["cep"]);
            acla.Estado = Request["estado"];
            acla.Cidade = Request["cidade"];
            acla.Bairro = Request["bairro"];
            acla.Rua = Request["rua"];
            acla.Numero_casa = int.Parse(Request["numero"]);
            acla.Complemento = Request["complemento"];
            acla.Email = Request["email"];
            acla.Fone = Request["telefone"];
            acla.Celular = Request["celular"];
            acla.Whatsapp = Request["whatsapp"];
            acla.Img = Request["foto"];
            acla.Data_batismo = int.Parse(Request["batismo"]);
            acla.Denominacao = Request["denominacao"];
            acla.bd.montar_sql(acla.salvar(), null, null, false);
            PictureBox img = new PictureBox();
            img.ImageLocation = caminho;
            acla.bd.montar_sql("", img, null, true);
            senha s = new senha();
            s.Hash = Request["senha"];
            s.salvar();
            Response.Redirect("/pessoas");
        }

        [HttpPost]
        public void Criar_membro_reconciliacao(remessa arq)
        {
            string nomearquivo;
            if (arq.arquivo.ContentLength > 0)
            {
                nomearquivo = Path.GetFileName(arq.arquivo.FileName);
                caminho = Path.Combine(Server.MapPath("~/Imagens"), nomearquivo);
                arq.arquivo.SaveAs(caminho);
            }

            Membro_Reconciliacao reco = new Membro_Reconciliacao();
            reco.Nome = Request["nome"];
            reco.Rg = Request["rg"];
            reco.Cpf = Request["cpf"];
            var sexo_m = Convert.ToBoolean(Request["sexo"]);
            reco.Sexo_feminino = !sexo_m;
            reco.Sexo_masculino = sexo_m;
            DateTime data = Convert.ToDateTime(Request["data_nascimento"]);
            string d = data.ToString("yyyy-MM-dd");
            reco.Data_nascimento = Convert.ToDateTime(d);
            reco.Estado_civil = Request["estado_civil"];
            reco.Pais = Request["pais"];
            reco.Cep = long.Parse(Request["cep"]);
            reco.Estado = Request["estado"];
            reco.Cidade = Request["cidade"];
            reco.Bairro = Request["bairro"];
            reco.Rua = Request["rua"];
            reco.Numero_casa = int.Parse(Request["numero"]);
            reco.Complemento = Request["complemento"];
            reco.Email = Request["email"];
            reco.Fone = Request["telefone"];
            reco.Celular = Request["celular"];
            reco.Whatsapp = Request["whatsapp"];
            reco.Img = Request["foto"];
            reco.Data_batismo = int.Parse(Request["batismo"]);
            reco.Data_reconciliação = int.Parse(Request["reconciliacao"]);
            reco.bd.montar_sql(reco.salvar(), null, null, false);
            PictureBox img = new PictureBox();
            img.ImageLocation = caminho;
            reco.bd.montar_sql("", img, null, true);
            senha s = new senha();
            s.Hash = Request["senha"];
            s.salvar();
            Response.Redirect("/pessoas");
        }

        [HttpPost]
        public void alterar(remessa arq)
        {
            string nomearquivo;
            if (arq.arquivo.ContentLength > 0)
            {
                nomearquivo = Path.GetFileName(arq.arquivo.FileName);
                caminho = Path.Combine(Server.MapPath("~/Imagens"), nomearquivo);
                arq.arquivo.SaveAs(caminho);
            }

            Pessoa pes = new Pessoa();
            pes.Nome = Request["nome"];
            pes.Rg = Request["rg"];
            pes.Cpf = Request["cpf"];
            var sexo_m = Convert.ToBoolean(Request["sexo"]);
            pes.Sexo_feminino = !sexo_m;
            pes.Sexo_masculino = sexo_m;
            DateTime data = Convert.ToDateTime(Request["data_nascimento"]);
            string d = data.ToString("yyyy-MM-dd");
            pes.Data_nascimento = Convert.ToDateTime(d);
            pes.Estado_civil = Request["estado_civil"];
            pes.Pais = Request["pais"];
            pes.Cep = long.Parse(Request["cep"]);
            pes.Estado = Request["estado"];
            pes.Cidade = Request["cidade"];
            pes.Bairro = Request["bairro"];
            pes.Rua = Request["rua"];
            pes.Numero_casa = int.Parse(Request["numero"]);
            pes.Complemento = Request["complemento"];
            pes.Email = Request["email"];
            pes.Fone = Request["telefone"];
            pes.Celular = Request["celular"];
            pes.Whatsapp = Request["whatsapp"];
            pes.Img = Request["foto"];           
            pes.bd.montar_sql(pes.alterar(), null, null, false);
            PictureBox img = new PictureBox();
            img.ImageLocation = caminho;
            pes.bd.montar_sql("", img, null, true);            
            Response.Redirect("/pessoas");
        }

    }
}