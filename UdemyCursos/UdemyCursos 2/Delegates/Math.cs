﻿using System;

namespace Delegates
{
    internal class Math
    {

        public void Somar(int n1, int n2)
        {
            Console.WriteLine("A soma é " + (n1 + n2));
        }
        public void Subtrair(int n1, int n2)
        {
            Console.WriteLine("A subtração é " + (n1 - n2));
        }
        public void Dividir(int n1, int n2)
        {
            Console.WriteLine("A divisão é " + (n1 / n2));
        }
        public void Multiplicar(int n1, int n2)
        {
            Console.WriteLine("A multiplicação é " + (n1 * n2));
        }
    }
}
