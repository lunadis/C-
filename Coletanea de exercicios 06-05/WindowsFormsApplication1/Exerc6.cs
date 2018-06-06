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
    public partial class Exerc6 : Form
    {
        public Exerc6()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int vz = 0;

            vz = System.Convert.ToInt32(nmvz.Text);
            richTextBox1.Text = "";
            for(int c = 1; c <= vz; c++) {

                if (richTextBox1.Text == "")
                {
                    richTextBox1.Text = System.Convert.ToString(c) + "-Brasil" + "\n";
                }
                else
                {
                    richTextBox1.Text = (richTextBox1.Text) + System.Convert.ToString(c) + "-Brasil" + "\n";
                }
            }
        }
    }
}
