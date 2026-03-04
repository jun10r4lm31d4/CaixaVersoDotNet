using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InjecaoDependencia
{
    public class NovosAcessosPropriedade
    {
        public ICripto? PropriedadeCripto { get; set; }

        public void Imprimir(string login, string senha)
        {
            if (PropriedadeCripto is null)
            {
                throw new InvalidOperationException("Cripto não definida.");
            }
            Console.WriteLine(PropriedadeCripto.Criptografia(login));
            Console.WriteLine(PropriedadeCripto.Criptografia(senha));
        }
    }
}
