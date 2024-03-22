using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace atividade_7_de_13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int N;

            Console.Write("Qual o valor?: ");
            N = int.Parse(Console.ReadLine());

            if (N % 3 == 0 && N % 5 == 0)
            {
                Console.WriteLine(N + " é divisível por 3 e por 5");
            }
            else if (N % 3 == 0)
            {
                Console.WriteLine(N + " é divisível por 3");
            }
            else if (N % 5 == 0)
            {
                Console.WriteLine(N + " é divisível por 5");
            }
            else
            {
                Console.WriteLine(N + " não é divisível por 3 nem por 5");
            }
            Console.ReadLine();
        }
    }
}
