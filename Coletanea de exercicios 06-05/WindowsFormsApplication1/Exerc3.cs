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
    public partial class Exerc3 : Form
    {
        public Exerc3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int a = 0, b = 0, c = 0;

            a = System.Convert.ToInt32(ladoA.Text);
            b = System.Convert.ToInt32(ladoB.Text);
            c = System.Convert.ToInt32(ladoC.Text);

            if (a == b && a == c && b == c){
                resultado.Text = "Essas medidas correspondem a um Equilatero";
            }
            else if ((a == b & a != c) || (a == c && a != b) || (b == c & a != c))
            {
                resultado.Text = "Essas medidas correspondem a um Isóceles";
            }
            else {
                resultado.Text = "Essas medidas correspondem a um Escaleno";
            }
        }
    }
}
