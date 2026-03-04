using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InjecaoDependencia
{
    public class NovosAcessos
    {
        public string NomeUsuario { get; }
        public string Senha { get; }
        private readonly ICripto _cripto;

        public NovosAcessos(string nomeUsuario, string senha, ICripto cripto)
        {
            NomeUsuario = nomeUsuario;
            Senha = senha;
            _cripto = cripto;
        }

        public void imprimir() 
        {
            Console.WriteLine(_cripto.Criptografia(NomeUsuario));
            Console.WriteLine(_cripto.Criptografia(Senha));
        }
    }
}
