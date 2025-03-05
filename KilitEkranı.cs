using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OgrenciOdevKontrolListesi
{
    public partial class KilitEkranı : Form
    {
        public KilitEkranı()
        {
            InitializeComponent();
        }

        private void bttnGiriş_Click(object sender, EventArgs e)
        {
            if (txtAd.Text == "ılgın" &&
                            txtŞifre.Text == "123456")
            {
                DialogResult = DialogResult.OK;//formu kapatır
            }
            else
            {
                MessageBox.Show("Yanlış kullanıcı adı yada parola!");
            }
        }
    }
}
