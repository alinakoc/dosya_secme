namespace WindowsFormsApp1
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.DosyaAc = new System.Windows.Forms.Button();
            this.DosyaOku = new System.Windows.Forms.Button();
            this.Kaydet = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(550, 38);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(185, 310);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            // 
            // DosyaAc
            // 
            this.DosyaAc.Location = new System.Drawing.Point(67, 65);
            this.DosyaAc.Name = "DosyaAc";
            this.DosyaAc.Size = new System.Drawing.Size(75, 23);
            this.DosyaAc.TabIndex = 1;
            this.DosyaAc.Text = "DosyaAc";
            this.DosyaAc.UseVisualStyleBackColor = true;
            this.DosyaAc.Click += new System.EventHandler(this.DosyaAc_Click);
            // 
            // DosyaOku
            // 
            this.DosyaOku.Location = new System.Drawing.Point(67, 127);
            this.DosyaOku.Name = "DosyaOku";
            this.DosyaOku.Size = new System.Drawing.Size(75, 23);
            this.DosyaOku.TabIndex = 2;
            this.DosyaOku.Text = "DosyaOku";
            this.DosyaOku.UseVisualStyleBackColor = true;
            this.DosyaOku.Click += new System.EventHandler(this.DosyaOku_Click);
            // 
            // Kaydet
            // 
            this.Kaydet.Location = new System.Drawing.Point(67, 197);
            this.Kaydet.Name = "Kaydet";
            this.Kaydet.Size = new System.Drawing.Size(75, 23);
            this.Kaydet.TabIndex = 3;
            this.Kaydet.Text = "Kaydet";
            this.Kaydet.UseVisualStyleBackColor = true;
            this.Kaydet.Click += new System.EventHandler(this.Kaydet_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Kaydet);
            this.Controls.Add(this.DosyaOku);
            this.Controls.Add(this.DosyaAc);
            this.Controls.Add(this.richTextBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button DosyaAc;
        private System.Windows.Forms.Button DosyaOku;
        private System.Windows.Forms.Button Kaydet;
    }
}

