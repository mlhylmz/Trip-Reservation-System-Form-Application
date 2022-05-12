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
            this.SuspendLayout();
            // 
            // ucakBtn
            // 
            this.ucakBtn.Location = new System.Drawing.Point(72, 193);
            this.ucakBtn.Name = "ucakBtn";
            this.ucakBtn.Size = new System.Drawing.Size(110, 36);
            this.ucakBtn.TabIndex = 0;
            this.ucakBtn.Text = "Uçak Seferi Seç";
            this.ucakBtn.UseVisualStyleBackColor = true;
            this.ucakBtn.Click += new System.EventHandler(this.ucakBtn_Click);
            // 
            // busBtn
            // 
            this.busBtn.Location = new System.Drawing.Point(307, 193);
            this.busBtn.Name = "busBtn";
            this.busBtn.Size = new System.Drawing.Size(110, 35);
            this.busBtn.TabIndex = 1;
            this.busBtn.Text = "Otobüs Seferi Seç";
            this.busBtn.UseVisualStyleBackColor = true;
            this.busBtn.Click += new System.EventHandler(this.busBtn_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.busBtn);
            this.Controls.Add(this.ucakBtn);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ucakBtn;
        private System.Windows.Forms.Button busBtn;
    }
}