using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InjecaoDependencia
{
    public interface ICripto
    {
        string Criptografia(string entrada);
        //string Criptografia(string entrada, string senha);
    }
}
