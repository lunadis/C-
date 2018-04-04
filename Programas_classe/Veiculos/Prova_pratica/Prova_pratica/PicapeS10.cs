using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Prova_pratica
{
    class PicapeS10 : Carro
    {

        public override void locomover()
        {
            Console.Write("\nLocomovendo \n Tração nas 4 rodas\n");
        }
        public override void abastecer()
        {
            Console.Write("\nAbastecer: Disel\n");
        }

    }
}
