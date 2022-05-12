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
        public SatinAl()
        {
            InitializeComponent();
        }

        private void SatinAl_Load(object sender, EventArgs e)
        {
            if (data.getType() == 1)
            {
                choiceLabel.Text = "Seçilen Taşıt : " + data.getUchoice() + "\nSeçilen Sefer : " + (data.getcombo() + 1);
            }
            else if (data.getType() == 2)
            {
                choiceLabel.Text = "Seçilen Konaklama : "+ data.getKchoice()+"\nSeçilen Seçenek : " + (data.getcombo() + 1);
            }
        }
    }
}
