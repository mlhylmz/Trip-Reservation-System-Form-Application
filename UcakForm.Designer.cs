﻿namespace YazilimMimariTasarim
{
    partial class UcakForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.goruntuleBtn = new System.Windows.Forms.Button();
            this.satinAlBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 208);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Sefer Seçiniz";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(40, 81);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 1;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // goruntuleBtn
            // 
            this.goruntuleBtn.Location = new System.Drawing.Point(51, 127);
            this.goruntuleBtn.Name = "goruntuleBtn";
            this.goruntuleBtn.Size = new System.Drawing.Size(177, 41);
            this.goruntuleBtn.TabIndex = 2;
            this.goruntuleBtn.Text = "Seferi Görüntüle";
            this.goruntuleBtn.UseVisualStyleBackColor = true;
            this.goruntuleBtn.Click += new System.EventHandler(this.goruntuleBtn_Click);
            // 
            // satinAlBtn
            // 
            this.satinAlBtn.Location = new System.Drawing.Point(288, 144);
            this.satinAlBtn.Name = "satinAlBtn";
            this.satinAlBtn.Size = new System.Drawing.Size(75, 23);
            this.satinAlBtn.TabIndex = 3;
            this.satinAlBtn.Text = "Satın Al";
            this.satinAlBtn.UseVisualStyleBackColor = true;
            this.satinAlBtn.Click += new System.EventHandler(this.satinAlBtn_Click);
            // 
            // UcakForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(408, 367);
            this.Controls.Add(this.satinAlBtn);
            this.Controls.Add(this.goruntuleBtn);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label1);
            this.Name = "UcakForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Giris_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button goruntuleBtn;
        private System.Windows.Forms.Button satinAlBtn;
    }
}

