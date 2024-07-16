using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herança
{
    sealed class Bicicleta : Veiculos
    {
        public void Pedalar()
        {

        }

        public override void Acelerar()
        {
            Console.WriteLine("Acelerou a bike!!");
        }


    }
}
