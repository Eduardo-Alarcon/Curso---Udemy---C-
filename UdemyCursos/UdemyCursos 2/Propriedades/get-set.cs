using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Propriedades
{
    class get_set
    {
        // Definição de um camp
        private string _nome;
        private string _sobrenome;
        private int _idade;

        //Definição de uma propriedade 
        public string Nome {  get { return _nome; } set { _nome = value; } }
        public string Sobrenome { get { return _sobrenome; } set { _sobrenome = value;  } }
       public int Idade { get { return _idade; } }

        public void Apresentar()
        {
            if(_nome != ""){
                Console.WriteLine("");
            }
        }


    }
}
