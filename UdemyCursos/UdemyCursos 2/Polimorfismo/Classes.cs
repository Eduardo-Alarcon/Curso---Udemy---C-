using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polimorfismo
{
    class Forma
    {
     
        
            public int X { get; private set; }
            public int Y { get; private set; }
            public int Altura { get; set; }
            public int Largura { get; set; }
            public int Raio { get; set; }

            public virtual void Desenhar()
            {
                Console.WriteLine("Preparando-se para desenhar");
            }

            public virtual void Area()
            {

            }

        
    }
    class circulo : Forma
    {
        public override void Desenhar()
        {
            base.Desenhar();
            Console.WriteLine("Desenhar um Circulo");
        }

        public override void Area()
        {
            double area = 3.12 * (Raio * Raio);
            Console.WriteLine("Area Circulo " + area);
        }
    }

    class REtangulo : Forma
    {
        public override void Desenhar()
        {
            base.Desenhar();
            Console.WriteLine("Desenhar um Retangulo");
        }

        public override void Area()
        {
            double area = ( Largura * Altura ) / 2 ;
            Console.WriteLine("Area Circulo " + area);
        }

    }
    }
