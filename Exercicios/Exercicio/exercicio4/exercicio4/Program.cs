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
            double a, b, c, r;
            Console.Write("Ditie o valor de A: "); a = double.Parse(Console.ReadLine());
            Console.Write("Ditie o valor de B: "); b = double.Parse(Console.ReadLine());
            Console.Write("Ditie o valor de C: "); c = double.Parse(Console.ReadLine());

            r = (Math.Pow(a, 2)) * 5 - c / (b - a % 4);

            Console.Write(r);

            Console.ReadKey();

        }
    }
}
