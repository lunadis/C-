namespace WindowsFormsApplication1
{
    partial class Exerc1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.num1 = new System.Windows.Forms.TextBox();
            this.num2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnfcalcular = new System.Windows.Forms.Button();
            this.result = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Exercicio 1";
            // 
            // num1
            // 
            this.num1.Location = new System.Drawing.Point(71, 62);
            this.num1.Name = "num1";
            this.num1.Size = new System.Drawing.Size(82, 20);
            this.num1.TabIndex = 1;
            // 
            // num2
            // 
            this.num2.Location = new System.Drawing.Point(70, 97);
            this.num2.Name = "num2";
            this.num2.Size = new System.Drawing.Size(82, 20);
            this.num2.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Numero 1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Numero 2";
            // 
            // btnfcalcular
            // 
            this.btnfcalcular.Location = new System.Drawing.Point(70, 153);
            this.btnfcalcular.Name = "btnfcalcular";
            this.btnfcalcular.Size = new System.Drawing.Size(115, 29);
            this.btnfcalcular.TabIndex = 5;
            this.btnfcalcular.Text = "Calcular";
            this.btnfcalcular.UseVisualStyleBackColor = true;
            this.btnfcalcular.Click += new System.EventHandler(this.btnfcalcular_Click);
            // 
            // result
            // 
            this.result.AutoSize = true;
            this.result.Location = new System.Drawing.Point(98, 209);
            this.result.Name = "result";
            this.result.Size = new System.Drawing.Size(55, 13);
            this.result.TabIndex = 6;
            this.result.Text = "Resultado";
            // 
            // Exerc1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.result);
            this.Controls.Add(this.btnfcalcular);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.num2);
            this.Controls.Add(this.num1);
            this.Controls.Add(this.label1);
            this.Name = "Exerc1";
            this.Text = "frmTeste1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox num1;
        private System.Windows.Forms.TextBox num2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnfcalcular;
        private System.Windows.Forms.Label result;
    }
}