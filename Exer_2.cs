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
            double N,R;

            //Ler N
            Console.Write("Qual seu número?: ");
            N = double.Parse(Console.ReadLine());

            //Verificação de positividade e calculos
            if (N >= 0)
            {
                R = Math.Sqrt(N);
                Console.WriteLine("A raiz do seu número é: " + R);
            }
            if (N < 0)
                Console.WriteLine("Seu número é inválido.");

            Console.ReadLine();
        }
    }
}
