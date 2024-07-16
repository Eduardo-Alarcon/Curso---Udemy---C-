using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates
{
    internal class Program
    {
        delegate void operacao(int num1, int num2);

        static void Main(string[] args)
        {
            Math m = new Math();

            operacao conta = null;

            conta += m.Somar;
            conta += m.Subtrair;
            conta += m.Dividir;
            conta += m.Multiplicar;


            conta(10, 2);

            Console.WriteLine();

            conta -= m.Dividir;
            conta -= m.Subtrair;

            Console.ReadKey();
        }
    }
}
