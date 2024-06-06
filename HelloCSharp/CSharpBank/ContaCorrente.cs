using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloCSharp.CSharpBank
{
    public class ContaCorrente : ContaInterface
    {
        public ContaCorrente(Titular titular, String agencia, String conta)
        {
            this.titular = titular;
            this.agencia = agencia;
            this.conta = conta;
        }

        private Titular titular;
        private String agencia;
        private String conta;
        private Double saldo;

        public bool Sacar(double valor)
        {
            if (this.saldo >= valor)
            {
                this.saldo -= valor;
                return true;
            }

            return false;
        }

        public bool Depositar(double valor)
        {
            this.saldo += valor;
            return true;
        }

        public bool Transferir(double valor, ContaInterface contaDestino)
        {
            if (this.saldo >= valor)
            {
                contaDestino.Depositar(valor);
                return true;
            }

            return false;
        }
    }
}
