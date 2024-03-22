using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercício_3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Vardec
            int idade, tempoHabilitacao;
            char tipoHabilitacao;


            //Leitura
            Console.Write("Qual a idade?: ");
            idade = int.Parse(Console.ReadLine());

            Console.Write("Qual o tempo de habilitação?: ");
            tempoHabilitacao = int.Parse(Console.ReadLine());

            Console.Write("Qual o tipo de carteira?: ");
            tipoHabilitacao = char.Parse(Console.ReadLine());
            {
                if (idade < 21)
                {
                    Console.WriteLine("Idade mínima de 21 anos não alcançada.");
                }
                else if (tipoHabilitacao != 'B' && tipoHabilitacao != 'C')
                {
                    Console.WriteLine("Você precisa ter habilitação nas categorias B ou C para obter a categoria D.");
                }
                else if (tipoHabilitacao == 'B' && tempoHabilitacao < 2)
                {
                    Console.WriteLine("Você precisa ter pelo menos 2 anos de habilitação na categoria B.");
                }
                else if (tipoHabilitacao == 'C' && tempoHabilitacao < 1)
                {
                    Console.WriteLine("Você precisa ter pelo menos 1 ano de habilitação na categoria C.");
                }
                else
                {
                    Console.WriteLine("Você possui os requisitos necessários para obter a carteira de habilitação do tipo D.");
                }
                Console.ReadLine();
            }

        }
    }
}