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
    public partial class SatinAl : Form
    {
        Seyahat data = new Seyahat();
        public static int type= 0;
        public static int combo;
        public SatinAl()
        {
            InitializeComponent();
        }

        private void SatinAl_Load(object sender, EventArgs e)
        {
            pictureBox1.Image = Image.FromFile("C:\\Users\\Melih Yılmaz\\source\\repos\\YazilimMimariTasarim\\Photos\\Buy.jpg");
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            if (data.getType() == 1)
            {
                choiceLabel.Text = "Seçilen Taşıt : " + data.getUchoice() + "\nSeçilen Sefer : " + (data.getcombo() + 1);
                setType(data.getType());
                setCombo(data.getcombo());


            }
            else if (data.getType() == 2)
            {
                choiceLabel.Text = "Seçilen Konaklama : "+ data.getKchoice()+"\nSeçilen Seçenek : " + (data.getcombo() + 1);
                setType(data.getType());
                setCombo(data.getcombo());
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (type == 1)
            {
                if(data.getUchoice() == "bus")
                {
                    data.setBusEmptyBuy(combo);
                    MessageBox.Show("Bilet satın alındı.\nYeni boş yer sayısı: " + data.getbusEmpty(combo));
                    this.Close();
                }
                else if(data.getUchoice() == "ucak")
                {
                    data.setFlightEmptyBuy(combo);
                    MessageBox.Show("Bilet satın alındı.\nYeni boş yer sayısı : " + data.getflightEmpty(combo));
                    this.Close();
                }
            }
            else if (type == 2)
            {
                if(data.getKchoice() == "otel")
                {
                    data.setHotelEmptyBuy(combo);
                    MessageBox.Show("Bilet satın alındı.\nYeni boş yer sayısı : " + data.getotelEmpty(combo));
                    this.Close();
                }
                else if (data.getKchoice() == "cadir")
                {
                    data.setCadirEmptyBuy(combo);
                    MessageBox.Show("Bilet satın alındı.\nYeni boş yer sayısı : " + data.getcadirEmpty(combo));
                    this.Close();
                }
            }
        }
        public void setType(int cho) { type = cho; }
        public int getType() { return type; }

        public void setCombo(int com) { combo = com; }
        public int getCombo() { return combo; }
    }
}
