using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercício_4
{
    class Program
    {
        static void Main(string[] args)
        {
            //VarDec   
            double N, R1, R2;

            //Ler N
            Console.Write("Qual seu número?: ");
            N = double.Parse(Console.ReadLine());

            //Verificação de positividade e calculos
            if (N >= 0)
            {
                R1 = Math.Sqrt(N);
                Console.WriteLine("A raiz do seu número é: " + R1);
                R2 = N * N;
                Console.WriteLine("O quadrado do seu número é: " + R2);
            }

            Console.ReadLine();
       
        }
    }
}
