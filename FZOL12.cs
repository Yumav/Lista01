using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace atividade_12_de_13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double h, PI;
            char S;

            Console.WriteLine("Digite a altura em metros:");
             h = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite o sexo (F ou M):");
             S = char.Parse(Console.ReadLine());

            PI = S == 'M' ? (72.7 * h) - 58 : (62.1 * h) - 44.7;

            Console.WriteLine("O peso ideal é:" + h + "kg");
            Console.ReadLine();
        }
    }
}
