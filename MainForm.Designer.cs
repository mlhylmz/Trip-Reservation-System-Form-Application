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
            this.SuspendLayout();
            // 
            // ulasimBtn
            // 
            this.ulasimBtn.Location = new System.Drawing.Point(143, 177);
            this.ulasimBtn.Name = "ulasimBtn";
            this.ulasimBtn.Size = new System.Drawing.Size(75, 23);
            this.ulasimBtn.TabIndex = 0;
            this.ulasimBtn.Text = "Ulaşım";
            this.ulasimBtn.UseVisualStyleBackColor = true;
            this.ulasimBtn.Click += new System.EventHandler(this.ulasimBtn_Click);
            // 
            // konakBtn
            // 
            this.konakBtn.Location = new System.Drawing.Point(443, 177);
            this.konakBtn.Name = "konakBtn";
            this.konakBtn.Size = new System.Drawing.Size(75, 23);
            this.konakBtn.TabIndex = 1;
            this.konakBtn.Text = "Konaklama";
            this.konakBtn.UseVisualStyleBackColor = true;
            this.konakBtn.Click += new System.EventHandler(this.konakBtn_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.konakBtn);
            this.Controls.Add(this.ulasimBtn);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ulasimBtn;
        private System.Windows.Forms.Button konakBtn;
    }
}