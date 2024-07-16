using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herança
{
    abstract class Veiculos
    {

        public string Cor {  get; set; }
        public string Marca { get; set; }

        public abstract void Acelerar();


        public void Parar()
        {
            Console.WriteLine("Parou!");
        }


        

    }


}
