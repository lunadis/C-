using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Prova_pratica
{
    class Carro : Veiculo
    {

        private string corCarro;



        public string getCorCarro()
        {
            return corCarro;
        }
        public void setCorCarro(string corCarro)
        {
            this.corCarro = corCarro;
        }


    }
}
