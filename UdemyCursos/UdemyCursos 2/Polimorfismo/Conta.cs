using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polimorfismo
{
    class CaixaEletronico 
    {

    }

    interface IConta
    {
        string Usuario { get; set; }
        void Depositar();
        void Sacar();
        void Saldo();
    }
}
