using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Prova_pratica
{
    class Esquilo : Aeronave
    {
        public override void locomover()
        {
            Console.Write("\nLocomovendo: Helices ligadas\n");
        }
        public override void abastecer()
        {
            Console.Write("\nAbastecendo: Disel\n");
        }
    }
}
