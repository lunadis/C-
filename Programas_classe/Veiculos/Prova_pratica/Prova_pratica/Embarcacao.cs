using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Prova_pratica
{
    class Embarcacao : Veiculo
    {
        private string corCasco;

        public string getCorCasco()
        {
            return corCasco;
        }
        public void setCorCasco(string corCasco)
        {
            this.corCasco = corCasco;
        }

    }
}
