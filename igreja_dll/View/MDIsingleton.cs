using View.form;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace View
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

