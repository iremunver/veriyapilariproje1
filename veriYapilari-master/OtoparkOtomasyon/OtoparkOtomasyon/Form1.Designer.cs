namespace OtoparkOtomasyon
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
            this.lblPlaka = new System.Windows.Forms.Label();
            this.txtPlaka = new System.Windows.Forms.TextBox();
            this.btnGiris = new System.Windows.Forms.Button();
            this.btnCikis = new System.Windows.Forms.Button();
            this.btnListele = new System.Windows.Forms.Button();
            this.lBoxListele = new System.Windows.Forms.ListBox();
            this.btnOncelik = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblPlaka
            // 
            this.lblPlaka.AutoSize = true;
            this.lblPlaka.Location = new System.Drawing.Point(26, 33);
            this.lblPlaka.Name = "lblPlaka";
            this.lblPlaka.Size = new System.Drawing.Size(41, 13);
            this.lblPlaka.TabIndex = 0;
            this.lblPlaka.Text = "PLAKA";
            // 
            // txtPlaka
            // 
            this.txtPlaka.Location = new System.Drawing.Point(125, 25);
            this.txtPlaka.Name = "txtPlaka";
            this.txtPlaka.Size = new System.Drawing.Size(100, 20);
            this.txtPlaka.TabIndex = 1;
            // 
            // btnGiris
            // 
            this.btnGiris.Location = new System.Drawing.Point(29, 86);
            this.btnGiris.Name = "btnGiris";
            this.btnGiris.Size = new System.Drawing.Size(75, 23);
            this.btnGiris.TabIndex = 2;
            this.btnGiris.Text = "GİRİŞ";
            this.btnGiris.UseVisualStyleBackColor = true;
            this.btnGiris.Click += new System.EventHandler(this.btnGiris_Click);
            // 
            // btnCikis
            // 
            this.btnCikis.Location = new System.Drawing.Point(29, 116);
            this.btnCikis.Name = "btnCikis";
            this.btnCikis.Size = new System.Drawing.Size(75, 23);
            this.btnCikis.TabIndex = 3;
            this.btnCikis.Text = "ÇIKIŞ";
            this.btnCikis.UseVisualStyleBackColor = true;
            this.btnCikis.Click += new System.EventHandler(this.btnCikis_Click);
            // 
            // btnListele
            // 
            this.btnListele.Location = new System.Drawing.Point(29, 146);
            this.btnListele.Name = "btnListele";
            this.btnListele.Size = new System.Drawing.Size(75, 23);
            this.btnListele.TabIndex = 4;
            this.btnListele.Text = "LİSTELE";
            this.btnListele.UseVisualStyleBackColor = true;
            this.btnListele.Click += new System.EventHandler(this.btnListele_Click);
            // 
            // lBoxListele
            // 
            this.lBoxListele.FormattingEnabled = true;
            this.lBoxListele.Location = new System.Drawing.Point(244, 25);
            this.lBoxListele.Name = "lBoxListele";
            this.lBoxListele.Size = new System.Drawing.Size(419, 147);
            this.lBoxListele.TabIndex = 5;
            // 
            // btnOncelik
            // 
            this.btnOncelik.Location = new System.Drawing.Point(125, 116);
            this.btnOncelik.Name = "btnOncelik";
            this.btnOncelik.Size = new System.Drawing.Size(100, 23);
            this.btnOncelik.TabIndex = 6;
            this.btnOncelik.Text = "ÖNCELİKLİ ÇIKIŞ";
            this.btnOncelik.UseVisualStyleBackColor = true;
            this.btnOncelik.Click += new System.EventHandler(this.btnOncelik_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(675, 261);
            this.Controls.Add(this.btnOncelik);
            this.Controls.Add(this.lBoxListele);
            this.Controls.Add(this.btnListele);
            this.Controls.Add(this.btnCikis);
            this.Controls.Add(this.btnGiris);
            this.Controls.Add(this.txtPlaka);
            this.Controls.Add(this.lblPlaka);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPlaka;
        private System.Windows.Forms.TextBox txtPlaka;
        private System.Windows.Forms.Button btnGiris;
        private System.Windows.Forms.Button btnCikis;
        private System.Windows.Forms.Button btnListele;
        private System.Windows.Forms.ListBox lBoxListele;
        private System.Windows.Forms.Button btnOncelik;
    }
}

