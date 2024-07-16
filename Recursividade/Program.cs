using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recursividade
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Recursivo recursivo = new Recursivo();

            int numero = 5;
            long fatorial = recursivo.CalcularFatorial(numero);
            Console.WriteLine($"O fatorial de {numero} é {fatorial}");



            Console.ReadKey();
        }
    }
}
