using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InjecaoDependencia
{
    public class Carrinho
    {
        private readonly List<Produto> _produtos = new();

        public void AdicionarProduto(Produto produto) => _produtos.Add(produto);
        public void RemoverProduto(Produto produto) => _produtos.Remove(produto);

        public decimal CalcularTotal()
        {
            //Regra de negócio do pedido
            return _produtos.Sum(p => p.Preco);
        }

        public void FinalizarCompra(string formaPagamento)
        {

        }

        public void ExibirProduto(Produto produto)
        {
            Console.WriteLine(produto.ObterDescricao());
        }
    }
}
