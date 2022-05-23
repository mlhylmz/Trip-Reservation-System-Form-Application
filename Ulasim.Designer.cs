namespace YazilimMimariTasarim
{
    partial class Ulasim
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
            this.ucakBtn = new System.Windows.Forms.Button();
            this.busBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // ucakBtn
            // 
            this.ucakBtn.Location = new System.Drawing.Point(84, 205);
            this.ucakBtn.Name = "ucakBtn";
            this.ucakBtn.Size = new System.Drawing.Size(110, 50);
            this.ucakBtn.TabIndex = 0;
            this.ucakBtn.Text = "Uçak Seferi Seç";
            this.ucakBtn.UseVisualStyleBackColor = true;
            this.ucakBtn.Click += new System.EventHandler(this.ucakBtn_Click);
            // 
            // busBtn
            // 
            this.busBtn.Location = new System.Drawing.Point(288, 205);
            this.busBtn.Name = "busBtn";
            this.busBtn.Size = new System.Drawing.Size(110, 50);
            this.busBtn.TabIndex = 1;
            this.busBtn.Text = "Otobüs Seferi Seç";
            this.busBtn.UseVisualStyleBackColor = true;
            this.busBtn.Click += new System.EventHandler(this.busBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(185, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Ulaşımı seçiniz.";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(484, 462);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // Ulasim
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 461);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.busBtn);
            this.Controls.Add(this.ucakBtn);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Ulasim";
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.Ulasim_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ucakBtn;
        private System.Windows.Forms.Button busBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}