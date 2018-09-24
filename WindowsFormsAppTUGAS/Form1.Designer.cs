namespace WindowsFormsAppTUGAS
{
    partial class Form1
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNilaiA = new System.Windows.Forms.TextBox();
            this.txtHasil = new System.Windows.Forms.TextBox();
            this.txtNilaiB = new System.Windows.Forms.TextBox();
            this.CO = new System.Windows.Forms.ComboBox();
            this.Hitung = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Operasi";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "NIlai A";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nilai B";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(31, 103);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Hasil";
            // 
            // txtNilaiA
            // 
            this.txtNilaiA.Location = new System.Drawing.Point(83, 37);
            this.txtNilaiA.Name = "txtNilaiA";
            this.txtNilaiA.Size = new System.Drawing.Size(112, 20);
            this.txtNilaiA.TabIndex = 4;
            // 
            // txtHasil
            // 
            this.txtHasil.Location = new System.Drawing.Point(83, 100);
            this.txtHasil.Name = "txtHasil";
            this.txtHasil.Size = new System.Drawing.Size(112, 20);
            this.txtHasil.TabIndex = 5;
            // 
            // txtNilaiB
            // 
            this.txtNilaiB.Location = new System.Drawing.Point(83, 67);
            this.txtNilaiB.Name = "txtNilaiB";
            this.txtNilaiB.Size = new System.Drawing.Size(112, 20);
            this.txtNilaiB.TabIndex = 6;
            // 
            // CO
            // 
            this.CO.FormattingEnabled = true;
            this.CO.Items.AddRange(new object[] {
            "Penjumlahan",
            "Pengurangan",
            "Perkalian",
            "Pembagian"});
            this.CO.Location = new System.Drawing.Point(82, 7);
            this.CO.Name = "CO";
            this.CO.Size = new System.Drawing.Size(113, 21);
            this.CO.TabIndex = 7;
            // 
            // Hitung
            // 
            this.Hitung.Location = new System.Drawing.Point(120, 126);
            this.Hitung.Name = "Hitung";
            this.Hitung.Size = new System.Drawing.Size(75, 23);
            this.Hitung.TabIndex = 8;
            this.Hitung.Text = "Hitung";
            this.Hitung.UseVisualStyleBackColor = true;
            this.Hitung.Click += new System.EventHandler(this.Hitung_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.Hitung);
            this.Controls.Add(this.CO);
            this.Controls.Add(this.txtNilaiB);
            this.Controls.Add(this.txtHasil);
            this.Controls.Add(this.txtNilaiA);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtNilaiA;
        private System.Windows.Forms.TextBox txtHasil;
        private System.Windows.Forms.TextBox txtNilaiB;
        private System.Windows.Forms.ComboBox CO;
        private System.Windows.Forms.Button Hitung;
    }
}

