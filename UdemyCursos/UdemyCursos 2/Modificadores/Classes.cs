using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modificadores
{
    class Teste
    {

        private string Nome {  get;  private set; }
        public string sobreNome;


        private void M1()
        {

        }

        public void M2()
        {

        }

        class Humano
        {
            //protected deixa visivel para quem herda, o private não
            protected string nome;
            public string sobreNome;
            internal int idade;
            //internal deixa restrito para a aplicação ( apenas para a aplicação interna ) 
        }

        class Humem : Humano
        {
            public void M1()
            {
                nome = "";
            }

        }
    }


}
