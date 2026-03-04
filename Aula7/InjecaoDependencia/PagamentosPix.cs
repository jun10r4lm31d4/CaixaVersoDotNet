using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InjecaoDependencia
{
    public class PagamentosPix : Pagamentos 
    {
        public override void ReceberPagamento(decimal valorTotal)
        {
            throw new NotImplementedException();
        }
    }
}
