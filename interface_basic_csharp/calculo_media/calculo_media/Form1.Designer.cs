namespace WindowsFormsApplication1
{
    partial class frmMedia
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
            this.lblNome = new System.Windows.Forms.Label();
            this.txbName = new System.Windows.Forms.TextBox();
            this.lbl1Bim = new System.Windows.Forms.Label();
            this.lbl2bim = new System.Windows.Forms.Label();
            this.lbl3Bim = new System.Windows.Forms.Label();
            this.lbl4Bim = new System.Windows.Forms.Label();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.lblName = new System.Windows.Forms.Label();
            this.lblMedia = new System.Windows.Forms.Label();
            this.txb1bim = new System.Windows.Forms.TextBox();
            this.txb2bim = new System.Windows.Forms.TextBox();
            this.txb3bim = new System.Windows.Forms.TextBox();
            this.txb4bim = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(25, 37);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(82, 13);
            this.lblNome.TabIndex = 0;
            this.lblNome.Text = "Nome do aluno:";
            // 
            // txbName
            // 
            this.txbName.Location = new System.Drawing.Point(112, 34);
            this.txbName.Name = "txbName";
            this.txbName.Size = new System.Drawing.Size(148, 20);
            this.txbName.TabIndex = 1;
            // 
            // lbl1Bim
            // 
            this.lbl1Bim.AutoSize = true;
            this.lbl1Bim.Location = new System.Drawing.Point(25, 94);
            this.lbl1Bim.Name = "lbl1Bim";
            this.lbl1Bim.Size = new System.Drawing.Size(34, 13);
            this.lbl1Bim.TabIndex = 2;
            this.lbl1Bim.Text = "1ºBim";
            this.lbl1Bim.Click += new System.EventHandler(this.lbl1Bim_Click);
            // 
            // lbl2bim
            // 
            this.lbl2bim.AutoSize = true;
            this.lbl2bim.Location = new System.Drawing.Point(25, 143);
            this.lbl2bim.Name = "lbl2bim";
            this.lbl2bim.Size = new System.Drawing.Size(34, 13);
            this.lbl2bim.TabIndex = 3;
            this.lbl2bim.Text = "2ºBim";
            // 
            // lbl3Bim
            // 
            this.lbl3Bim.AutoSize = true;
            this.lbl3Bim.Location = new System.Drawing.Point(186, 94);
            this.lbl3Bim.Name = "lbl3Bim";
            this.lbl3Bim.Size = new System.Drawing.Size(34, 13);
            this.lbl3Bim.TabIndex = 4;
            this.lbl3Bim.Text = "3ºBim";
            // 
            // lbl4Bim
            // 
            this.lbl4Bim.AutoSize = true;
            this.lbl4Bim.Location = new System.Drawing.Point(186, 143);
            this.lbl4Bim.Name = "lbl4Bim";
            this.lbl4Bim.Size = new System.Drawing.Size(34, 13);
            this.lbl4Bim.TabIndex = 5;
            this.lbl4Bim.Text = "4ºBim";
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(112, 182);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(102, 31);
            this.btnCalcular.TabIndex = 6;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(147, 236);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(10, 13);
            this.lblName.TabIndex = 7;
            this.lblName.Text = "-";
            this.lblName.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblMedia
            // 
            this.lblMedia.AutoSize = true;
            this.lblMedia.Location = new System.Drawing.Point(147, 268);
            this.lblMedia.Name = "lblMedia";
            this.lblMedia.Size = new System.Drawing.Size(10, 13);
            this.lblMedia.TabIndex = 8;
            this.lblMedia.Text = "-";
            // 
            // txb1bim
            // 
            this.txb1bim.Location = new System.Drawing.Point(63, 91);
            this.txb1bim.Name = "txb1bim";
            this.txb1bim.Size = new System.Drawing.Size(94, 20);
            this.txb1bim.TabIndex = 9;
            // 
            // txb2bim
            // 
            this.txb2bim.Location = new System.Drawing.Point(65, 140);
            this.txb2bim.Name = "txb2bim";
            this.txb2bim.Size = new System.Drawing.Size(92, 20);
            this.txb2bim.TabIndex = 10;
            this.txb2bim.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // txb3bim
            // 
            this.txb3bim.Location = new System.Drawing.Point(226, 91);
            this.txb3bim.Name = "txb3bim";
            this.txb3bim.Size = new System.Drawing.Size(87, 20);
            this.txb3bim.TabIndex = 11;
            // 
            // txb4bim
            // 
            this.txb4bim.Location = new System.Drawing.Point(226, 140);
            this.txb4bim.Name = "txb4bim";
            this.txb4bim.Size = new System.Drawing.Size(84, 20);
            this.txb4bim.TabIndex = 12;
            // 
            // frmMedia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(354, 324);
            this.Controls.Add(this.txb4bim);
            this.Controls.Add(this.txb3bim);
            this.Controls.Add(this.txb2bim);
            this.Controls.Add(this.txb1bim);
            this.Controls.Add(this.lblMedia);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.lbl4Bim);
            this.Controls.Add(this.lbl3Bim);
            this.Controls.Add(this.lbl2bim);
            this.Controls.Add(this.lbl1Bim);
            this.Controls.Add(this.txbName);
            this.Controls.Add(this.lblNome);
            this.Name = "frmMedia";
            this.Text = "Cálculo de Média";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.TextBox txbName;
        private System.Windows.Forms.Label lbl1Bim;
        private System.Windows.Forms.Label lbl2bim;
        private System.Windows.Forms.Label lbl3Bim;
        private System.Windows.Forms.Label lbl4Bim;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblMedia;
        private System.Windows.Forms.TextBox txb1bim;
        private System.Windows.Forms.TextBox txb2bim;
        private System.Windows.Forms.TextBox txb3bim;
        private System.Windows.Forms.TextBox txb4bim;
    }
}

