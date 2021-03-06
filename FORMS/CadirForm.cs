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
    public partial class CadirForm : Form
    {
        Seyahat data = new Seyahat();
        CadirClass cadir = new CadirClass();
        public CadirForm()
        {
            InitializeComponent();
        }

        private void CadirForm_Load(object sender, EventArgs e)
        {
            // ARKAPLAN RESMİ AYARLAMA
            pictureBox1.Image = Image.FromFile("C:\\Users\\Melih Yılmaz\\source\\repos\\YazilimMimariTasarim\\Photos\\Camp.jpg");
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;

            // BAŞLANGIÇ BUTONLAR KAPALI
            goruntuleBtn.Enabled = false;
            satinAlBtn.Enabled = false;

            //COMBOBOX İŞLEMLERİ
            comboBox1.Items.Add("1");
            comboBox1.Items.Add("2");
            comboBox1.Items.Add("3");
            comboBox1.Items.Add("4");
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            goruntuleBtn.Enabled = true;
        }

        private void goruntuleBtn_Click(object sender, EventArgs e)
        {
            // SEÇİLEN SEFERİ EKRANA BASTIRMA
            int comboId = Int32.Parse(comboBox1.SelectedItem.ToString()) - 1;
            label1.Text = "Çadır İsmi : " + data.getcadirName(comboId) + "\nÇadır Tarihi : " + data.getcadirDay(comboId) + "." + data.getcadirMonth(comboId) + ".2022" +
                "\nBoş Yer Sayısı : " + data.getcadirEmpty(comboId) + "\n1 Gece Fiyatı : " + data.getcadirPrice(comboId) + " TL";


            // BOŞ YER SAYI KONTROLÜ
            if (data.getcadirEmpty(comboId) == 0)
            {
                satinAlBtn.Enabled = false;
            }
            else if (data.getcadirEmpty(comboId) != 0)
            {
                satinAlBtn.Enabled = true;
            }
        }

        private void satinAlBtn_Click(object sender, EventArgs e)
        {
            //SATIN ALMA SAYFA AYARI VE AÇMA
            data.setKChoice(cadir.konaklama());
            data.setType(2);
            data.setCombo(Int32.Parse(comboBox1.SelectedItem.ToString()) - 1);
            SatinAl satinAl = new SatinAl();
            satinAl.StartPosition = FormStartPosition.CenterScreen;
            satinAl.ShowDialog();
        }
    }
}
