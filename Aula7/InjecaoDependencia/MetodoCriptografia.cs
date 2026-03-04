using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InjecaoDependencia
{
    public class MetodoCriptografia : ICripto, ICriptoInt, ICriptoGuid
    {
        public string Criptografia(string entrada) => $"[METODO]_{entrada}";
    }
}
