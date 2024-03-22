using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace atividade_13_de_13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int A, BX;

            Console.Write("Digite o ano: ");
            A = int.Parse(Console.ReadLine());

            
            BX = (A % 400 == 0) || ((A % 4 == 0) && (A % 100 != 0)) ? 1.0 : 0.0;


            Console.WriteLine(BX == 1.0 ? A + " é um ano bissexto." : A + " não é um ano bissexto.");
            Console.ReadLine();
        }
    }
}
