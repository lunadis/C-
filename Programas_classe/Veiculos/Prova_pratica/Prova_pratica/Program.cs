using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Prova_pratica
{
    class Program
    {
        static void Main(string[] args)
        {

            Caiaque cai = new Caiaque();
            CB200 moto = new CB200();
            Esquilo aero1 = new Esquilo();
            Fusca carro1 = new Fusca();
            PicapeS10 carro2 = new PicapeS10();
            Legacy450 aero2 = new Legacy450();

            Console.Write("Caique");
            cai.abastecer();
            cai.locomover();

            Console.ReadKey();

            Console.Write("\n\n");

            Console.Write("CB200");
            moto.abastecer();
            moto.locomover();

            Console.ReadKey();

            Console.Write("\n\n");

            Console.Write("Fusca");
            carro1.abastecer();
            carro1.locomover();

            Console.Write("\n\n");
            Console.ReadKey();
            Console.Write("Picap S10");
            carro2.abastecer();
            carro2.locomover();

            Console.Write("\n\n");
            Console.ReadKey();
            Console.Write("Esquilo");
            aero1.abastecer();
            aero1.locomover();

            Console.Write("\n\n");
            Console.ReadKey();
            Console.Write("Legacy450");
            aero2.abastecer();
            aero2.decolar("sol");
            aero2.decolar(false);
            aero2.decolar(10);
            aero2.locomover();


            Console.ReadKey();

        }
    }
}
