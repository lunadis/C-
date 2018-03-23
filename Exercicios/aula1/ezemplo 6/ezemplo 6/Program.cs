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
            string nome;
            string cidade;

            Console.Write("Digite seu nome: ");
            nome = Console.ReadLine();
            

            Console.Write("Digite o nome da cidade que vc nasceu: ");
            cidade = Console.ReadLine();

            Console.WriteLine("\n\n Seu nome: " + nome);
            Console.WriteLine("Cidade de nascimento: " +cidade);

            Console.ReadKey();


        }
    }
}
