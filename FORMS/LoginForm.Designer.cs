namespace YazilimMimariTasarim
{
    partial class LoginForm
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.girisBtn = new System.Windows.Forms.Button();
            this.kayitBtn = new System.Windows.Forms.Button();
            this.cashTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.passTextBox = new System.Windows.Forms.TextBox();
            this.girisRadio = new System.Windows.Forms.RadioButton();
            this.kayitRadio = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(96, 42);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1.Location = new System.Drawing.Point(25, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "İsminiz : ";
            // 
            // girisBtn
            // 
            this.girisBtn.Location = new System.Drawing.Point(28, 204);
            this.girisBtn.Name = "girisBtn";
            this.girisBtn.Size = new System.Drawing.Size(90, 35);
            this.girisBtn.TabIndex = 2;
            this.girisBtn.Text = "Giriş Yap";
            this.girisBtn.UseVisualStyleBackColor = true;
            this.girisBtn.Click += new System.EventHandler(this.girisBtn_Click);
            // 
            // kayitBtn
            // 
            this.kayitBtn.Location = new System.Drawing.Point(160, 204);
            this.kayitBtn.Name = "kayitBtn";
            this.kayitBtn.Size = new System.Drawing.Size(90, 35);
            this.kayitBtn.TabIndex = 3;
            this.kayitBtn.Text = "Kayıt Ol";
            this.kayitBtn.UseVisualStyleBackColor = true;
            this.kayitBtn.Click += new System.EventHandler(this.kayitBtn_Click);
            // 
            // cashTextBox
            // 
            this.cashTextBox.Location = new System.Drawing.Point(96, 115);
            this.cashTextBox.Name = "cashTextBox";
            this.cashTextBox.Size = new System.Drawing.Size(100, 20);
            this.cashTextBox.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label2.Location = new System.Drawing.Point(25, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Bakiye : ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label3.Location = new System.Drawing.Point(25, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Şifre :";
            // 
            // passTextBox
            // 
            this.passTextBox.Location = new System.Drawing.Point(96, 78);
            this.passTextBox.Name = "passTextBox";
            this.passTextBox.Size = new System.Drawing.Size(100, 20);
            this.passTextBox.TabIndex = 7;
            // 
            // girisRadio
            // 
            this.girisRadio.AutoSize = true;
            this.girisRadio.Location = new System.Drawing.Point(217, 59);
            this.girisRadio.Name = "girisRadio";
            this.girisRadio.Size = new System.Drawing.Size(45, 17);
            this.girisRadio.TabIndex = 8;
            this.girisRadio.TabStop = true;
            this.girisRadio.Text = "Giriş";
            this.girisRadio.UseVisualStyleBackColor = true;
            this.girisRadio.CheckedChanged += new System.EventHandler(this.girisRadio_CheckedChanged);
            // 
            // kayitRadio
            // 
            this.kayitRadio.AutoSize = true;
            this.kayitRadio.Location = new System.Drawing.Point(217, 99);
            this.kayitRadio.Name = "kayitRadio";
            this.kayitRadio.Size = new System.Drawing.Size(48, 17);
            this.kayitRadio.TabIndex = 9;
            this.kayitRadio.TabStop = true;
            this.kayitRadio.Text = "Kayıt";
            this.kayitRadio.UseVisualStyleBackColor = true;
            this.kayitRadio.CheckedChanged += new System.EventHandler(this.kayitRadio_CheckedChanged);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 361);
            this.Controls.Add(this.kayitRadio);
            this.Controls.Add(this.girisRadio);
            this.Controls.Add(this.passTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cashTextBox);
            this.Controls.Add(this.kayitBtn);
            this.Controls.Add(this.girisBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Name = "LoginForm";
            this.Text = "LoginForm";
            this.Load += new System.EventHandler(this.LoginForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button girisBtn;
        private System.Windows.Forms.Button kayitBtn;
        private System.Windows.Forms.TextBox cashTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox passTextBox;
        private System.Windows.Forms.RadioButton girisRadio;
        private System.Windows.Forms.RadioButton kayitRadio;
    }
}