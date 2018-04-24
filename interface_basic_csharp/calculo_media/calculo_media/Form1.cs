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
    public partial class frmMedia : Form
    {
        public frmMedia()
        {
            InitializeComponent();
        }

        private void lbl1Bim_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double value1 = System.Convert.ToDouble(txb1bim.Text);
            double value2 = System.Convert.ToDouble(txb2bim.Text);
            double value3 = System.Convert.ToDouble(txb3bim.Text);
            double value4 = System.Convert.ToDouble(txb4bim.Text);

            double media = (value1 + value2 + value3 + value4) / 4;

            string name = txbName.Text;

            lblName.Text = name;

            lblMedia.Text = "Sua média é: " + media.ToString();
        }
    }
}
