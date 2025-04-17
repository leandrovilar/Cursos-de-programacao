using System;

namespace ExemploPOO.Models
{
    public abstract class Conta
    {
        protected decimal saldo;
        public abstract void Creditar(decimal valar);
        public void ExibirSaldo()
        {
            Console.WriteLine("O saldo é: " + saldo);
        }
    }
}