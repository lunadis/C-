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

            string name, cidade;
            int idade;
            Console.Write("Digite seu nome: ");
            name = Console.ReadLine();

            Console.Write(name + " qual a sua idade? ");
            idade = int.Parse(Console.ReadLine());

            Console.Write(name+ " qual a sua cidade? ");
            cidade = Console.ReadLine();

            Console.Write("\n\n {0} tem {1} anos, e mora {2}", name, idade,cidade);

            Console.ReadKey();
           
        }
    }
}
