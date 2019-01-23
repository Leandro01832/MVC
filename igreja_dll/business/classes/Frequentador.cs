using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace View.classes
{
    class Frequentador
    {
        private bool conversão;
        private int numero_visitas;

        public bool Conversão
        {
            get
            {
                return conversão;
            }

            set
            {
                conversão = value;
            }
        }

        public int Numero_visitas
        {
            get
            {
                return numero_visitas;
            }

            set
            {
                numero_visitas = value;
            }
        }

        public Frequentador()
        {

        }
    }
}
