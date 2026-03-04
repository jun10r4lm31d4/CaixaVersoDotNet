using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InjecaoDependencia
{
    public class PropriedadeCriptografia : ICripto
    {
        public string Criptografia(string entrada) => $"[PROPRIEDADE]_{entrada}";
    }
}
