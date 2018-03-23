using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Exercicio
{
    class Program
    {
        static void Main(string[] args)
        {
            Reptil cobra = new Reptil();
           Aves pomba = new Aves();
           mamifero humano = new mamifero();

           cobra.setPeso(7.500f);
           cobra.setCorEscama("Preta");
           cobra.setIdade(11);
           
          

         
           pomba.setCorPena("branca");
           pomba.setIdade(7);
           pomba.setPeso(2.600f);
           pomba.setMembros(2);
           

           humano.setCrodPelo("preto");
           humano.setIdade(22);
           humano.setMembros(4);
           humano.setPeso(112.600f);
           humano.setRaca("Humano");
           

           Console.WriteLine(humano.ToString());
           humano.locomover();
           Console.WriteLine(pomba.ToString());
           pomba.fazerNinho();
           pomba.locomover();
           Console.WriteLine(cobra.ToString());
           cobra.alimentar();
           cobra.locomover();

           Console.ReadKey();

        }
    }
}
