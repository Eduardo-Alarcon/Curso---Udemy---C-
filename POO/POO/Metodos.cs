using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace POO
{
    class Metodos
    {

        #region Atributos
        //Atributos
        public string nome;
        public string sobrenome;
        public int nascimento;
        #endregion

        #region Metodos 

        //Metodos Simples

        public void mett()
        {
            Console.WriteLine("Olá");
        }

        //Metodos Com parâmetros

        public void Somar(int n1, int n2)
        {
            int resultado = n1 + n2; Console.WriteLine("A soma é " + resultado);


        }

        public void Show(string nome, int idade)
        {
            Console.WriteLine("Meu nome é " + nome + " e tenho " + idade + " anos");
        }
        #endregion

        #region Parâmetros

        public void AumentarValoar(int valor) // apenas pega o valor da variável
        {
            valor += 10;
            Console.WriteLine("Valor final: " + valor);
        }

        public void AumentarValue(ref int valor) // afeta a variável original 
        {
            valor += 10;
            Console.WriteLine("Valor Final : " + valor);
        }

        #endregion

        #region Com retorno 

        public string BuildName(string name, string lastName)
        {
            
            string fullName = name + " " + lastName;
            return fullName;
        }

        public int codeChar(char caracter)
        {
            int code = (int)caracter;

            return code;
        }

        public double valuePi()
        {
            return 3.1415;
        }

        #endregion

        #region Overloading 

        public void C(string nome)
        {
            Console.WriteLine(" oi " + nome);
        }
        public void C(string nome, int hora)
        {
            string msg = hora < 12 ? " bom dia " + nome : " boa tarde " + nome;
            Console.WriteLine(msg);
        }
        public bool comp ( int n1, int n2)
        {
            return n1 == n2;
        }
        public bool comp(string txt1, string txt2)
        {
            return txt1 == txt2;
        }

        #endregion

    }
}
