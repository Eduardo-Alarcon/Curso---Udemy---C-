using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recursividade
{
    internal class Recursivo
    {
        public void CalcularFatorial(int n)
        {
            if (n < 0)
            {
                throw new ArgumentException("O número não pode ser negativo.", nameof(n));
            }

            int resultado = 1;

            for (int i = 1; i <= 5; i++)
            {
                resultado *= i;
                Console.WriteLine(resultado);
            }
            
        }



    }
}
