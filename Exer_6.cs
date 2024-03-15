using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercício_6
{
    class Program
    {
        static void Main(string[] args)
        {
            //VarDec   
            double N1, N2;

            //Ler N1
            Console.Write("Qual seu primeiro número?: ");
            N1 = double.Parse(Console.ReadLine());

            //Ler N2
            Console.Write("Qual seu segundo número?: ");
            N2 = double.Parse(Console.ReadLine());

            //Verificar qual o maior número e escrever
            if (N1 > N2)
            {
                Console.WriteLine(N1 + " é o maior valor.");
                Console.WriteLine("E a diferença entre eles é: " + (N1 - N2));
            }
            if (N2 > N1)
            {
                Console.WriteLine(N2 + " é o maior valor.");
                Console.WriteLine("E a diferença entre eles é: " + (N2 - N1));
            }
            Console.ReadLine();
        }
    }
}
