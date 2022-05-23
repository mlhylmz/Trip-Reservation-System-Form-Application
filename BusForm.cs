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
    public partial class BusForm : Form
    {

        Seyahat data = new Seyahat();
        BusClass bus = new BusClass();

        
        public BusForm()
        {
            InitializeComponent();
        }

        private void BusForm_Load(object sender, EventArgs e)
        {
            pictureBox1.Image = Image.FromFile("C:\\Users\\Melih Yılmaz\\source\\repos\\YazilimMimariTasarim\\Photos\\Road.jpg");
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            goruntuleBtn.Enabled = false;
            satinAlBtn.Enabled = false;
            comboBox1.Items.Add("1");
            comboBox1.Items.Add("2");
            comboBox1.Items.Add("3");
            comboBox1.Items.Add("4");
        }

        private void goruntuleBtn_Click(object sender, EventArgs e)
        {
            int comboId = Int32.Parse(comboBox1.SelectedItem.ToString()) - 1;
            label1.Text = "Sefer İsmi : " + data.getbusName(comboId) + "\nSefer Tarihi : " + data.getbusDay(comboId) + "." + data.getbusMonth(comboId) + ".2022"+
                "\nBoş Yer Sayısı : " + data.getbusEmpty(comboId) + "\nBilet Fiyatı : "+ data.getbusPrice(comboId) + " TL";

            if(data.getbusEmpty(comboId) == 0){
                satinAlBtn.Enabled = false;
            }
            else if(data.getbusEmpty(comboId) != 0) {
                satinAlBtn.Enabled = true;
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            goruntuleBtn.Enabled = true;
        }

        private void satinAlBtn_Click(object sender, EventArgs e)
        {
            data.setUChoice(bus.ulasim());
            data.setType(1);
            data.setCombo(Int32.Parse(comboBox1.SelectedItem.ToString()) - 1);
            SatinAl satinAl = new SatinAl();
            satinAl.StartPosition = FormStartPosition.CenterScreen;
            satinAl.ShowDialog();
        }
    }
}
