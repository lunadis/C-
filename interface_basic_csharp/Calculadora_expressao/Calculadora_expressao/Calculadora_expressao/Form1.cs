using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Calculadora_expressao
{
    public partial class Form1 : Form
    {

        double[] num = new double[5];
        string[] sinal = new string[5];
        int i=0;

        public Form1()
        {
            InitializeComponent();
        }
        private void btn7_Click(object sender, EventArgs e)
        {
            if (visor.Text == "0")
            {
                visor.Text = "7";
            }
            else {
                visor.Text = (visor.Text)+"7";
            }
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            if (visor.Text == "0")
            {
                visor.Text = "8";
            }
            else
            {
                visor.Text = (visor.Text) + "8";
            }
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            if (visor.Text == "0")
            {
                visor.Text = "9";
            }
            else
            {
                visor.Text = (visor.Text) + "9";
            }
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            if (visor.Text == "0")
            {
                visor.Text = "4";
            }
            else
            {
                visor.Text = (visor.Text) + "4";
            }
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            if (visor.Text == "0")
            {
                visor.Text = "5";
            }
            else
            {
                visor.Text = (visor.Text) + "5";
            }
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            if (visor.Text == "0")
            {
                visor.Text = "6";
            }
            else
            {
                visor.Text = (visor.Text) + "6";
            }
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            if (visor.Text == "0")
            {
                visor.Text = "1";
            }
            else
            {
                visor.Text = (visor.Text) + "1";
            }
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            if (visor.Text == "0")
            {
                visor.Text = "2";
            }
            else
            {
                visor.Text = (visor.Text) + "2";
            }
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            if (visor.Text == "0")
            {
                visor.Text = "3";
            }
            else
            {
                visor.Text = (visor.Text) + "3";
            }
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            if (visor.Text == "0")
            {
                visor.Text = "0";
            }
            else
            {
                visor.Text = (visor.Text) + "0";
            }
        }

        private void btnFsoma_Click(object sender, EventArgs e)
        {
                i++;
                num[i] = System.Convert.ToDouble(visor.Text);
                sinal[i] = "+";

                if (exp.Text == "")
                {
                    exp.Text = (visor.Text) + "+";
                }
                else {
                    exp.Text = (exp.Text) + (visor.Text) + '+';
                }

                visor.Text = "0";
         }

        private void btnFdividir_Click(object sender, EventArgs e)
        {
            i++;
            num[i] = System.Convert.ToDouble(visor.Text);
            sinal[i] = "+";

            if (exp.Text == "")
            {
                exp.Text = (visor.Text) + "/";
            }
            else
            {
                exp.Text = (exp.Text) + (visor.Text) + '/';
            }

            visor.Text = "0";
        }

        private void btnFmenos_Click(object sender, EventArgs e)
        {
            i++;
            num[i] = System.Convert.ToDouble(visor.Text);
            sinal[i] = "-";

            if (exp.Text == "")
            {
                exp.Text = (visor.Text) + "-";
            }
            else
            {
                exp.Text = (exp.Text) + (visor.Text) + '-';
            }

            visor.Text = "0";
        }

        private void btnFmult_Click(object sender, EventArgs e)
        {
            i++;
            num[i] = System.Convert.ToDouble(visor.Text);
            sinal[i] = "*";

            if (exp.Text == "")
            {
                exp.Text = (visor.Text) + "*";
            }
            else
            {
                exp.Text = (exp.Text) + (visor.Text) + '*';
            }

            visor.Text = "0";
        }

        private void btnIguals_Click(object sender, EventArgs e)
        {

            double resultado = num[1] + num[2] + num[3] + num[4];
            visor.Text = System.Convert.ToString(resultado);
            exp.Text = "";
            i = 0;
            for (int cont=0; cont <= 4; cont++)
            {
                if (exp.Text.Contains("*")) { 
                              
                }
                num[i] = 0;
                sinal[i] = null;
            }
        }
    }
    }
