using igreja2.form;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace igreja2
{
    class MDIsingleton
    {
        private MDIsingleton()
        {

        }

        private static MDIParent instancia;

        public static MDIParent InstanciaMDI()
        {
            {
                if (instancia == null)
                {
                     instancia = new MDIParent();
                    return instancia;
                }
                return instancia;

            }
        }
    }
}

