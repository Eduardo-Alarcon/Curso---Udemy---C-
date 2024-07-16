using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Execícios_de_POO
{
    internal class Transações
    {

        public int numero;
        public string titular;
        public double saldo;


        public Transações(int Numero, string Titular)
        {
            numero = Numero;
            titular = Titular;
            saldo = 0;
        }

        public void Depositar(double valor)
        {
            if (valor > 0)
            {
                saldo += valor;
                Console.WriteLine("Depósito de " + valor + " na conta de " + titular);
            }
            else
            {
                Console.WriteLine("Valor tem que ser positivo");
            }
        }

        public void Sacar(double valor)
        {
            if ( valor  > 0)
            {
                if ( saldo >= valor)
                {
                    saldo -= valor;
                    Console.WriteLine("Saque de " + valor + " na contade " + titular);
                }
                else
                {
                    Console.WriteLine("Valor tem que ser menor do que o saldo");
                }
            }
            else
            {
                Console.WriteLine("Valor invalido");
            }
        }

        public void ConsultarSaldo()
        {
            Console.WriteLine("Seu saldo é " + saldo);
        }





    }
}
