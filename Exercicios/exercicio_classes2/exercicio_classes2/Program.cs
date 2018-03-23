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
            Assalariado emp1 = new Assalariado();
            Comissionado emp2 = new Comissionado();
            Horista emp3  = new Horista();


            emp1.setNome("Luis");
            emp1.setCpf("44256565");
            emp1.setSalario(1400.23);
            emp1.setSobrenome("Lopes");


            emp2.setNome("Saraha");
            emp2.setSobrenome("Souza");
            emp2.setCpf("2514654631");
            emp2.setTaxaComissao(12);
            emp2.setTotalVendas(1400.20);

            emp3.setNome("Paloma");
            emp3.setSobrenome("Ranger");
            emp3.setCpf("4554664");
            emp3.setPrecoHora(45.00);
            emp3.setHorasTrabalhadas(44);

            emp1.Vencimento();
            emp2.Vencimento();
            emp3.Vencimento();

            Console.Write(emp3.Vencimento()); // printa apenas o return do metodo
            
            Console.ReadKey();


        }
    }
}
