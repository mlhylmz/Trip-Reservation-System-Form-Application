namespace YazilimMimariTasarim
{
    partial class Konaklama
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
            this.otelBtn = new System.Windows.Forms.Button();
            this.cadirBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // otelBtn
            // 
            this.otelBtn.Location = new System.Drawing.Point(84, 205);
            this.otelBtn.Name = "otelBtn";
            this.otelBtn.Size = new System.Drawing.Size(100, 50);
            this.otelBtn.TabIndex = 0;
            this.otelBtn.Text = "Otel Seç";
            this.otelBtn.UseVisualStyleBackColor = true;
            this.otelBtn.Click += new System.EventHandler(this.otelBtn_Click);
            // 
            // cadirBtn
            // 
            this.cadirBtn.Location = new System.Drawing.Point(288, 205);
            this.cadirBtn.Name = "cadirBtn";
            this.cadirBtn.Size = new System.Drawing.Size(100, 50);
            this.cadirBtn.TabIndex = 1;
            this.cadirBtn.Text = "Çadır Seç";
            this.cadirBtn.UseVisualStyleBackColor = true;
            this.cadirBtn.Click += new System.EventHandler(this.cadirBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(165, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Konaklama Seçiniz.";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(-2, -3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(485, 466);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // Konaklama
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 461);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cadirBtn);
            this.Controls.Add(this.otelBtn);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Konaklama";
            this.Text = "Konaklama";
            this.Load += new System.EventHandler(this.Konaklama_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button otelBtn;
        private System.Windows.Forms.Button cadirBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}