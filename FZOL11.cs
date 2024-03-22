using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace atividade_11_de_13
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
            Console.Write("Digite uma letra: ");
            char L = char.Parse(Console.ReadLine());
            string R;

            switch (L)
            {
                case 'a':
                case 'e':
                case 'i':
                case 'o':
                case 'u':
                R = "Vogal";
                break;
                default:
                R = "Consoante";
                break;
            }

            Console.WriteLine("A letra " + L + " é uma " + R + ".");
            Console.ReadLine();
        }
    }
}
