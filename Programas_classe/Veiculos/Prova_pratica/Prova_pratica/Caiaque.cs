using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Prova_pratica
{
    class Caiaque : Embarcacao
    {
        public override void locomover()
        {
            Console.Write("\nLocomovendo \n A remo\n");
        }
        public override void abastecer()
        {
            Console.Write("\nDepende da força do REMADOR\n");
        }
    }
}
