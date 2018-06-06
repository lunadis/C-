using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Exerc2 : Form
    {
        public Exerc2()
        {
            InitializeComponent();
        }

        private void Num_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnfVerf_Click(object sender, EventArgs e)
        {
            int numero1 = 0;
            int[] resultado =  new int[4];


            numero1 = System.Convert.ToInt32(Num.Text);
            for (int c = 0; c <= 3; c++) { 
               switch(c){
                   case 1: resultado[c] = numero1 % 10; break;
                   case 2: resultado[c] = numero1 % 5; break;
                   case 3: resultado[c] = numero1 % 2; break;
                }
            }
            if(resultado[1] != 0){
                label5.Text = "O numero não é divisivel por 10";
            }else{
                label5.Text = "O numero é divisivel por 10";
            }
            
            if (resultado[2] != 0)
            {
                label6.Text = "O numero não é divisivel por 5";
            }
            else
            {
                label6.Text = "O numero é divisivel por 5";
            }
            
            if (resultado[3] != 0)
            {
                label7.Text = "O numero não é divisivel por 2";
            }
            else
            {
                label7.Text = "O numero é divisivel por 2";
            }
            

        }
    }
}
