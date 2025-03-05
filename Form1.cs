using System.ComponentModel;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace OgrenciOdevKontrolListesi
{
    public partial class Form1 : Form
    {
        BindingList<Ogr> liste = new();
        Ogr gosterilenOgr;
        object[] sýnýflar = new object[] { "10-A", "10-C", "10-F", "10-H", "10-G" };

        public object txtSoyad { get; private set; }

        public Form1()
        {
            InitializeComponent();
            if (File.Exists("bilgiler.txt"))
            {
                string metin = File.ReadAllText("bilgiler.txt");
                var okunanListe = JsonSerializer.Deserialize<List<Ogr>>(metin);
            }
            lBOgrenciListesi.DataSource = liste;
            lBOgrenciListesi.DisplayMember = "FullName";
            cbbSýnýf.Items.AddRange(sýnýflar);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void bttnYeni_Click(object sender, EventArgs e)
        {
            lBOgrenciListesi.SelectedIndex = -1;

            txtAd.Clear();
            txtSoyAd.Clear();
            txtNo.Clear();
            txtPuan.Clear();
            cbbSýnýf.SelectedIndex = -1;
            txtAd.Focus();

        }
        void YeniEkle()
        {

            cbbSýnýf.Items.AddRange(sýnýflar);
            Ogr yeniPers = new();
            yeniPers.Ad = txtAd.Text;
            yeniPers.Soyad = txtSoyAd.Text;
            yeniPers.Sýnýf = cbbSýnýf.SelectedIndex;
            yeniPers.Konu = txtKonu.Text;
            yeniPers.Numara = txtNo.Text;


            liste.Add(yeniPers);

            txtAd.Clear();
            txtSoyAd.Clear();

            txtAd.Focus();
        }
        private void bttnekleguncelle_Click(object sender, EventArgs e)
        {
            if (gosterilenOgr == null)
            {
                YeniEkle();
            }
            else
            {
                Guncelle();
            }
        }

        void Guncelle()
        {
            gosterilenOgr.Ad = txtAd.Text;
            gosterilenOgr.Soyad = txtSoyAd.Text;
        }

        private void lBOgrenciListesi_SelectedIndexChanged(object sender, EventArgs e)
        {
            Ogr pers = lBOgrenciListesi.SelectedItem as Ogr;

            if (pers != null)
            {
                txtSoyAd.Text = pers.Soyad;

                txtSoyAd.Text = pers.Ad;

                gosterilenOgr = pers;

            }
            else
            {
                gosterilenOgr = null;
            }
        }

        private void bttnSil_Click(object sender, EventArgs e)
        {

            if (lBOgrenciListesi.SelectedItem != null)
            {
                liste.Remove((Ogr)lBOgrenciListesi.SelectedItem);

                gosterilenOgr = null;

                // Alanlarý temizle
                txtAd.Clear();
                txtSoyAd.Clear();
                txtNo.Clear();
                txtKonu.Clear();
                txtPuan.Clear();

                MessageBox.Show("Seçili personel silindi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Lütfen silinecek bir personel seçin!", "Uyarý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void bttnKaydet_Click(object sender, EventArgs e)
        {
            string metin = JsonSerializer.Serialize(liste);

            File.WriteAllText("bilgiler.txt", metin);
            MessageBox.Show("Kaydedildi");
        }
    }
}
