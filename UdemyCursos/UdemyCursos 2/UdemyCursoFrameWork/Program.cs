using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UdemyCursoFrameWork
{
    internal static class Program
    {
        static void Main()
        {

            string nome1, nome2, nome3, nome4;

            Console.WriteLine("Digite o nome 1: ");
            nome1 = Console.ReadLine();
            Console.WriteLine("Digite o nome 2: ");
            nome2 = Console.ReadLine();
            Console.WriteLine("Digite o nome 3: ");
            nome3 = Console.ReadLine();
            Console.WriteLine("Digite o nome 4: ");
            nome4 = Console.ReadLine();


            //Inverter os nomes : 

            Console.WriteLine("Nomes invertidos : ");
            Console.WriteLine(nome1);
            Console.WriteLine(nome2);
            Console.WriteLine(nome3);
            Console.WriteLine(nome4);
            Console.ReadKey(); 
        }
    }
}
