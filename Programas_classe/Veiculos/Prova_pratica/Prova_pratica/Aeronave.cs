using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Prova_pratica
{
    class Aeronave : Veiculo
    {
        private string corFuselagem;

        public string getCorFuselagem()
        {
            return corFuselagem;
        }
        public void setCorFuselagem(string corFuselagem)
        {
            this.corFuselagem = corFuselagem;
        }

    }
}
