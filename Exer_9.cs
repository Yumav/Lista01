using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercício9
{
    class Program
    {
        static void Main(string[] args)
        {
            //Vardec
            float Sal, Emp, porcent;

            //Ler sálario
            Console.Write("Qual o seu sálario?: ");
            Sal = float.Parse(Console.ReadLine());

            //Ler empréstimo
            Console.Write("Qual o valor da prestação do empréstimo desejado?: ");
            Emp = float.Parse(Console.ReadLine());

            //Calculo chato
            porcent = (Sal / 100) * 20; 

            //Verificação e print
            if (porcent >= Emp)
            {
                Console.Write("O empréstimo é aceitavel");
            }
            else Console.Write("O empréstimo não é possível");

            Console.ReadLine();


        } 
    }
}
