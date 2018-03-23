using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Comissionado : Empregado
    {
        private double totalVenda;
        private double taxaComissao;

        public double getTotalVenda() {
            return totalVenda;
        }
        public void setTotalVendas(double totalVenda) {
            this.totalVenda = totalVenda;
        }

        public double getTaxaComissao() {
            return taxaComissao;
        }
        public void setTaxaComissao(double taxaComissao) {
            this.taxaComissao = taxaComissao;
        }

         public override double  Vencimento()
        {
             double venc;
             venc = totalVenda * (taxaComissao/100);
             Console.Write("\n Comissionado \nnome: " + getNome() + "\nSobrenome: " + getSobrenome() + "\nSalario: " + venc + "\n\n");
             return venc;
 	        
        }
        
    }

    }
