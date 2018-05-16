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
    public partial class frmMairValorDeTres : Form
    {
        public frmMairValorDeTres()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnVerificar_Click(object sender, EventArgs e)
        {

            double ValorA = System.Convert.ToDouble(txbValorA.Text);
            double ValorB = System.Convert.ToDouble(txbValorB.Text);
            double ValorC = System.Convert.ToDouble(txbValorC.Text);

            if (ValorA > ValorB && ValorA > ValorC)
            {
                lblResposta.Text = "O maior valor é A";
            }
            else if (ValorB > ValorA && ValorB > ValorC)
            {
                lblResposta.Text = "O maior valor é B";
            }
            else if (ValorC > ValorA && ValorC > ValorB)
            {
                lblResposta.Text = "O maior valor é C";
            }
        }
    }
}
