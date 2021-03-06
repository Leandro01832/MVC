﻿using business.classes;
using database.banco;
using System.Collections.Generic;
using System.Data;

namespace banco
{
    public class bank
    {
        dadosmysql dados = new dadosmysql();
        Pessoa pes = new Pessoa();
        
        public DataTable listar(string letra)
        {
            
            DataTable data = pes.bd.lista("select * from pessoa WHERE pes_nome LIKE ('" + letra +"%') ");
            return data;
            
        }

        public DataTable buscarporid(int id)
        {
            DataTable data = pes.bd.lista("select * from pessoa inner join endereco on pes_id=end_pessoa inner join telefone on pes_id=tel_pessoa WHERE pes_id=" + id);
            return data;
        }



        public DataTable livros()
        {
            DataTable data = dados.listar("select * from livros", false, false, false, null);

            return data;
        }

        public DataTable capitulos_livros(string nome)
        {
            DataTable data = dados.listar("SELECT ver_capitulo FROM `versiculos` AS V INNER JOIN livros AS L ON L.liv_id=V.ver_liv_id WHERE liv_nome='"+nome+"' and ver_vrs_id=0 AND ver_versiculo=1", false, false, false, null);

            return data;
        }

        public DataTable versiculos_capitulos_livros(string nome, int capitulo)
        {
            DataTable data = dados.listar("SELECT ver_versiculo, ver_texto FROM `versiculos` AS V INNER JOIN livros AS L ON L.liv_id=V.ver_liv_id WHERE liv_nome='" + nome + "' and ver_vrs_id=0 AND ver_capitulo=" + capitulo.ToString(), false, false, false, null);

            return data;
            
        }

        public string layout()
        {
            string valor = "";
            DataTable data = pes.bd.lista("select * from layout where condicao=1");
            foreach (DataRow dtrow in data.Rows)
            {                
              valor = dtrow["arquivo"].ToString();              
            }
            return valor;
        }

        public DataTable loguin(string email, string senha)
        {
            DataTable data = pes.bd.lista("select * from pessoa inner join senha on pes_id=senha_pessoa where pes_email='"+email+"' and hash='"+senha+"'");

            return data;
        }



    }
}
