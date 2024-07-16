using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estático
{
    partial class Pessoa
    {
        public static int maioridade = 18;

        public string nome;
        public int idade;

        public void Apresentar()
        {
            Console.WriteLine("Oi eu sou" + nome );

        }

        public static int CalIdade(int anoNascimento)
        {
            return DateTime.Now.Year - anoNascimento;
        }


    }
}
