using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExemploConstrutores.Models
{
    internal class Pessoa
    {
        private string Nome;
        private string Sobrenome;

        public Pessoa() 
        {
            Nome = string.Empty;
            Sobrenome = string.Empty;
        }

        public Pessoa(string Nome, string Sobrenome) 
        {
            this.Nome = Nome;
            this.Sobrenome = Sobrenome;
        }

        public void Apresentar()
        {
            Console.WriteLine($"Oi, meu nome é {Nome}");
        }
    }
}
