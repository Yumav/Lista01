using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_de_13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int Conversor;
            double Val, R;

            Console.WriteLine("### Menu de Conversão de Unidades ###");
            Console.WriteLine("1. Converter de centímetros para metros");
            Console.WriteLine("2. Converter de metros para centímetros");
            Console.WriteLine("3. Converter de milímetros para metros");
            Console.WriteLine("4. Converter de metros para milímetros");
            Console.Write("\nDigite a sua opção: ");
            Conversor = int.Parse(Console.ReadLine());

            switch (Conversor)
            {
                case 1:
                    Console.WriteLine("Digite o valor em centímetros:");
                    Val = double.Parse(Console.ReadLine());
                    R = Val / 100;
                    Console.WriteLine(Val + " centímetros equivalem a " + R + " metros");
                    break;
                case 2:
                    Console.WriteLine("Digite o valor em metros:");
                    Val = double.Parse(Console.ReadLine());
                    R = Val * 100;
                    Console.WriteLine(Val + " metros equivalem a " + R + " centímetros");
                    break;
                case 3:
                    Console.WriteLine("Digite o valor em milímetros:");
                    Val = double.Parse(Console.ReadLine());
                    R = Val / 1000;
                    Console.WriteLine(Val + " milímetros equivalem a " + R + " metros");
                    break;
                case 4:
                    Console.WriteLine("Digite o valor em metros:");
                    Val = double.Parse(Console.ReadLine());
                    R = Val * 1000;
                    Console.WriteLine(Val + " metros equivalem a " + R + " milímetros");
                    break;
                default:
                    Console.WriteLine("Opção inválida");
                    break;
            }
            Console.ReadLine();
        }
    }
}
