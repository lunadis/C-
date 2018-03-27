using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Exercicio
{
    class Canguru : mamifero
    {
        public override void locomover()
        {
            Console.Write("Pulando!\n");
        }

        public void usarbolsa() 
        {
            Console.Write("\nUsando bolsa\n");
        }
    }
}
