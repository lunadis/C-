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
    public partial class Exerc4 : Form
    {
        public Exerc4()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int mes=0;

            mes = System.Convert.ToInt32(nmmes.Text);
            switch (mes) {
                case 1: label3.Text = "Janeiro"; break;
                case 2: label3.Text = "Fevereiro"; break;
                case 3: label3.Text = "Março"; break;
                case 4: label3.Text = "Abril"; break;
                case 5: label3.Text = "Maio"; break;
                case 6: label3.Text = "Junho"; break;
                case 7: label3.Text = "Julho"; break;
                case 8: label3.Text = "Agosto"; break;
                case 9: label3.Text = "Setembro"; break;
                case 10: label3.Text = "Outubro"; break;
                case 11: label3.Text = "Novembro"; break;
                case 12: label3.Text = "Dezembro"; break;
                default: label4.Text = "Não existe mes que corresponde a esse numero"; break;
            }
        }
    }
}
