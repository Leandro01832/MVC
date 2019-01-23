using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace projeto.Models
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



    }
}