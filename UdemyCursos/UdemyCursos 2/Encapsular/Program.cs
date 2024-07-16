using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsular
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Conta c = new Conta();
            c._cliente = "Eduardo";
            c._saldo = 100;

            double valor = 100;
            double valor1 = 50;

            c.Depositar(valor);
            c.Sacar(valor1);

            Console.WriteLine("o seu saldo é " + c._saldo);

            Console.ReadKey();
        }
    }
}
