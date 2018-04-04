using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Prova_pratica
{
    class CB200 : Motocicleta
    {

        public override void locomover()
        {
            Console.Write("\nLocomovendo \n Tração na roda Traseira \n");
        }
        public override void abastecer()
        {
            Console.Write("\nAbastecendo: Alcool\n");
        }
    }
}
