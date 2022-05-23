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
    public partial class Ulasim : Form
    {
        public Ulasim()
        {
            InitializeComponent();
        }

        private void ucakBtn_Click(object sender, EventArgs e)
        {
            UcakForm ucakForm = new UcakForm();
            ucakForm.StartPosition = FormStartPosition.CenterScreen;
            ucakForm.ShowDialog();
            this.Close();
        }

        private void busBtn_Click(object sender, EventArgs e)
        {
            BusForm busForm = new BusForm();
            busForm.StartPosition = FormStartPosition.CenterScreen;
            busForm.ShowDialog();
            this.Close();
        }

        private void Ulasim_Load(object sender, EventArgs e)
        {
            pictureBox1.Image = Image.FromFile("C:\\Users\\Melih Yılmaz\\source\\repos\\YazilimMimariTasarim\\Photos\\Transport.jpg");
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
        }
    }
}
