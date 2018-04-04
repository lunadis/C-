using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Prova_pratica
{
    class Motocicleta : Veiculo
    {

        private string corMotocicleta;

        public string getCorMotocicleta()
        {
            return corMotocicleta;
        }
        public void setCorMotocicleta(string corMotocicleta)
        {
            this.corMotocicleta = corMotocicleta;
        }

    }
}
