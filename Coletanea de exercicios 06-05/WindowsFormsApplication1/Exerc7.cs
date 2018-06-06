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
    public partial class Exerc7 : Form
    {
        public Exerc7()
        {
            InitializeComponent();
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double A = 1.5, M = 1.10;
            int c = 1;
            while(M<A){
                c++;
                M = M + 0.2;
            }

            lblAno.Text = System.Convert.ToString(c);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
