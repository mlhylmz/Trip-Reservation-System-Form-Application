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
        }

        private void cadirBtn_Click(object sender, EventArgs e)
        {

        }
    }
}
