namespace YazilimMimariTasarim
{
    partial class MainForm
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
            this.ulasimBtn = new System.Windows.Forms.Button();
            this.konakBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // ulasimBtn
            // 
            this.ulasimBtn.Location = new System.Drawing.Point(84, 205);
            this.ulasimBtn.Name = "ulasimBtn";
            this.ulasimBtn.Size = new System.Drawing.Size(100, 50);
            this.ulasimBtn.TabIndex = 0;
            this.ulasimBtn.Text = "Ulaşım";
            this.ulasimBtn.UseVisualStyleBackColor = true;
            this.ulasimBtn.Click += new System.EventHandler(this.ulasimBtn_Click);
            // 
            // konakBtn
            // 
            this.konakBtn.Location = new System.Drawing.Point(288, 205);
            this.konakBtn.Name = "konakBtn";
            this.konakBtn.Size = new System.Drawing.Size(100, 50);
            this.konakBtn.TabIndex = 1;
            this.konakBtn.Text = "Konaklama";
            this.konakBtn.UseVisualStyleBackColor = true;
            this.konakBtn.Click += new System.EventHandler(this.konakBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(25, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(402, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Hoşgeldiniz. Seçim yapmak istediğiniz kategoriyi seçiniz.";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(0, -1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(485, 463);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 461);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.konakBtn);
            this.Controls.Add(this.ulasimBtn);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ulasimBtn;
        private System.Windows.Forms.Button konakBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}