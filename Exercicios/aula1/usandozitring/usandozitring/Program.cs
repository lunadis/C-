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
            string nome = "tiago", sobrenome = "Souza", completo;
            completo = nome + " " + sobrenome;

            Console.WriteLine("1)" + nome + sobrenome);
            Console.WriteLine("2)" + completo);
            Console.WriteLine("3)" + nome + " possui " + nome.Length +  " caracteres");
            Console.WriteLine("4)" + sobrenome + " poussui " + sobrenome.Length + " caracteres");
            Console.WriteLine("5)" + completo + " possui " + completo.Length + " caracteres - incluindo espaços em branco");
            Console.WriteLine("6)" + nome + " em minussculo " + nome.ToLower());
            Console.WriteLine("7)" + nome + " em maisculo " + nome.ToUpper());
            Console.WriteLine("8)" + nome + " é igual a " + sobrenome + " = " + nome.Equals(sobrenome));
            Console.WriteLine("9)" + nome + " substring iniciada na posição 3 e pegando 2 caracteres = " + nome.Substring(2,2));

            Console.ReadKey();
        }
    }
}
