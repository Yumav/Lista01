using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercício_10
{
    class Program
    {
        static void Main(string[] args)
        {
            //Vardec
           double h, kg;
            char gen;

            //ler altura
            Console.Write("Qual sua altura?: ");
            h = double.Parse(Console.ReadLine());

            //Ler gênero
            Console.Write("Qual seu gênero?(responda com H ou M): ");
            gen = char.Parse(Console.ReadLine());

            //Cálculo de peso ideal
            if (gen == 'M' || gen == 'm')
            {
                kg = (72.7 * h) - 58;
            }
            else kg = ((62.1 * h) - 44.7);

            Console.WriteLine("O seu peso ideal é de: " + kg + "kg");
            
            Console.ReadLine();

        }
    }
}
