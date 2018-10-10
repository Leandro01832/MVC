using business.classes;

using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace database
{
   public class banco
    {
        public DataTable listar()
        {
            Pessoa pes = new Pessoa();
            
            DataTable data = pes.bd.lista("select * from pessoa");
            return data;

        }
        

    }
}
