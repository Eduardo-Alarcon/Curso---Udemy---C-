using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herança
{
    class Humano
    {

        public virtual void Olhos()
        {
            Console.WriteLine("Humano.Olhos");
        }
        public virtual void Cabelosos()
        {
            Console.WriteLine("Humano.Cabelo");
        }
    }

    class Pessoa : Humano
    {

        public sealed override void Olhos()
        {
            Console.WriteLine("Pessoa.Olhos");
        }
        public override void Cabelosos()
        {
            Console.WriteLine("Pessoa.Cabelo");
        }
    }

    class Homem : Pessoa
    {

        //public virtual void Olhos()
        //{
        //    Console.WriteLine("Homem.Olhos");
        //}
        public override void Cabelosos()
        {
            Console.WriteLine("Homem.Cabelo");
        }


    }
}