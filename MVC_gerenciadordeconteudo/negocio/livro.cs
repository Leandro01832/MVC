using banco;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace negocio
{
   public class livro
    {
        private int id_livro;
        private string nome;
        private int posicao;
        private int testamento;
        

        public int Id_livro
        {
            get
            {
                return id_livro;
            }

            set
            {
                id_livro = value;
            }
        }

        public string Nome
        {
            get
            {
                return nome;
            }

            set
            {
                nome = value;
            }
        }

        public int Posicao
        {
            get
            {
                return posicao;
            }

            set
            {
                posicao = value;
            }
        }

        public int Testamento
        {
            get
            {
                return testamento;
            }

            set
            {
                testamento = value;
            }
        }

       

        public List<livro> listarlivros()
        {
            bank b = new bank();
            DataTable datatable = b.livros();
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

      
    }
}
