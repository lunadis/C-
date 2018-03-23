using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Exercicio
{
    class Reptil : Animal
    {
        private string corEscama;

        private string getCorEscama()
        {
            return corEscama;
        }
        public void setCorEscama(string corEscama)
        {
            this.corEscama = corEscama;
        }

        public override string ToString()
        {
            return "Repetil{" + "Cor da Escama="+corEscama+ '}';
        }
        public override void locomover()
        {
            Console.WriteLine("Rastejando!");
        }
    }
}
