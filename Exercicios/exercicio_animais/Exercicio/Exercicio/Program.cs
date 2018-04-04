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
           Canguru cang1 = new Canguru();
           Cachorro cao = new Cachorro();
           Tartaruga rafa = new Tartaruga();
           Tucano tuc = new Tucano();

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

           Console.Write("Canguru");
           cang1.usarbolsa();
           cang1.locomover();

           Console.Write("\nCachorro");
           cao.abanarRabo();
           cao.enterrarOsso();
           cao.Reagir(true);

           Console.Write("\nTartaruga");
           rafa.locomover();

           Console.Write("\n\n\n");
           Console.WriteLine(humano.ToString());
           humano.locomover();

           Console.Write("\n\n\n");
           Console.WriteLine(pomba.ToString());
           pomba.fazerNinho();
           pomba.locomover();

           Console.Write("\n\n\n");
           Console.WriteLine(cobra.ToString());
           cobra.alimentar();
           cobra.locomover();

           Console.ReadKey();

        }
    }
}
