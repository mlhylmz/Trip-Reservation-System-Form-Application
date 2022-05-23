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
    public partial class Konaklama : Form
    {
        public Konaklama()
        {
            InitializeComponent();
        }

        private void otelBtn_Click(object sender, EventArgs e)
        {
            OtelForm otel = new OtelForm();
            otel.StartPosition = FormStartPosition.CenterScreen;
            otel.ShowDialog();
            this.Close();
        }

        private void cadirBtn_Click(object sender, EventArgs e)
        {
            CadirForm cadir = new CadirForm();
            cadir.StartPosition = FormStartPosition.CenterScreen;
            cadir.ShowDialog();
            this.Close();
        }

        private void Konaklama_Load(object sender, EventArgs e)
        {
            pictureBox1.Image = Image.FromFile("C:\\Users\\Melih Yılmaz\\source\\repos\\YazilimMimariTasarim\\Photos\\Accom.jpg");
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
        }
    }
}
