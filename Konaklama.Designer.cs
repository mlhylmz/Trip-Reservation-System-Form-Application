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
            this.SuspendLayout();
            // 
            // otelBtn
            // 
            this.otelBtn.Location = new System.Drawing.Point(127, 218);
            this.otelBtn.Name = "otelBtn";
            this.otelBtn.Size = new System.Drawing.Size(75, 23);
            this.otelBtn.TabIndex = 0;
            this.otelBtn.Text = "Otel Seç";
            this.otelBtn.UseVisualStyleBackColor = true;
            this.otelBtn.Click += new System.EventHandler(this.otelBtn_Click);
            // 
            // cadirBtn
            // 
            this.cadirBtn.Location = new System.Drawing.Point(381, 217);
            this.cadirBtn.Name = "cadirBtn";
            this.cadirBtn.Size = new System.Drawing.Size(75, 23);
            this.cadirBtn.TabIndex = 1;
            this.cadirBtn.Text = "Çadır Seç";
            this.cadirBtn.UseVisualStyleBackColor = true;
            this.cadirBtn.Click += new System.EventHandler(this.cadirBtn_Click);
            // 
            // Konaklama
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cadirBtn);
            this.Controls.Add(this.otelBtn);
            this.Name = "Konaklama";
            this.Text = "Konaklama";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button otelBtn;
        private System.Windows.Forms.Button cadirBtn;
    }
}