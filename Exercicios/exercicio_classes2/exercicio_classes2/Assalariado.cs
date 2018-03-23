using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Assalariado : Empregado
    {
        private double salario;


        public void setSalario(double salario) {
            this.salario=salario;
        }
        public double getSlario() {
            return salario;
        }

        public override double Vencimento()
        {
            Console.Write("\n Assalariado \nnome: " + getNome() + "\nSobrenome: " + getSobrenome() + "\nSalario: " + salario + "\n\n");
            return salario;
        }
    }
}
