namespace YazilimMimariTasarim
{
    partial class OtelForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.goruntuleBtn = new System.Windows.Forms.Button();
            this.satinAlBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(265, 127);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Seçiniz";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(25, 46);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 1;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // goruntuleBtn
            // 
            this.goruntuleBtn.Location = new System.Drawing.Point(25, 113);
            this.goruntuleBtn.Name = "goruntuleBtn";
            this.goruntuleBtn.Size = new System.Drawing.Size(75, 23);
            this.goruntuleBtn.TabIndex = 2;
            this.goruntuleBtn.Text = "Görüntüle";
            this.goruntuleBtn.UseVisualStyleBackColor = true;
            this.goruntuleBtn.Click += new System.EventHandler(this.goruntuleBtn_Click);
            // 
            // satinAlBtn
            // 
            this.satinAlBtn.Location = new System.Drawing.Point(25, 191);
            this.satinAlBtn.Name = "satinAlBtn";
            this.satinAlBtn.Size = new System.Drawing.Size(75, 23);
            this.satinAlBtn.TabIndex = 3;
            this.satinAlBtn.Text = "Satın Al";
            this.satinAlBtn.UseVisualStyleBackColor = true;
            this.satinAlBtn.Click += new System.EventHandler(this.satinAlBtn_Click);
            // 
            // OtelForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 461);
            this.Controls.Add(this.satinAlBtn);
            this.Controls.Add(this.goruntuleBtn);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "OtelForm";
            this.Text = "OtelForm";
            this.Load += new System.EventHandler(this.OtelForm_Load);
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