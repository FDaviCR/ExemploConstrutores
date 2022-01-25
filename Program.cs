using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using ExemploConstrutores.Models;

namespace ExemploConstrutores
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Log log = Log.GetInstance();

            log.Propriedade = "Teste!";

            Log log1 = Log.GetInstance();
            System.Console.WriteLine(log1.Propriedade);

            // Pessoa p = new Pessoa("Davi","Ribeiro");
            // p.Apresentar(); 
        }
    }
}
