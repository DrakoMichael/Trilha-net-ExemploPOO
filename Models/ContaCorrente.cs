using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Trilha_net_ExemploPOO.Models
{
    public class ContaCorrente
    {
        public ContaCorrente(int NumeroConta, decimal saldoInicial)
        {
            NumeroConta = NumeroConta;
            saldo = saldoInicial;
        }
        public int NumeroConta { get; set; }    
        private decimal saldo;

        public void Sacar(decimal valor)
        {
            if(saldo >= valor)
            {
            saldo -= valor;
            Console.WriteLine($"Saque de {valor} realizado.");
            } 
            else 
            {
                Console.WriteLine($"Saque indiponível para saque. O valor {valor} é maior que o seu saldo disponível.");
            }
        }
        public void ExibirSaldo()
            {
                Console.WriteLine($"Seu saldo disponível agora é: {saldo}");
            }
    }
}