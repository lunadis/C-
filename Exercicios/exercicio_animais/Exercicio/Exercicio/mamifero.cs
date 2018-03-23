using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Exercicio
{
    class mamifero : Animal
    {
        private string corPelo;
        private string raca;

        public string getCorPelo()
        {
            return corPelo;
        }
        public void setCrodPelo(String corPelo)
        {
            this.corPelo = corPelo;
        }
        public string getRaca()
        {
            return raca;
        }
        public void setRaca(string raca)
        {
            this.raca = raca;
        }

        public override string ToString()
        {
            return "mamifero{"+"Cor do pelo="+corPelo+"Raça="+raca+'}';
        }

        public override void locomover()
        {
            Console.WriteLine("Andando!");
        }
    
    }
}
