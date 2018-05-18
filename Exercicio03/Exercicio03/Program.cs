using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio03
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Teste2");

            Filial fil = new Filial(4, "testef", null, null, null);
            Console.WriteLine(fil.Nome);
            Console.ReadKey();
        }
    }
}
