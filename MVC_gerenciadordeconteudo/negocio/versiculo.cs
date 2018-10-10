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
    }
}
