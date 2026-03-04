using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InjecaoDependencia
{
    public class ComCriptografia : ICripto
    {
        public string Criptografia(string entrada) => $"Criptografia pelo construtor_{entrada}";
    }
}
