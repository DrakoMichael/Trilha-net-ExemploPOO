using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Trilha_net_ExemploPOO.Models
{
    public class Pessoa
    {
        public string Nome { get; set; }
        public int Idade { get; set; }  

        public void Apresentar()
        {
            Console.WriteLine($"Olá, meu nome é {Nome} e minha idade é {Idade}!");
        }

        public void Apresentar2()
        {
            Console.WriteLine("Fim da execução do código.");
        }
    }
}