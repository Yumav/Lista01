﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aticidade_9_de_13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //VarDec
            int N;

            Console.Write("Escolha um número entre 0 e 4: ");
            N = int.Parse(Console.ReadLine());

            switch (N)
            {
                case 0:
                    Console.WriteLine("Zero");
                    break;
                case 1:
                    Console.WriteLine("Um");
                    break;
                case 2:
                    Console.WriteLine("Dois");
                    break;
                case 3:
                    Console.WriteLine("Três");
                    break;
                case 4:
                    Console.WriteLine("Quatro");
                    break;
                default:
                    Console.WriteLine("Valor inválido");
                    break;
            }
            Console.ReadLine();
        }
    }
}
