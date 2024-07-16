using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herança
{
    class Carro : Veiculos
    {
        public int VeloMax { get; set; }

        public override void Acelerar()
        {
			Console.WriteLine("Acelerou o carro");
		}

        public void LigarMotor()
        {
            Console.WriteLine("Ligou!");
        }

    }
}
