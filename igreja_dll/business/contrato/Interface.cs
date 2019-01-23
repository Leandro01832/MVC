using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace business.contrato
{
   public interface Interface<T> where T : class
    {
        void salvar(T entidade);
        void excluir(T entidade);
        IEnumerable<T> listartodos();
        T listarporid(int id);
    }
}
