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
            int idade;

            Console.Write("Digite sua idade: ");
            idade = int.Parse(Console.ReadLine());

            if (idade >= 18)
            {
                Console.Write("Maior de idade");
            }
            else
            {
                Console.Write("Menor de idade");
            }

            Console.ReadKey();
        }
    }
}
