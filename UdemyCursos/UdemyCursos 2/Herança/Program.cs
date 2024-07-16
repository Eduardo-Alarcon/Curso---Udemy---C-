using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herança
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region
            //Carro c = new Carro();
            //Bicicleta b = new Bicicleta();

            //c.Acelerar();
            //b.Acelerar();
            #endregion

            Humano h = new Humano();
            h.Olhos();
            h.Cabelosos();

            Console.WriteLine();

            Pessoa p = new Pessoa();
            p.Olhos();
            p.Cabelosos();

            Console.WriteLine();

            Homem H = new Homem();  
            H.Olhos();
            H.Cabelosos();


            Console.ReadKey();



        }
    }
}
