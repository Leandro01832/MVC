using banco;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace negocio
{
   public class versiculo
    {
        private int capitulo;
        private int numero_versiculo;
        private string texto;

        public int Capitulo
        {
            get
            {
                return capitulo;
            }

            set
            {
                capitulo = value;
            }
        }

        public int Numero_versiculo
        {
            get
            {
                return numero_versiculo;
            }

            set
            {
                numero_versiculo = value;
            }
        }

        public string Texto
        {
            get
            {
                return texto;
            }

            set
            {
                texto = value;
            }
        }

        public List<versiculo> capitulos(string nome)
        {
            bank b = new bank();
            DataTable datatable = b.capitulos_livros(nome);
            List<versiculo> capitulos = new List<versiculo>();
            foreach (DataRow dtrow in datatable.Rows)
            {
                versiculo vers = new versiculo();
               vers.Capitulo  = int.Parse(dtrow["ver_capitulo"].ToString());

                capitulos.Add(vers);
            }

            return capitulos;
        }

        public List<versiculo> listar_versiculos(string nome, int capitulo)
        {
            bank b = new bank();
            DataTable datatable = b.versiculos_capitulos_livros(nome, capitulo);
            List<versiculo> versiculo = new List<versiculo>();
            foreach (DataRow dtrow in datatable.Rows)
            {
                versiculo vers = new versiculo();                
                vers.numero_versiculo = int.Parse(dtrow["ver_versiculo"].ToString());
                vers.Texto = dtrow["ver_texto"].ToString();
                versiculo.Add(vers);
            }

            return versiculo;
        }
    }
}
