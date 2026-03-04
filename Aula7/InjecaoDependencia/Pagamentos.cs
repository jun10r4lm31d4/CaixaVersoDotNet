using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InjecaoDependencia
{
    public abstract class Pagamentos
    {
        public abstract void ReceberPagamento(decimal valorTotal);
    }
}
