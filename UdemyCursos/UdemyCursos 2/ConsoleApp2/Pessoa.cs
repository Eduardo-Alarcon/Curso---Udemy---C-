using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Pessoa
    {
        public string nome1, nome2;
        public int id1, id2;

        public void Question()
        {

            Console.WriteLine("Qual o seu nome?");
            nome1 = Console.ReadLine();
            Console.WriteLine("Qual a sua idade");
            id1 = int.Parse(Console.ReadLine());


        }
        public void Question1()
        {

            Console.WriteLine("Qual o seu nome?");
            nome2 = Console.ReadLine();
            Console.WriteLine("Qual a sua idade");
            id2 = int.Parse(Console.ReadLine());
        }

        public void Maior()
        {
            if (id1 > id2)
            {
                Console.WriteLine("A pessoa " + nome1 + " é mais velha");
            }
            else
            {
                Console.WriteLine("A pessoa " + nome2 + " é mais velha");
            }
        }

    }
}
