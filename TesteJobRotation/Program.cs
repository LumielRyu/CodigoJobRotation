using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace TesteJobRotation
{
    internal class Program
    {
        public static string reverterPalavra (string palavra)
        {
            char[] charArray = palavra.ToCharArray();

            string reverterstring = String.Empty;

            for (int i = charArray.Length - 1; i > -1; i--)
            {

                reverterstring += charArray[i];
            }

            return reverterstring;
        }
        static void Main(string[] args)
        {
            int menu = 6;

            while (menu != 9)
            {

                string palavraMain;
                switch (menu)
                {
                    case 1:
                        Console.Clear();
                        int indice = 13;
                        int soma = 0;
                        int k = 0;
                        while (k < indice)
                        {
                            k = k + 1;
                            soma = soma + k;
                        }

                        Console.WriteLine("O Valor de Soma Sera de:", soma);
                        Console.ReadKey();
                        menu = 6;
                        break;
                    case 2:
                        Console.Clear ();
                        int num1 = 0, num2 = 1, aux, valorDesejado;

                        Console.WriteLine("Digite o Valor Desejado a ser encontrado:");
                        valorDesejado = int.Parse(Console.ReadLine());


                        for (int i = 0; i​​​​​​​ < 60; i++)
                        {
                            aux = num1;
                            num1 = num2;
                            num2 = num1 + aux;
                            if (num2 == valorDesejado)
                            {
                                Console.WriteLine("Valor Encontrado na sequencia Fibonacci");
                            }

                            else
                            {
                                Console.WriteLine("Valor não encontrado na sequencia Fibonacci");
                            }

                        }

                        Console.ReadKey();
                        menu = 6;


                        break;
                    case 3:
                        break;
                    case 4:

                        break;
                    case 5:
                        Console.Clear();
                        Console.WriteLine("Digite a palavra desejada para inverter a ordem:");
                        palavraMain = Console.ReadLine();
                        Console.WriteLine(reverterPalavra(palavraMain));
                        Console.ReadKey();
                        menu = 6;
                        break;
                    case 6:
                        Console.Clear();
                        Console.WriteLine("Menu de Questões:");
                        Console.WriteLine("(1) - Valor de Soma:");
                        Console.WriteLine("(2) - Valor de Fibonacci:");
                        Console.WriteLine("(5) - Inverter Palavra:");
                        Console.WriteLine("(9) - Sair do Programa.");
                        Console.WriteLine("Digite a Opção:");
                        menu = int.Parse(Console.ReadLine());
                        break;
                }
            }
        }
    }
}
