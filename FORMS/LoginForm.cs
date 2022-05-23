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
    public partial class LoginForm : Form
    {
        clientData data = new clientData();
        public LoginForm()
        {
            this.StartPosition = FormStartPosition.CenterScreen;
            InitializeComponent();
        }

        private void girisBtn_Click(object sender, EventArgs e)
        {
            if (textBox1.TextLength > 1 && passTextBox.TextLength > 1)
            {
                int id = data.IdFounder(textBox1.Text, passTextBox.Text);

                ///id = -1 : Kullanıcı Yok      id = -2 : Şifre Yanlış

                //Kullanıcı bulunursa
                if (id > -1)
                {
                    MainForm mf = new MainForm();
                    MessageBox.Show("Id : " + id + "\nİsim : " + data.getNames(id) + "\nBakiye : " + data.getCash(id));
                    mf.StartPosition = FormStartPosition.CenterScreen;
                    mf.Show();
                }

                //Kullanıcı bulunmazsa
                else if (id == -1) { MessageBox.Show("Böyle bir kullanıcı yok"); }

                else if (id == -2) { MessageBox.Show("Şifre Yanlış"); }
            }
            else
            {
                MessageBox.Show("Boş Bırakmayınız.");
            }
            
        }

        private void kayitBtn_Click(object sender, EventArgs e)
        {
            if (textBox1.TextLength > 1 && cashTextBox.TextLength > 1 && passTextBox.TextLength > 1)
            {
                int id = data.IdFounder(textBox1.Text, passTextBox.Text);

                //Kullanıcı bulunursa
                if (id != -1) { MessageBox.Show("Böyle bir kullanıcı mevcut. İsim değiştiriniz."); }

                //Kullanıcı bulunmazsa
                else if (id == -1)
                {
                    
                    data.setNewClient(textBox1.Text, passTextBox.Text,Convert.ToInt16(cashTextBox.Text));
                    MessageBox.Show("Kayıt Olma Başarılı");

                }
                
            }
            else
            {
                MessageBox.Show("Boş bırakmayınız");
            }
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            girisBtn.Enabled = false;
            kayitBtn.Enabled = false;
            cashTextBox.Enabled = false;
            label2.Enabled = false;
        }

        private void girisRadio_CheckedChanged(object sender, EventArgs e)
        {
            if (girisRadio.Checked)
            {
                girisBtn.Enabled = true;
                kayitBtn.Enabled = false;
                cashTextBox.Enabled = false;
                label2.Enabled = false;
            }
            
        }

        private void kayitRadio_CheckedChanged(object sender, EventArgs e)
        {
            if (kayitRadio.Checked)
            {
                kayitBtn.Enabled = true;
                cashTextBox.Enabled = true;
                girisBtn.Enabled = false;
                label2.Enabled = true;
            }
            
        }
    }
}
