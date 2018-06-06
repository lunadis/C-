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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void tToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Exerc1 exercicio1 = new Exerc1();
            exercicio1.MdiParent = this;
            exercicio1.Show();
        }
        private void teste2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Exerc2 exercicio2 = new Exerc2();
            exercicio2.MdiParent = this;
            exercicio2.Show();
        }
        private void exercicio3ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Exerc3 exercicio3 = new Exerc3();
            exercicio3.MdiParent = this;
            exercicio3.Show();
        }

        private void exercicio4ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Exerc4 exercicio4 = new Exerc4();
            exercicio4.MdiParent = this;
            exercicio4.Show();
        }

        private void exercicio5ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Exerc5 exercicio5 = new Exerc5();
            exercicio5.MdiParent = this;
            exercicio5.Show();
        }

        private void exercicio6ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Exerc6 exercicio6 = new Exerc6();
            exercicio6.MdiParent = this;
            exercicio6.Show();
        }

        private void exercicio7ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Exerc7 exercicio7 = new Exerc7();
            exercicio7.MdiParent = this;
            exercicio7.Show();
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lblData.Text = "Data:" + DateTime.Now.ToString("dd/mm/yyyy");
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblHora.Text = "hora:" + DateTime.Now.ToString("HH:mm:ss");
        }

        private void arquivosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
