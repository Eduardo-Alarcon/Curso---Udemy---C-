﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estático
{
    internal static class Math
    {
         public static int taxa;

         public static int Adicionar(int valor)
        {
            return valor + taxa;
        }

         public static int Diminuir(int valor)
        {
            return valor - taxa;
        }
    }
}
