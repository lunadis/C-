using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Prova_pratica
{
    class Veiculo
    {
        private string modelo;
        private int ano;
        private int pneu;

        public string getModelo(){
            return modelo;
        }
        public void setModelo(string modelo){
            this.modelo = modelo;
        }

        public int getAno() {
            return ano;
        }
        public void setAno(int ano) {
            this.ano = ano;
        }

        public int getPneu() {
            return pneu;
        }
        public void setPeneu(int pneu) {
            this.pneu = pneu;
        }

        public virtual void locomover() {
            Console.Write("Locomovendo");
        }
        public virtual void abastecer(){
            Console.Write("abastecendo");
        }

    }
}
