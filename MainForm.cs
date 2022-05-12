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
    }
}
