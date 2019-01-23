using database.banco;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace projeto.Models
{
    public class biblia
    {
        dadosmysql dados = new dadosmysql();

        public DataTable livros()
        {
            DataTable data = dados.listar("select * from livros", false, false, false, null);

            return data;
        }

        public List<livro> listarlivros()
        {
            
            DataTable datatable = livros();
            List<livro> lista_livros = new List<livro>();
            foreach (DataRow dtrow in datatable.Rows)
            {
                var livro = new livro();
                livro.Id_livro = int.Parse(dtrow["liv_id"].ToString());
                livro.Testamento = int.Parse(dtrow["liv_tes_id"].ToString());
                livro.Nome = dtrow["liv_nome"].ToString();
                livro.Posicao = int.Parse(dtrow["liv_posicao"].ToString());
                lista_livros.Add(livro);
            }

            return lista_livros;
        }

        public DataTable capitulos_livros(string nome)
        {
            DataTable data = dados.listar("SELECT ver_capitulo FROM `versiculos` AS V INNER JOIN livros AS L ON L.liv_id=V.ver_liv_id WHERE liv_nome='" + nome + "' and ver_vrs_id=0 AND ver_versiculo=1", false, false, false, null);

            return data;
        }

        public List<versiculo> capitulos(string nome)
        {
            
            DataTable datatable = capitulos_livros(nome);
            List<versiculo> capitulos = new List<versiculo>();
            foreach (DataRow dtrow in datatable.Rows)
            {
                versiculo vers = new versiculo();
                vers.Capitulo = int.Parse(dtrow["ver_capitulo"].ToString());

                capitulos.Add(vers);
            }

            return capitulos;
        }

        public DataTable versiculos_capitulos_livros(string nome, int capitulo)
        {
            DataTable data = dados.listar("SELECT ver_versiculo, ver_texto FROM `versiculos` AS V INNER JOIN livros AS L ON L.liv_id=V.ver_liv_id WHERE liv_nome='" + nome + "' and ver_vrs_id=0 AND ver_capitulo=" + capitulo.ToString(), false, false, false, null);

            return data;

        }

        public List<versiculo> listar_versiculos(string nome, int capitulo)
        {
            
            DataTable datatable = versiculos_capitulos_livros(nome, capitulo);
            List<versiculo> versiculo = new List<versiculo>();
            foreach (DataRow dtrow in datatable.Rows)
            {
                versiculo vers = new versiculo();
                vers.Numero_versiculo = int.Parse(dtrow["ver_versiculo"].ToString());
                vers.Texto = dtrow["ver_texto"].ToString();
                versiculo.Add(vers);
            }

            return versiculo;
        }

    }

    
}