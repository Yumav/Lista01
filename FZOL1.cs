using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercício1
{
    class Program
    {
        static void Main(string[] args)
        {
            //VarDec
            int ID1, ID2, ID3, IDMn, IDM;


            //Ler idade
            Console.Write("Qual a idade 1?: ");
            ID1 = int.Parse(Console.ReadLine());

            IDM = ID1;
            IDMn = ID1;

            Console.Write("Qual a idade 2?: ");
            ID2 = int.Parse(Console.ReadLine());
            
            if (ID2 > IDM)
                IDM = ID2;
            if(ID2 < IDMn)
                IDMn = ID2;

            Console.Write("Qual a idade 3?: ");
            ID3 = int.Parse(Console.ReadLine());

            if (ID3 > IDM)
                IDM = ID3;
            if (ID3 < IDMn)
                IDMn = ID3;

            //Print
            Console.WriteLine("A idade menor é: " + IDMn);
            Console.WriteLine("E a maior é: " + IDM);


            Console.ReadLine();
        }
    }
}
