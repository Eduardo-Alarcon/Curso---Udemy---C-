using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Execícios_de_POO
{
    internal class Carro
    {

        public string marca;
        public string modelo;
        public int ano;
        public string cor;

        public Carro(string Marca, string Modelo, int Ano)
        {
            Console.WriteLine("Oi");
            marca = Marca = Console.ReadLine();
            modelo = Modelo;
            ano = Ano;
            cor = "Não atribuida";

        }

        public void imprimir()
        {
            Console.WriteLine("A marca é " + marca + " do modelo " + modelo + " do ano de " + ano + " da cor " + cor);
        }
    }
}
