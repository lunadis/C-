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
    public partial class frmTeste1 : Form
    {
        public frmTeste1()
        {
            InitializeComponent();
        }

        private void frmTeste1_Load(object sender, EventArgs e)
        { 
        }

        private void frmTeste1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("deseja sair?", "titulo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes) MessageBox.Show("saindo");
            else
            {
                MessageBox.Show("ficando");
                e.Cancel = true;
            }
        }
    }
}
