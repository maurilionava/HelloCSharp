using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloCSharp.CSharpBank
{
    public interface ContaInterface
    {
        public Boolean Sacar(Double valor);
        public Boolean Depositar(Double valor);
        public Boolean Transferir(Double valor, ContaInterface contaDestino);
    }
}
