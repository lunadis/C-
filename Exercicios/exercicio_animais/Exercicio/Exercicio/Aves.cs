using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Exercicio
{
    class Aves : Animal
    {
        private string corPena;


        public void fazerNinho()
        {
            Console.WriteLine("Fazendo ninho!");
        }

        public string getCorPena()
        {
            return corPena;
        }
        public void setCorPena(string corPena)
        {
            this.corPena = corPena;
        }
        public override void locomover()
        {
            Console.WriteLine("Voado!");
        }

        public override string ToString()
        {
            return "Aves{" + "Cor das penas=" + corPena +'}';
        }
    }
}
