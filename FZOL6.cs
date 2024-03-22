using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace atividade_6_de_13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x, w, z, y;

            Console.Write("Digite o valor de w (De 1 a 4): ");
            w = int.Parse(Console.ReadLine());


            Console.Write("Digite o valor de x: ");
            x = int.Parse(Console.ReadLine());


            Console.Write("Digite o valor de y: ");
            y = int.Parse(Console.ReadLine());


            Console.Write("Digite o valor de z: ");
            z = int.Parse(Console.ReadLine());

            if (w == 1)
            {
                // Cálculo da média geométrica
                double mediaGeometrica = Math.Pow(x * y * z, (1 / 3));
                Console.WriteLine("Média Geométrica:" + mediaGeometrica);
            }
            else if (w == 2)
            {
                // Cálculo da média ponderada
                double mediaPonderada = ((x + 2 * y + 3 * z) / 6);
                Console.WriteLine("Média Ponderada:" + mediaPonderada);
            }
            else if (w == 3)
            {
                // Cálculo da média harmônica
                double reciprocoX = 1 / x;
                double reciprocoY = 1 / y;
                double reciprocoZ = 1 / z;

                double mediaHarmonica = (3 / (reciprocoX + reciprocoY + reciprocoZ));
                Console.WriteLine("Média Harmônica:" + mediaHarmonica);
            }
            else if (w == 4)
            {
                // Cálculo da média aritmética
                double mediaAritmetica = (x + y + z) / 3;
                Console.WriteLine("Média Aritmética:" + mediaAritmetica);
            }
            else
            {
                Console.WriteLine("Valor de w inválido");
            }
            Console.ReadLine();
        }
    }
}
