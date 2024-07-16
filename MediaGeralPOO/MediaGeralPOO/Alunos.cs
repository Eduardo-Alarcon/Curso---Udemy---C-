using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaGeralPOO
{
    class Alunos
    {
        #region
        //public string usuario;
        //public int senha;
        //public int qnt;
        //private double media;
        //private int qntA;

        //public Alunos(string Usuario, int Senha)
        //{
        //    usuario = Usuario;
        //    senha = Senha;
        //    qnt = 0;
        //    qntA++;
        //}

        //public void Calcular_Media(double n1, double n2, double n3)
        //{
        //    double media = (n1 + n2 + n3) / 3;
        //    this.media = media;
        //    qnt++;
        //    Console.WriteLine("A media final de " + usuario + " é " +  media);
        //}
        #endregion

        public string Nome { get; private set; }
        private double[] _notas;

        public double Media
        {
            get
            {
                return CalcularMedia();
            }
        }

        public Alunos(string nome, int provas)
        {
            Nome = nome; // Nome recebe o valor inserido no nome
            _notas = new double[provas]; // o array contém as notas da prova
        }

        public void InserirNotas()
        {
            for (int i = 0; i < _notas.Length; i++)
            {
                Console.WriteLine("Nota #" + (i + 1) + ": ");
                _notas[i] = double.Parse(Console.ReadLine());
            }

        }
        private double CalcularMedia()
        {
            double total = 0;
            for ( int i = 0; i < _notas.Length; i++)
            {
                total += _notas[i];
            }
            return total / _notas.Length;
        }
    }   
}
