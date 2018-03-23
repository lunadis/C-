using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Horista : Empregado
    {
        private double precoHora;
        private double horasTrabalhadas;

        public double getPrecoHora() {
            return precoHora;
        }
        public void setPrecoHora(double precoHora) {
            this.precoHora = precoHora;
        }

        public double getHorasTrabalhadas() {
            return horasTrabalhadas;
        }
        public void setHorasTrabalhadas(double horasTrabalhadas) {
            this.horasTrabalhadas = horasTrabalhadas;
        }

        public override double Vencimento()
        {
            
            double venc;
            venc = precoHora * horasTrabalhadas;
            Console.Write("\n Horista \nnome: "+getNome()+"\nSobrenome: "+getSobrenome()+"\nSalario: "+venc+"\n\n");
            return venc;
        }
        
   }
}
