using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YazilimMimariTasarim
{
    public partial class MainForm : Form
    {
        
        public MainForm()
        {
            this.StartPosition = FormStartPosition.CenterScreen;
            InitializeComponent();
        }

        private void ulasimBtn_Click(object sender, EventArgs e)
        {
            Ulasim ulas = new Ulasim();
            ulas.StartPosition = FormStartPosition.CenterScreen;
            ulas.ShowDialog();
        }

        private void konakBtn_Click(object sender, EventArgs e)
        {
            Konaklama konak = new Konaklama();
            konak.StartPosition = FormStartPosition.CenterScreen;
            konak.ShowDialog();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            pictureBox1.Image = Image.FromFile("C:\\Users\\Melih Yılmaz\\source\\repos\\YazilimMimariTasarim\\Photos\\Background.jpg");
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
        }
    }
}
