using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace atividade_5_de_13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //VarDec
            int ID;
            
            //Ler idade
            Console.Write("Digite a idade do nadador:");
            idade = int.Parse(Console.ReadLine());

            if (ID >= 5 && ID <= 7)
            {
                Console.WriteLine("Categoria: Infantil A");
            }
            else if (ID >= 8 && ID <= 10)
            {
                Console.WriteLine("Categoria: Infantil B");
            }
            else if (ID >= 11 && ID <= 13)
            {
                Console.WriteLine("Categoria: Juvenil A");
            }
            else if (ID >= 14 && ID <= 17)
            {
                Console.WriteLine("Categoria: Juvenil B");
            }
            else if (ID > 17)
            {
                Console.WriteLine("Categoria: Sênior");
            }
            else
            {
                Console.WriteLine("Idade inválida");
            }
            Console.ReadLine();
        }
    }
}
