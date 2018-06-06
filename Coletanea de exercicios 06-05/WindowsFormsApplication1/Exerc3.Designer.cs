namespace WindowsFormsApplication1
{
    partial class Exerc3
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
            this.labela = new System.Windows.Forms.Label();
            this.labalb = new System.Windows.Forms.Label();
            this.labelc = new System.Windows.Forms.Label();
            this.ladoA = new System.Windows.Forms.TextBox();
            this.ladoB = new System.Windows.Forms.TextBox();
            this.ladoC = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.resultado = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labela
            // 
            this.labela.AutoSize = true;
            this.labela.Location = new System.Drawing.Point(21, 49);
            this.labela.Name = "labela";
            this.labela.Size = new System.Drawing.Size(14, 13);
            this.labela.TabIndex = 0;
            this.labela.Text = "A";
            // 
            // labalb
            // 
            this.labalb.AutoSize = true;
            this.labalb.Location = new System.Drawing.Point(21, 81);
            this.labalb.Name = "labalb";
            this.labalb.Size = new System.Drawing.Size(14, 13);
            this.labalb.TabIndex = 1;
            this.labalb.Text = "B";
            // 
            // labelc
            // 
            this.labelc.AutoSize = true;
            this.labelc.Location = new System.Drawing.Point(21, 108);
            this.labelc.Name = "labelc";
            this.labelc.Size = new System.Drawing.Size(14, 13);
            this.labelc.TabIndex = 2;
            this.labelc.Text = "C";
            // 
            // ladoA
            // 
            this.ladoA.Location = new System.Drawing.Point(41, 46);
            this.ladoA.Name = "ladoA";
            this.ladoA.Size = new System.Drawing.Size(81, 20);
            this.ladoA.TabIndex = 3;
            // 
            // ladoB
            // 
            this.ladoB.Location = new System.Drawing.Point(41, 78);
            this.ladoB.Name = "ladoB";
            this.ladoB.Size = new System.Drawing.Size(81, 20);
            this.ladoB.TabIndex = 4;
            // 
            // ladoC
            // 
            this.ladoC.Location = new System.Drawing.Point(41, 105);
            this.ladoC.Name = "ladoC";
            this.ladoC.Size = new System.Drawing.Size(81, 20);
            this.ladoC.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(76, 149);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(86, 29);
            this.button1.TabIndex = 6;
            this.button1.Text = "Verificar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Exercicio 3: triangulo";
            // 
            // resultado
            // 
            this.resultado.AutoSize = true;
            this.resultado.Location = new System.Drawing.Point(20, 219);
            this.resultado.Name = "resultado";
            this.resultado.Size = new System.Drawing.Size(0, 13);
            this.resultado.TabIndex = 8;
            // 
            // Exerc3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.resultado);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.ladoC);
            this.Controls.Add(this.ladoB);
            this.Controls.Add(this.ladoA);
            this.Controls.Add(this.labelc);
            this.Controls.Add(this.labalb);
            this.Controls.Add(this.labela);
            this.Name = "Exerc3";
            this.Text = "Exerc3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labela;
        private System.Windows.Forms.Label labalb;
        private System.Windows.Forms.Label labelc;
        private System.Windows.Forms.TextBox ladoA;
        private System.Windows.Forms.TextBox ladoB;
        private System.Windows.Forms.TextBox ladoC;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label resultado;
    }
}