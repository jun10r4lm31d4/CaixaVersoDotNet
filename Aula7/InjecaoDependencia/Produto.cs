using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InjecaoDependencia
{
    public class Produto
    {
        public string Nome { get; }
        public decimal Preco { get; }
        public string? Descricao { get; set; }

        private readonly IDbConnection _conexao;

        public Produto(string nome, decimal preco, string descricao, IDbConnection conexao)
        {
            Nome = nome;
            Preco = preco;
            Descricao = descricao;
        }

        public virtual string ObterDescricao()
        {
            return Descricao ?? "Sem Descricao";
        }
    }
}
