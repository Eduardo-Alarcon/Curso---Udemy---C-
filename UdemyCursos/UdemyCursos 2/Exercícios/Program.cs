using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercícios
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" Escolha umas das alternatias : ");
            Console.WriteLine("[1] ADIÇÃO");
            Console.WriteLine("[2] SUBTRAÇÃO");
            Console.WriteLine("[3] MULTIPLICAÇÃO");
            Console.WriteLine("[4] DIVISÃO");

            int resposta = int.Parse(Console.ReadLine());

            if (resposta == 1)
            {
                Console.WriteLine("Primeiro Número : ");
                int n1 = int.Parse(Console.ReadLine());
                Console.WriteLine("Segundo Número : ");
                int n2 = int.Parse(Console.ReadLine());
                Console.WriteLine(n1 + n2);
                Console.ReadKey();
            }
        }
    }
}
