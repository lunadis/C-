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
    public partial class Exerc5 : Form
    {
        public Exerc5()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int nm1 = 0;

            nm1 = System.Convert.ToInt32(nmNum.Text);
            richTextBox1.Text = "";
            for(int c = 0; c <= nm1; c++) {

                if (richTextBox1.Text == "")
                {
                    richTextBox1.Text = System.Convert.ToString(c) + "\n";
                }
                else
                {
                    richTextBox1.Text = (richTextBox1.Text) + System.Convert.ToString(c) + "\n";
                }
            }

        }
    }
}
