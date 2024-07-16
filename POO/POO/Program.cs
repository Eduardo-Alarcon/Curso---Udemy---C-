using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO
{
    internal class Program
    {

        

        #region
        //private string _nome;
        //private string _password;
        //private int _idade;

        //public string Nome { get; set; }

        //public void Apresentar()
        //{
        //    if (_nome != "")
        //        Console.WriteLine("Bem vindo " + _nome);


        //    Console.ReadKey();

        //}
        #endregion

        static void Main(string[] args)
        {
            Metodos m = new Metodos();
            m.mett();
            m.Somar(10, 5);
            m.Show("Eduardo", 17);

            int valor1 = 100;
            int valor2 = 100;

            m.AumentarValoar(valor1);
            m.AumentarValue(ref valor2);

            Console.WriteLine(valor1);
            Console.WriteLine(valor2);

            string fullName = m.BuildName("Eduardo", "Alarcon");
            int codeChar = m.codeChar('c');
            double pi = m.valuePi();

            Console.WriteLine(fullName);
            Console.WriteLine(codeChar);
            Console.WriteLine(pi);


            m.C("Eduardo");
            m.C("Eduardo", 17);

            bool res1 = m.comp(100, 50 * 2);
            bool res2 = m.comp("Eduardo", " Leonardo");
            Console.WriteLine(res1);
            Console.WriteLine(res2);
            

            Console.ReadKey();


        }


    }
}
