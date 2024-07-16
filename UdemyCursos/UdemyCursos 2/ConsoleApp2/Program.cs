using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Pessoa pessoa = new Pessoa();
            pessoa.Question();
            pessoa.Question1();

            pessoa.Maior();

            Console.ReadKey();
        }
    }
}
