namespace OgrenciOdevKontrolListesi
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            panel2 = new Panel();
            label2 = new Label();
            lBOgrenciListesi = new ListBox();
            lblOgrenciAdi = new Label();
            lblOgrenciSoyAdi = new Label();
            lblOgrenciNumarasi = new Label();
            lblOgrenciSinifi = new Label();
            lblOdevKonusu = new Label();
            lblOgrenciPuanı = new Label();
            lblOgrenciOdeviniYaptimi = new Label();
            cBEvet = new CheckBox();
            cBHayır = new CheckBox();
            txtAd = new TextBox();
            txtSoyAd = new TextBox();
            txtNo = new TextBox();
            txtPuan = new TextBox();
            txtKonu = new TextBox();
            bttnYeni = new Button();
            bttnSil = new Button();
            bttnekleguncelle = new Button();
            bttnKaydet = new Button();
            cbbSınıf = new ComboBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1122, 100);
            panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.school__1_;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(200, 100);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 48F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(128, 128, 255);
            label1.Location = new Point(267, 9);
            label1.Name = "label1";
            label1.Size = new Size(752, 86);
            label1.TabIndex = 0;
            label1.Text = "ÖĞRENCİ TAKİP LİSTESİ";
            // 
            // panel2
            // 
            panel2.Controls.Add(label2);
            panel2.Controls.Add(lBOgrenciListesi);
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(0, 100);
            panel2.Name = "panel2";
            panel2.Size = new Size(222, 488);
            panel2.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(3, 24);
            label2.Name = "label2";
            label2.Size = new Size(156, 30);
            label2.TabIndex = 1;
            label2.Text = "Öğrenci Listesi";
            // 
            // lBOgrenciListesi
            // 
            lBOgrenciListesi.FormattingEnabled = true;
            lBOgrenciListesi.ItemHeight = 15;
            lBOgrenciListesi.Location = new Point(0, 80);
            lBOgrenciListesi.Name = "lBOgrenciListesi";
            lBOgrenciListesi.Size = new Size(200, 349);
            lBOgrenciListesi.TabIndex = 0;
            lBOgrenciListesi.SelectedIndexChanged += lBOgrenciListesi_SelectedIndexChanged;
            // 
            // lblOgrenciAdi
            // 
            lblOgrenciAdi.AutoSize = true;
            lblOgrenciAdi.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            lblOgrenciAdi.Location = new Point(251, 163);
            lblOgrenciAdi.Name = "lblOgrenciAdi";
            lblOgrenciAdi.Size = new Size(157, 32);
            lblOgrenciAdi.TabIndex = 2;
            lblOgrenciAdi.Text = "Öğrenci Adı:";
            // 
            // lblOgrenciSoyAdi
            // 
            lblOgrenciSoyAdi.AutoSize = true;
            lblOgrenciSoyAdi.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            lblOgrenciSoyAdi.Location = new Point(251, 213);
            lblOgrenciSoyAdi.Name = "lblOgrenciSoyAdi";
            lblOgrenciSoyAdi.Size = new Size(198, 32);
            lblOgrenciSoyAdi.TabIndex = 3;
            lblOgrenciSoyAdi.Text = "Öğrenci SoyAdı:";
            // 
            // lblOgrenciNumarasi
            // 
            lblOgrenciNumarasi.AutoSize = true;
            lblOgrenciNumarasi.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            lblOgrenciNumarasi.Location = new Point(250, 265);
            lblOgrenciNumarasi.Name = "lblOgrenciNumarasi";
            lblOgrenciNumarasi.Size = new Size(228, 32);
            lblOgrenciNumarasi.TabIndex = 4;
            lblOgrenciNumarasi.Text = "Öğrenci Numarası:";
            // 
            // lblOgrenciSinifi
            // 
            lblOgrenciSinifi.AutoSize = true;
            lblOgrenciSinifi.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            lblOgrenciSinifi.Location = new Point(251, 315);
            lblOgrenciSinifi.Name = "lblOgrenciSinifi";
            lblOgrenciSinifi.Size = new Size(176, 32);
            lblOgrenciSinifi.TabIndex = 5;
            lblOgrenciSinifi.Text = "Öğrenci Sınıfı:";
            // 
            // lblOdevKonusu
            // 
            lblOdevKonusu.AutoSize = true;
            lblOdevKonusu.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            lblOdevKonusu.Location = new Point(612, 163);
            lblOdevKonusu.Name = "lblOdevKonusu";
            lblOdevKonusu.Size = new Size(174, 32);
            lblOdevKonusu.TabIndex = 6;
            lblOdevKonusu.Text = "Ödev Konusu:";
            // 
            // lblOgrenciPuanı
            // 
            lblOgrenciPuanı.AutoSize = true;
            lblOgrenciPuanı.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            lblOgrenciPuanı.Location = new Point(251, 436);
            lblOgrenciPuanı.Name = "lblOgrenciPuanı";
            lblOgrenciPuanı.Size = new Size(183, 32);
            lblOgrenciPuanı.TabIndex = 7;
            lblOgrenciPuanı.Text = "Öğrenci Puanı:";
            // 
            // lblOgrenciOdeviniYaptimi
            // 
            lblOgrenciOdeviniYaptimi.AutoSize = true;
            lblOgrenciOdeviniYaptimi.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            lblOgrenciOdeviniYaptimi.Location = new Point(683, 265);
            lblOgrenciOdeviniYaptimi.Name = "lblOgrenciOdeviniYaptimi";
            lblOgrenciOdeviniYaptimi.Size = new Size(292, 32);
            lblOgrenciOdeviniYaptimi.TabIndex = 8;
            lblOgrenciOdeviniYaptimi.Text = "Öğrenci Ödevini Yaptımı";
            // 
            // cBEvet
            // 
            cBEvet.AutoSize = true;
            cBEvet.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            cBEvet.Location = new Point(699, 319);
            cBEvet.Name = "cBEvet";
            cBEvet.Size = new Size(68, 29);
            cBEvet.TabIndex = 9;
            cBEvet.Text = "Evet";
            cBEvet.UseVisualStyleBackColor = true;
            // 
            // cBHayır
            // 
            cBHayır.AutoSize = true;
            cBHayır.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            cBHayır.Location = new Point(834, 319);
            cBHayır.Name = "cBHayır";
            cBHayır.Size = new Size(79, 29);
            cBHayır.TabIndex = 9;
            cBHayır.Text = "Hayır";
            cBHayır.UseVisualStyleBackColor = true;
            // 
            // txtAd
            // 
            txtAd.Location = new Point(420, 172);
            txtAd.Name = "txtAd";
            txtAd.Size = new Size(174, 23);
            txtAd.TabIndex = 10;
            // 
            // txtSoyAd
            // 
            txtSoyAd.Location = new Point(455, 222);
            txtSoyAd.Name = "txtSoyAd";
            txtSoyAd.Size = new Size(174, 23);
            txtSoyAd.TabIndex = 10;
            // 
            // txtNo
            // 
            txtNo.Location = new Point(475, 274);
            txtNo.Name = "txtNo";
            txtNo.Size = new Size(119, 23);
            txtNo.TabIndex = 10;
            // 
            // txtPuan
            // 
            txtPuan.Location = new Point(433, 445);
            txtPuan.Name = "txtPuan";
            txtPuan.Size = new Size(74, 23);
            txtPuan.TabIndex = 10;
            // 
            // txtKonu
            // 
            txtKonu.Location = new Point(801, 172);
            txtKonu.Multiline = true;
            txtKonu.Name = "txtKonu";
            txtKonu.Size = new Size(228, 73);
            txtKonu.TabIndex = 10;
            // 
            // bttnYeni
            // 
            bttnYeni.BackColor = Color.Lime;
            bttnYeni.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            bttnYeni.Location = new Point(652, 448);
            bttnYeni.Name = "bttnYeni";
            bttnYeni.Size = new Size(75, 33);
            bttnYeni.TabIndex = 11;
            bttnYeni.Text = "Yeni";
            bttnYeni.UseVisualStyleBackColor = false;
            bttnYeni.Click += bttnYeni_Click;
            // 
            // bttnSil
            // 
            bttnSil.BackColor = Color.Red;
            bttnSil.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            bttnSil.Location = new Point(833, 448);
            bttnSil.Name = "bttnSil";
            bttnSil.Size = new Size(75, 33);
            bttnSil.TabIndex = 11;
            bttnSil.Text = "Sil";
            bttnSil.UseVisualStyleBackColor = false;
            bttnSil.Click += bttnSil_Click;
            // 
            // bttnekleguncelle
            // 
            bttnekleguncelle.BackColor = Color.Cyan;
            bttnekleguncelle.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            bttnekleguncelle.Location = new Point(927, 449);
            bttnekleguncelle.Name = "bttnekleguncelle";
            bttnekleguncelle.Size = new Size(149, 31);
            bttnekleguncelle.TabIndex = 11;
            bttnekleguncelle.Text = "Ekle/Güncelle";
            bttnekleguncelle.UseVisualStyleBackColor = false;
            bttnekleguncelle.Click += bttnekleguncelle_Click;
            // 
            // bttnKaydet
            // 
            bttnKaydet.BackColor = Color.Yellow;
            bttnKaydet.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            bttnKaydet.Location = new Point(742, 451);
            bttnKaydet.Name = "bttnKaydet";
            bttnKaydet.Size = new Size(81, 31);
            bttnKaydet.TabIndex = 12;
            bttnKaydet.Text = "Kaydet";
            bttnKaydet.UseVisualStyleBackColor = false;
            bttnKaydet.Click += bttnKaydet_Click;
            // 
            // cbbSınıf
            // 
            cbbSınıf.FormattingEnabled = true;
            cbbSınıf.Location = new Point(433, 324);
            cbbSınıf.Name = "cbbSınıf";
            cbbSınıf.Size = new Size(121, 23);
            cbbSınıf.TabIndex = 13;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 192, 255);
            ClientSize = new Size(1122, 588);
            Controls.Add(cbbSınıf);
            Controls.Add(bttnKaydet);
            Controls.Add(bttnekleguncelle);
            Controls.Add(bttnSil);
            Controls.Add(bttnYeni);
            Controls.Add(txtKonu);
            Controls.Add(txtPuan);
            Controls.Add(txtNo);
            Controls.Add(txtSoyAd);
            Controls.Add(txtAd);
            Controls.Add(cBHayır);
            Controls.Add(cBEvet);
            Controls.Add(lblOgrenciOdeviniYaptimi);
            Controls.Add(lblOgrenciPuanı);
            Controls.Add(lblOdevKonusu);
            Controls.Add(lblOgrenciSinifi);
            Controls.Add(lblOgrenciNumarasi);
            Controls.Add(lblOgrenciSoyAdi);
            Controls.Add(lblOgrenciAdi);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox1;
        private Label label1;
        private Panel panel2;
        private Label label2;
        private ListBox lBOgrenciListesi;
        private Label lblOgrenciAdi;
        private Label lblOgrenciSoyAdi;
        private Label lblOgrenciNumarasi;
        private Label lblOgrenciSinifi;
        private Label lblOdevKonusu;
        private Label lblOgrenciPuanı;
        private Label lblOgrenciOdeviniYaptimi;
        private CheckBox cBEvet;
        private CheckBox cBHayır;
        private TextBox txtAd;
        private TextBox txtSoyAd;
        private TextBox txtNo;
        private TextBox txtPuan;
        private TextBox txtKonu;
        private Button bttnYeni;
        private Button bttnSil;
        private Button bttnekleguncelle;
        private Button bttnKaydet;
        private ComboBox cbbSınıf;
    }
}