using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercício_8
{
    class Program
    {
        static void Main(string[] args)
        {
            //VarDec
            double nota1, nota2, media;

            // Solicita e lê as notas do usuário
            Console.Write("Digite a primeira nota: ");
            nota1 = double.Parse(Console.ReadLine());


            Console.Write("Digite a segunda nota: ");
            nota2 = double.Parse(Console.ReadLine());


            // Verifica se as notas são válidas
            if (nota1 >= 0 && nota1 <= 10 && nota2 >= 0 && nota2 <= 10)
            {
                // Calcula a média
                media = (nota1 + nota2) / 2;
                Console.WriteLine("A média das notas é: " + media);
            }
            else
            {
                Console.WriteLine("Uma ou ambas as notas são inválidas. As notas devem estar entre 0 e 10.");
            }
            Console.ReadLine();
        }

    }
}
