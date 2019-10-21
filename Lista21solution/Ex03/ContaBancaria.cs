using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex03
{
    class ContaBancaria
    {
        private int numero;
        private decimal saldo;

        public ContaBancaria(decimal saldo, int numero)
        {
            this.numero = numero;
            this.saldo = saldo;
        }

        public void Depositar(decimal m)
        {
            if (m > 0) saldo += m;
            else throw new InversaoSaldoException("Valor inválido");

        }

        public void Sacar(decimal m)
        {
            if (m > 0) saldo -= m;
            else throw new InversaoSaldoException("O valor informado é invalido");
        }

        public decimal VerificarSaldo()
        {
            return saldo;
        }

    }
}
