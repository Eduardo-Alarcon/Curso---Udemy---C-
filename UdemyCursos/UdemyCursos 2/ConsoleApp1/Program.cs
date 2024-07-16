using System.ComponentModel.DataAnnotations;
using System.Reflection.PortableExecutable;
using System.Xml.Serialization;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main()
        {

            #region Inverter - lógica 

            //string nome1, nome2, nome3, nome4, m;

            //Console.WriteLine("Digite o nome 1: ");
            //nome1 = Console.ReadLine();
            //Console.WriteLine("Digite o nome 2: ");
            //nome2 = Console.ReadLine();
            //Console.WriteLine("Digite o nome 3: ");
            //nome3 = Console.ReadLine();
            //Console.WriteLine("Digite o nome 4: ");
            //nome4 = Console.ReadLine();


            ////Inverter os nomes : 
            //m = nome1;
            //nome1 = nome4;
            //nome4 = m;
            //m = nome2;
            //nome2 = nome3;
            //nome3 = m;

            //Console.WriteLine("Nomes na sequencia invertida : ");
            //Console.WriteLine(nome1);
            //Console.WriteLine(nome2);
            //Console.WriteLine(nome3);
            //Console.WriteLine(nome4);
            //Console.ReadKey();
            #endregion

            #region Condicionais 

            ////OBSS : Para transformar as classes : ().Parse


            //Console.WriteLine("1 ou 2 ? ");
            //int resposta = int.Parse(Console.ReadLine());
            //if (resposta == 2)
            //    Console.WriteLine("Errou !");
            //else Console.WriteLine("Sorte do caramba");

            #endregion

            #region Operadores Aritiméticos 

            ////+
            ////-
            ////*

            /////

            ////% -resto da divisão
            //// Incremento(mais = ++ )(menos = -- )
            //// num1 = num1 + 1 = num1++

            //// a += b(a = a + b)
            //// a %= b(a = a % b)

            //// || -or
            //// && -and

            //Console.WriteLine("Quantos graus está ai?");
            //double graus = float.Parse(Console.ReadLine());
            //double transformar = graus * 1.8 + 32;
            //double transformar2 = graus + 273;
            //Console.WriteLine("Em fahrenheit é " + transformar + " e em Kelvin é " + transformar2);


            #endregion

            #region Vetor Array  

            //int[] numeros = new int[5];

            //numeros[0] = 10;
            //numeros[1] = 20;
            //numeros[2] = 30;
            //numeros[3] = 40;
            //numeros[4] = 50;

            //// mas pode modificar o valor ::

            //numeros[2] = 55;

            //string[] nomes = new string[3];

            //nomes[0] = "Eduardo";
            //nomes[1] = "André";
            //nomes[2] = "Gabriely";

            //Console.WriteLine(nomes[0]);

            #endregion

            #region Condicional 

            //int valor = 10;


            //if (valor != 5)
            //{
            //    Console.WriteLine("Condição Falsa!");

            //}
            //else if (valor != 10)
            //{
            //    Console.WriteLine("Condição Verdadeira!");
            //}
            //else
            //{
            //    Console.WriteLine("Sei la ");
            //}
            #endregion

            #region Exercício de Condicional - 01 

            //Console.WriteLine(" Escolha umas das alternatias : ");
            //Console.WriteLine("[1] ADIÇÃO");
            //Console.WriteLine("[2] SUBTRAÇÃO");
            //Console.WriteLine("[3] MULTIPLICAÇÃO");
            //Console.WriteLine("[4] DIVISÃO");

            //int resposta = int.Parse(Console.ReadLine());

            //if (resposta == 1)
            //{
            //    Console.WriteLine("Primeiro Número : ");
            //    int n1 = int.Parse(Console.ReadLine());
            //    Console.WriteLine("Segundo Número : ");
            //    int n2 = int.Parse(Console.ReadLine());
            //    Console.WriteLine(n1 + n2);
            //}

            //if (resposta == 2)
            //{
            //    Console.WriteLine("Primeiro Número : ");
            //    int n1 = int.Parse(Console.ReadLine());
            //    Console.WriteLine("Segundo Número : ");
            //    int n2 = int.Parse(Console.ReadLine());
            //    Console.WriteLine(n1 - n2);
            //}

            //if (resposta == 3)
            //{
            //    Console.WriteLine("Primeiro Número : ");
            //    int n1 = int.Parse(Console.ReadLine());
            //    Console.WriteLine("Segundo Número : ");
            //    int n2 = int.Parse(Console.ReadLine());
            //    Console.WriteLine(n1 * n2);
            //}

            //if (resposta == 4)
            //{
            //    Console.WriteLine("Primeiro Número : ");
            //    int n1 = int.Parse(Console.ReadLine());
            //    Console.WriteLine("Segundo Número : ");
            //    int n2 = int.Parse(Console.ReadLine());
            //    Console.WriteLine(n1 / n2);
            //}

            #endregion

            #region Exercício de Condicional - 02 

            //Console.WriteLine("Primeiro Número");
            //int p1 = int.Parse(Console.ReadLine());
            //Console.WriteLine("Segundo Número");
            //int p2 = int.Parse(Console.ReadLine());

            //if (p1 % p2 == 0.0)
            //{
            //    Console.WriteLine("Os números são multiplos um do outro ");
            //}
            //else
            //{
            //    Console.WriteLine("O número " + p1 + " não é multiplo de " + p2);
            //}


            //if (p1 % 2 == 0) { Console.WriteLine("O primeiro número é par"); }

            //else { Console.WriteLine("O primeiro número é impar "); }


            //if (p2 % 2 == 0) { Console.WriteLine("O segundo número é par"); }

            //else { Console.WriteLine("O segundo número é impar "); }
            //int media = (p1 + p2) / 2;
            //Console.WriteLine("A média dos dois números é " + media);

            #endregion

            #region Exercício de Condicional - 03

            //Console.WriteLine("Qual a sua altura em cm?");
            //int alt = int.Parse(Console.ReadLine());
            //Console.WriteLine("Qual o seu sexo? \n[H] \n[M]");
            //string sex = Console.ReadLine();

            //if (sex == "H")
            //{
            //    double pesoIdeal = (72.7 * alt) - 57;
            //    Console.WriteLine("Seu peso ideal é " + pesoIdeal);
            //}
            //else
            //{
            //    double pesoIdeal = (62.1 * alt) - 44.7;
            //    Console.WriteLine("Seu peso ideal é " + pesoIdeal);
            //}

            #endregion

            #region Exercício de Condicional - 04

            //Random random = new Random();
            //int numeroAleatorio = random.Next(0, 3);

            //Console.WriteLine("\n[0] Pedra \n[1] Papel \n[2] Tesoura? ");
            //int n = int.Parse(Console.ReadLine());

            //if (numeroAleatorio == 0 )
            //{
            //    if (n == 0) { Console.WriteLine("Empate!"); } 
            //    else if (n == 1) { Console.WriteLine("Você ganhou !"); }
            //    else { Console.WriteLine("Eu ganhei djhgksdy"); }
            //}
            //else if (numeroAleatorio == 1)
            //{
            //    if (n == 0) { Console.WriteLine("Eu ganhei djhgksdy"); }
            //    else if (n == 1) { Console.WriteLine("Empate!"); }
            //    else { Console.WriteLine("Você ganhou!"); }
            //}
            //else if (numeroAleatorio == 2)
            //{
            //    if (n == 0) { Console.WriteLine("Você ganhou"); }
            //    else if (n == 1) { Console.WriteLine("Eu ganhei djhgksdy"); }
            //    else { Console.WriteLine("Emapte!"); }
            //}

            #endregion

            #region  Operador ternario - condição ? true : false; 

            //int num = 10;
            //string m = "";

            //m = num > 5 ? "Maior que 5" : "Menor que 5";

            ////  --------- OU -------- //

            //int num = 10;
            //string m = "";

            //if (num > 5) { m = "Maior que 5"; }
            //else { m = "Menor que 5"; }


            #endregion

            #region Switch Case / goto

            //Console.WriteLine("Escolha entre 1-3");
            //int escolha = int.Parse(Console.ReadLine());


            //switch ( escolha)
            //{
            //    default:
            //        Console.WriteLine("ENTRE 1 E 3 !!! ");
            //        break;
            //    case 1:
            //        Console.WriteLine("opção 1 ");
            //        break;
            //    case 2:
            //        Console.WriteLine("opção 2 ");
            //        break;
            //    case 3:
            //        Console.WriteLine("opção 3 ");
            //        break;

            //}

            // Inicio: //Label

            //Console.WriteLine("Escolha uma opção");
            //int op = int.Parse(Console.ReadLine());
            //int valor = 0;

            //switch (op)
            //{
            //    default:
            //        Console.WriteLine("Selecione uma opção válida");
            //        goto Inicio; // ele volta ate o Console.WriteLine
            //        break;
            //        case 1:
            //        valor += 100;
            //         break;
            //    case 2:valor += 50;
            //        goto case 1; // ele volta e pega o valor do case 1
            //}

            //Console.WriteLine("Valor final" + valor);

            #endregion

            #region Exercício de Switch Case

            //Inicio:

            //    Console.WriteLine("Primeiro número");
            //    double p1 = double.Parse(Console.ReadLine());

            //    Console.WriteLine("Segundo número");
            //    double p2 = double.Parse(Console.ReadLine());

            //    Console.WriteLine("Selecione a operação : \n[ + ] \n[ - ] \n[ * ] \n[ / ]");
            //    char operacao = char.Parse(Console.ReadLine());


            //    switch (operacao)
            //    {
            //        default:
            //            Console.WriteLine("Selecione uma operação válida");
            //            goto Inicio;
            //        case '+':
            //            Console.WriteLine(" A soma de " + p1 + " mais " + p2 + " é " + (p1 + p2));
            //            break;
            //        case '-':
            //            Console.WriteLine(" A subtração de " + p1 + " menos " + p2 + " é " + (p1 - p2));
            //            break;
            //        case '*':
            //            Console.WriteLine("A multiplicação de " + p1 + " com " + p2 + " é " + (p1 * p2));
            //            break;
            //        case '/':
            //            Console.WriteLine(" A divisão de " + p1 + " com " + p2 + " é " + (p1 / p2));
            //            break;
            //    }

            //    Console.WriteLine(" Continuar calculando ?");
            //    string dec = Console.ReadLine();
            //    if (dec == "sim" || dec == "Sim")
            //    {
            //        goto Inicio;
            //    }


            #endregion

            #region While - Do While 

            //Aba:

            //Console.WriteLine(" Quanto é 20 x 89? ");
            //int res = int.Parse(Console.ReadLine());

            //while ( res != 1780)
            //{
            //    Console.WriteLine("Errou, tenta de novo");
            //    goto Aba;
            //}

            // -------------------------------------- //

            //int valor = 0;

            //do
            //{
            //    Console.WriteLine(" O valor é " + valor);
            //    valor++;
            //} while (valor > 10);


            #endregion

            #region For || Foreach 

            ////Variável||Condição|incremendo etc||//
            //for (int numero = 0; numero < 10; numero++)
            //{
            //    Console.WriteLine("O valor é " + numero);
            //}

            //------------------------------------------------------------------------//


            //string[] nomes = { "G", "b", "ryteiut", "Eduardo" };


            //foreach (string nome in nomes)
            //{
            //    if (nome == "Eduardo")
            //    {
            //        Console.WriteLine(nome);
            //    }
            //}

            #endregion

            #region Exercício da Sequência de Fibonacci

            //int a = 0, b = 1, c = 0;
            //Console.WriteLine("Quantos valores ? ");
            //int esc = int.Parse(Console.ReadLine());

            //for (int i = 0; i < esc; i++)
            //{
            //    Console.WriteLine(a + ", ");
            //    c = a + b;
            //    a = b;
            //    b = c;
            //}

            #endregion

            #region Exercício de Laços repetição 01

            // for (int i = 100; i > 0; i--) { Console.WriteLine(i); }

            #endregion

            #region Exercícios de Laços de repetição 02


            //Console.WriteLine("Oi bom dia");

            //for (int i = 1; i < 5; i++)
            //{
            //    Console.WriteLine("Qual a idade do filho número " + i + " ? ");
            //    int id = int.Parse(Console.ReadLine());


            //    if (id <= 12)
            //    {
            //        Console.WriteLine("Ele é infantil");
            //    }
                
            //    else if (id <= 17) 
            //    { 
            //        Console.WriteLine("Ele é Juvenil"); 
            //    }
                
            //    else 
            //    { 
            //        Console.WriteLine("Elé é Adulto");
            //    }
            //}

                #endregion

                Console.ReadKey();
        }
    }


}