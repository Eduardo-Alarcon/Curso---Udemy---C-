using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estático
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //    Math m = new Math();
            //    Console.WriteLine("Qual a taxa?");
            //    m.taxa = int.Parse(Console.ReadLine());

            //Math.taxa = 10;

            //int valor = Math.Adicionar(100);
            //int valor1 =  Math.Diminuir(100);

            //Console.WriteLine(valor);
            //Console.WriteLine(valor1);

            //Console.ReadKey();

            Pessoa.maioridade = 21;
            Pessoa p1 = new Pessoa();
            p1.nome = " Eduardo";
            p1.idade = Pessoa.CalIdade(2006);

            Console.WriteLine(p1.nome);
            Console.WriteLine(p1.idade);

            Console.ReadKey();
        }
    }
}
