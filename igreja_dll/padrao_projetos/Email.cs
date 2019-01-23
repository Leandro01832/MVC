using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace padrao_projetos
{
    public class Email
    {
        /// <summary>
        /// utilizando a classe singleton
        /// </summary>
        
        
        private Email()
        {

        }
        private static Email instancia;
        public string origem;
        public string destino;
        public string titulo;
        public string corpo;

        public static Email Instancia
        {
            get
            {
                if(instancia == null)
                {
                    instancia = new Email();
                }
                return instancia;
            }
        }

        public void enviaremail()
        {
            MessageBox.Show("O email foi enviado de " + origem + " para "
                + destino + ".\n O assunto é: " + titulo + " \n corpo: " + corpo);
        }
    }
}
