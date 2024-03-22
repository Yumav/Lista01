using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercício_2
{
    class Program
    {
        static void Main(string[] args)
        {
            //VarDec
            double N;

            //Ler Número
            Console.Write("Qual o seu valor?: ");
            N = int.Parse(Console.ReadLine());

            //Testes
            switch (N)
            {
                case 0:
                    Console.WriteLine("ZERO");
                    break;
                case 1:
                    Console.WriteLine("UM");
                    break;

                case 2:
                    Console.WriteLine("DOIS");
                    break;
                case 3:
                    Console.WriteLine("TRÊS");
                    break;
                case 4:
                    Console.WriteLine("QUATRO");
                    break;
                case 5:
                    Console.WriteLine("CINCO");
                    break;
                default:
                    Console.WriteLine("Número inválido");
                    break;
            }
            
            Console.ReadLine();
            
        }
    }
}
