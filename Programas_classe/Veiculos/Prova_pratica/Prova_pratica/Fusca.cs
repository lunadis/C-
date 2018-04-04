using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Prova_pratica
{
    class Fusca : Carro
    {

        public override void locomover()
        {
            Console.Write("\nLOCOMOVENDO \n Tração duas rodas \n");
        }
        public override void abastecer()
        {
            Console.Write("\nAbastecendo GASOLINA\n");
        }
    }
}
