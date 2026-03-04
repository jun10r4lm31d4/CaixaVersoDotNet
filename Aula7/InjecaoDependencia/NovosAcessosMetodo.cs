using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InjecaoDependencia
{
    public class NovosAcessosMetodo
    {
        private ICripto? _cripto;

        public string NomeUsuario { get; }
        public string Senha { get; }


        public NovosAcessosMetodo(string nomeUsuario, string senha)
        {
            NomeUsuario = nomeUsuario;
            Senha = senha;
        }

        public void DefinirCripto(ICripto cripto) => _cripto = cripto;

        public void Imprimir()
        {
            if (_cripto is null)
            {
                throw new InvalidOperationException("Cripto não definida.");
            }
            Console.WriteLine(_cripto.Criptografia(NomeUsuario));
            Console.WriteLine(_cripto.Criptografia(Senha));
        }
    }
}
