namespace ProbOne1
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.ckb1 = new System.Windows.Forms.CheckBox();
            this.ckb2 = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.txb1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txb2 = new System.Windows.Forms.TextBox();
            this.btn1 = new System.Windows.Forms.Button();
            this.listB1 = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txb3 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // ckb1
            // 
            this.ckb1.AutoSize = true;
            this.ckb1.Location = new System.Drawing.Point(55, 55);
            this.ckb1.Name = "ckb1";
            this.ckb1.Size = new System.Drawing.Size(147, 17);
            this.ckb1.TabIndex = 0;
            this.ckb1.Text = "Número de Possibilidades";
            this.ckb1.UseVisualStyleBackColor = true;
            this.ckb1.CheckedChanged += new System.EventHandler(this.Ckb1_CheckedChanged);
            // 
            // ckb2
            // 
            this.ckb2.AutoSize = true;
            this.ckb2.Location = new System.Drawing.Point(238, 55);
            this.ckb2.Name = "ckb2";
            this.ckb2.Size = new System.Drawing.Size(128, 17);
            this.ckb2.TabIndex = 1;
            this.ckb2.Text = "Valores em Conjuntos";
            this.ckb2.UseVisualStyleBackColor = true;
            this.ckb2.CheckedChanged += new System.EventHandler(this.Ckb2_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(52, 139);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Número de Elementos";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(55, 415);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(669, 23);
            this.progressBar1.TabIndex = 4;
            // 
            // txb1
            // 
            this.txb1.Location = new System.Drawing.Point(55, 164);
            this.txb1.Name = "txb1";
            this.txb1.Size = new System.Drawing.Size(100, 20);
            this.txb1.TabIndex = 5;
            this.txb1.TextChanged += new System.EventHandler(this.Txb1_TextChanged_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(52, 197);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Formato do Agrupamento";
            // 
            // txb2
            // 
            this.txb2.Location = new System.Drawing.Point(55, 225);
            this.txb2.Name = "txb2";
            this.txb2.Size = new System.Drawing.Size(100, 20);
            this.txb2.TabIndex = 7;
            this.txb2.TextChanged += new System.EventHandler(this.Txb2_TextChanged_1);
            // 
            // btn1
            // 
            this.btn1.Font = new System.Drawing.Font("Microsoft Uighur", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn1.Image = ((System.Drawing.Image)(resources.GetObject("btn1.Image")));
            this.btn1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn1.Location = new System.Drawing.Point(238, 331);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(134, 51);
            this.btn1.TabIndex = 10;
            this.btn1.Text = "Arranjo!";
            this.btn1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn1.UseVisualStyleBackColor = true;
            this.btn1.Click += new System.EventHandler(this.Btn1_Click);
            // 
            // listB1
            // 
            this.listB1.FormattingEnabled = true;
            this.listB1.Location = new System.Drawing.Point(468, 27);
            this.listB1.Name = "listB1";
            this.listB1.Size = new System.Drawing.Size(290, 355);
            this.listB1.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(286, 167);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Palavra";
            // 
            // txb3
            // 
            this.txb3.Location = new System.Drawing.Point(220, 190);
            this.txb3.Name = "txb3";
            this.txb3.Size = new System.Drawing.Size(186, 20);
            this.txb3.TabIndex = 13;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txb3);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.listB1);
            this.Controls.Add(this.btn1);
            this.Controls.Add(this.txb2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txb1);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ckb2);
            this.Controls.Add(this.ckb1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Arranjo Fatal";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox ckb1;
        private System.Windows.Forms.CheckBox ckb2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.TextBox txb1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txb2;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.ListBox listB1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txb3;
    }
}

