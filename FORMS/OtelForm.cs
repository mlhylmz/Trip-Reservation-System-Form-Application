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
    public partial class OtelForm : Form
    {
        Seyahat data = new Seyahat();
        OtelClass otel = new OtelClass();
        public OtelForm()
        {
            InitializeComponent();
        }

        private void goruntuleBtn_Click(object sender, EventArgs e)
        {
            int comboId = Int32.Parse(comboBox1.SelectedItem.ToString()) - 1;
            label1.Text = "Otel İsmi : " + data.getotelName(comboId) + "\nOtel Tarihi : " + data.getotelDay(comboId) + "." + data.getotelMonth(comboId) + ".2022" +
                "\nBoş Yer Sayısı : " + data.getotelEmpty(comboId) + "\n1 Gece Fiyatı : " + data.getotelPrice(comboId) + " TL";

            if (data.getotelEmpty(comboId) == 0)
            {
                satinAlBtn.Enabled = false;
            }
            else if (data.getotelEmpty(comboId) != 0)
            {
                satinAlBtn.Enabled = true;
            }
        }

        private void satinAlBtn_Click(object sender, EventArgs e)
        {
            data.setKChoice(otel.konaklama());
            data.setType(2);
            data.setCombo(Int32.Parse(comboBox1.SelectedItem.ToString()) - 1);
            SatinAl satinAl = new SatinAl();
            satinAl.StartPosition = FormStartPosition.CenterScreen;
            satinAl.ShowDialog();
        }

        private void OtelForm_Load(object sender, EventArgs e)
        {
            pictureBox1.Image = Image.FromFile("C:\\Users\\Melih Yılmaz\\source\\repos\\YazilimMimariTasarim\\Photos\\Hotel.jpg");
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            goruntuleBtn.Enabled = false;
            satinAlBtn.Enabled = false;
            comboBox1.Items.Add("1");
            comboBox1.Items.Add("2");
            comboBox1.Items.Add("3");
            comboBox1.Items.Add("4");
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            goruntuleBtn.Enabled = true;
        }
    }
}
