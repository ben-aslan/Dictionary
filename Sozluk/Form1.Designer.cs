
namespace Sozluk
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.ekle = new System.Windows.Forms.Button();
            this.guncelle = new System.Windows.Forms.Button();
            this.sil = new System.Windows.Forms.Button();
            this.ingilizce = new System.Windows.Forms.Label();
            this.turkce = new System.Windows.Forms.Label();
            this.t_ingilizce = new System.Windows.Forms.TextBox();
            this.t_turkce = new System.Windows.Forms.TextBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // ekle
            // 
            this.ekle.Location = new System.Drawing.Point(10, 80);
            this.ekle.Name = "ekle";
            this.ekle.Size = new System.Drawing.Size(64, 23);
            this.ekle.TabIndex = 0;
            this.ekle.Text = "EKLE";
            this.ekle.UseVisualStyleBackColor = true;
            this.ekle.Click += new System.EventHandler(this.ekle_Click);
            // 
            // guncelle
            // 
            this.guncelle.Location = new System.Drawing.Point(80, 80);
            this.guncelle.Name = "guncelle";
            this.guncelle.Size = new System.Drawing.Size(77, 23);
            this.guncelle.TabIndex = 1;
            this.guncelle.Text = "GÜNCELLE";
            this.guncelle.UseVisualStyleBackColor = true;
            this.guncelle.Click += new System.EventHandler(this.guncelle_Click);
            // 
            // sil
            // 
            this.sil.Location = new System.Drawing.Point(163, 80);
            this.sil.Name = "sil";
            this.sil.Size = new System.Drawing.Size(59, 23);
            this.sil.TabIndex = 2;
            this.sil.Text = "SIL";
            this.sil.UseVisualStyleBackColor = true;
            this.sil.Click += new System.EventHandler(this.sil_Click);
            // 
            // ingilizce
            // 
            this.ingilizce.AutoSize = true;
            this.ingilizce.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ingilizce.Location = new System.Drawing.Point(10, 9);
            this.ingilizce.Name = "ingilizce";
            this.ingilizce.Size = new System.Drawing.Size(86, 21);
            this.ingilizce.TabIndex = 3;
            this.ingilizce.Text = "INGILIZCE";
            // 
            // turkce
            // 
            this.turkce.AutoSize = true;
            this.turkce.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.turkce.Location = new System.Drawing.Point(10, 41);
            this.turkce.Name = "turkce";
            this.turkce.Size = new System.Drawing.Size(70, 21);
            this.turkce.TabIndex = 4;
            this.turkce.Text = "TÜRKÇE";
            // 
            // t_ingilizce
            // 
            this.t_ingilizce.Location = new System.Drawing.Point(102, 9);
            this.t_ingilizce.Name = "t_ingilizce";
            this.t_ingilizce.Size = new System.Drawing.Size(120, 23);
            this.t_ingilizce.TabIndex = 5;
            this.t_ingilizce.TextChanged += new System.EventHandler(this.t_ingilizce_TextChanged);
            // 
            // t_turkce
            // 
            this.t_turkce.Location = new System.Drawing.Point(102, 41);
            this.t_turkce.Name = "t_turkce";
            this.t_turkce.Size = new System.Drawing.Size(120, 23);
            this.t_turkce.TabIndex = 6;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 15;
            this.listBox1.Location = new System.Drawing.Point(228, 9);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(180, 94);
            this.listBox1.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(415, 114);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.t_turkce);
            this.Controls.Add(this.t_ingilizce);
            this.Controls.Add(this.turkce);
            this.Controls.Add(this.ingilizce);
            this.Controls.Add(this.sil);
            this.Controls.Add(this.guncelle);
            this.Controls.Add(this.ekle);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ekle;
        private System.Windows.Forms.Button guncelle;
        private System.Windows.Forms.Button sil;
        private System.Windows.Forms.Label ingilizce;
        private System.Windows.Forms.Label turkce;
        private System.Windows.Forms.TextBox t_ingilizce;
        private System.Windows.Forms.TextBox t_turkce;
        private System.Windows.Forms.ListBox listBox1;
    }
}

