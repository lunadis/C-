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
            int a=0, b;

            b = int.Parse(Console.ReadLine());
            a = b * 2;
            Console.Write("O dobro de {0} é {1}", b, a);

            Console.ReadKey();
        }
    }
}
