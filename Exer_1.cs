using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_5
{
    class Program
    {
        static void Main(string[] args)
        {
            //VarDec   
            int N;

            //Ler N
            Console.Write("Qual seu número?: ");
            N = int.Parse(Console.ReadLine());

            //Verificar sobre ser ímpar ou par
            if (N % 2 > 0)
                Console.WriteLine("Seu valor é ímpar");
            if (N % 2 == 0)
                Console.WriteLine("Seu valor é par");

            Console.ReadLine();

        }
    }
}
