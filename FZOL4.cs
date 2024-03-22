using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace atividade_4_de_13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int Conta;
            double R, N1, N2;

            Console.WriteLine("Menu: ");
            Console.WriteLine("Use 1 para Somar");
            Console.WriteLine("Use 2 para Subtrair");
            Console.WriteLine("Use 3 para Multiplicar");
            Console.WriteLine("Use 4 para Dividir");
            Console.Write("Conta desejada: ");
            Conta = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o primeiro número:");
            numero1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite o segundo número:");
            numero2 = double.Parse(Console.ReadLine());

            switch (Conta)
            {
                case 1:
                    R = N1 + N2;
                    Console.WriteLine(N1 + "+" + N2 + "=" + R);
                    break;
                case 2:
                    R = N1 - N2;
                    Console.WriteLine(N1 + "-" + N2 + "=" + R);
                    break;
                case 3:
                    R = N1 * N2;
                    Console.WriteLine(N1 + "X" + N2 + "=" + R);
                    break;
                case 4:
                    if (N2 == 0)
                    {
                        Console.WriteLine("Erro.");
                    }
                    else
                    {
                        R = N1 / N2;
                        Console.WriteLine(N1 + "/" + N2 + "=" + R);
                    }
                    break;
                default:
                    Console.WriteLine("Opção inválida.");
                    break;
                    
                }
            Console.ReadLine();
            }
    }
}
