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
        double[] resultado = new double[4];
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
            sinal[i] = "/";

            if (exp.Text == "")
            {
                exp.Text = (visor.Text) + "/";
            }
            else
            {
                exp.Text = (exp.Text) + (visor.Text) + "/";
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
            i++;
            num[i] = System.Convert.ToDouble(visor.Text);

            if (exp.Text == "")
            {
                exp.Text = (visor.Text) + "/";
            }
            else
            {
                exp.Text = (exp.Text) + (visor.Text);
            }

            // usei os switchs para fazer a distinção dos operadores
            switch (sinal[1]) {
                case "+": resultado[1] = num[1] + num[2]; break;
                case "*": resultado[1] = num[1] * num[2]; break;
                case "/": resultado[1] = num[1] / num[2]; break;
                case "-": resultado[1] = num[1] - num[2]; break;
                   
            }
            Console.WriteLine(resultado[1]);
            switch (sinal[3])
            {
                case "+": resultado[2] = num[3] + num[4]; break;
                case "*": resultado[2] = num[3] * num[4]; break;
                case "/": resultado[2] = num[3] / num[4]; break;
                case "-": resultado[2] = num[3] - num[4]; break;
                    
            }
            Console.WriteLine(resultado[2]);
          
                switch (sinal[2])
                {
                    case "+": resultado[3] = resultado[1] + resultado[2]; break;
                    case "*": resultado[3] = resultado[1] * resultado[2]; break;
                    case "/": resultado[3] = resultado[1] / resultado[2]; break;
                    case "-": resultado[3] = resultado[1] - resultado[2]; break;

                }
                Console.WriteLine(resultado[3]);
                Console.WriteLine(sinal[1]);
                Console.WriteLine(sinal[2]);
                Console.WriteLine(sinal[3]);

            visor.Text = System.Convert.ToString(resultado[3]);
           
        }

        private void btnC_Click(object sender, EventArgs e)
        {
            while (i > 0) {
                i--;
                resultado[i] = 0;
                sinal[i] = "";
            }
            visor.Text = "0";
            exp.Text = "";
           
        }
    }
    }
