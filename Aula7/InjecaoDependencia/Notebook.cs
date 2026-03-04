using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InjecaoDependencia
{
    public class Notebook : Produto
    {
        public Notebook(string nome, decimal preco, string descricao) : base(nome, preco, descricao)
        {
        }

        public override string ObterDescricao()
        {
            //if (Descricao == null)
            //    throw new InvalidOperationException("Notebook precisa ter descrição.");
            return Descricao ?? "Notebook sem descrição";
        }
    }
}
