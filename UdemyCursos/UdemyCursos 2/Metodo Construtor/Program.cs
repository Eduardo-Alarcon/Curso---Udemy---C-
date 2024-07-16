using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metodo_Construtor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region



            Pessoa p1 = new Pessoa();

            //Console.WriteLine("Qual o seu nome ? ");
            //string nome = Console.ReadLine();
            //Console.WriteLine("Qual o seu sobrenome ? ");
            //string sobrenome = Console.ReadLine();
            //Console.WriteLine("Qual o seu ano de nascimento ? ");
            //int ano = int.Parse(Console.ReadLine());
            Console.WriteLine(p1.nome );
            Console.WriteLine(p1.sobrenome );
            Console.WriteLine(p1.anoNascimento );
            Console.WriteLine(p1.idade);

            Console.WriteLine();

            Pessoa p2 = new Pessoa("Eduardo", "Alarcon", 2006);
            Console.WriteLine(p2.nome);
            Console.WriteLine(p2.sobrenome);
            Console.WriteLine(p2.anoNascimento);
            Console.WriteLine(p2.idade + " anos");

            Console.WriteLine();

            Pessoa p3 = new Pessoa("Eduardo", "Alarcon");
            Console.WriteLine(p3.nome);
            Console.WriteLine(p3.sobrenome);
            Console.WriteLine(p3.anoNascimento);


            Console.ReadKey();

            #endregion
        }

    }
}
