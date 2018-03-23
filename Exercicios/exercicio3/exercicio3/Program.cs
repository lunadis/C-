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
            double a, r;
            
            a = double.Parse(Console.ReadLine());

            r = Math.Pow(a, 2); // Metodo não funciona com inteiros?

            Console.Write("Resultado de {0} ao quadrado é {1}", a, r);

            Console.ReadKey();
        }
    }
}
