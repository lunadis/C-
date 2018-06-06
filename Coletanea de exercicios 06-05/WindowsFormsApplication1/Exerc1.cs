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
    public partial class Exerc1 : Form
    {
        public Exerc1()
        {
            InitializeComponent();
        }

        private void Exerc1_Load(object sender, EventArgs e)
        { 
        }

        private void Exerc1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("deseja sair?", "titulo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes) MessageBox.Show("saindo");
            else
            {
                MessageBox.Show("ficando");
                e.Cancel = true;
            }
        }

        private void btnfcalcular_Click(object sender, EventArgs e)
        {
            double n1 = 0, n2 = 0, resultado = 0;

            n1 = System.Convert.ToDouble(num1.Text);
            n2 = System.Convert.ToDouble(num2.Text);


            resultado = n1 + n2;

            if (resultado > 20)
            {
                resultado = resultado + 8;
            }
            else {
                resultado = resultado - 5;
            }

            result.Text = System.Convert.ToString(resultado);
        }
    }
}
