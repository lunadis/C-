using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            bool i, j;

            Console.WriteLine("Exemplo - Operadores Lógicos");
            Console.WriteLine("******************************\n\n");
            Console.WriteLine("Digite true(verdadeiro) ou false(falso)\n");

            Console.Write("valor lógico 1: "); i = Boolean.Parse(Console.ReadLine());
            Console.Write("valor lógico 2: "); j = Boolean.Parse(Console.ReadLine());

            Console.WriteLine("\n Resultados testando os operadores lógicos \n");
            Console.WriteLine("{0} AND {1} resulta {2}", i, j, i && j);
            Console.WriteLine("{0} OR {1} resulta {2}", i, j, i && j);
            Console.WriteLine("Valor 1: NOT {0} resulta {1}", i, !i);
            Console.WriteLine("valor 2: NOT {0} resulta {1}", j, !j);

            Console.ReadKey();

        }
    }
}
