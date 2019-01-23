using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace projeto.Models
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
    }
}