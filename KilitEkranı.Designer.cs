namespace OgrenciOdevKontrolListesi
{
    partial class KilitEkranı
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtAd = new TextBox();
            lblAdi = new Label();
            txtŞifre = new TextBox();
            lblSifre = new Label();
            bttnGiriş = new Button();
            SuspendLayout();
            // 
            // txtAd
            // 
            txtAd.Location = new Point(144, 12);
            txtAd.Name = "txtAd";
            txtAd.Size = new Size(190, 23);
            txtAd.TabIndex = 1;
            // 
            // lblAdi
            // 
            lblAdi.AutoSize = true;
            lblAdi.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblAdi.Location = new Point(4, 9);
            lblAdi.Name = "lblAdi";
            lblAdi.Size = new Size(122, 25);
            lblAdi.TabIndex = 2;
            lblAdi.Text = "Kullanıcı Adı";
            // 
            // txtŞifre
            // 
            txtŞifre.Location = new Point(155, 85);
            txtŞifre.Name = "txtŞifre";
            txtŞifre.Size = new Size(179, 23);
            txtŞifre.TabIndex = 1;
            // 
            // lblSifre
            // 
            lblSifre.AutoSize = true;
            lblSifre.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblSifre.Location = new Point(4, 82);
            lblSifre.Name = "lblSifre";
            lblSifre.Size = new Size(146, 25);
            lblSifre.TabIndex = 2;
            lblSifre.Text = "Kullanıcı Şifresi";
            // 
            // bttnGiriş
            // 
            bttnGiriş.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            bttnGiriş.Location = new Point(176, 136);
            bttnGiriş.Name = "bttnGiriş";
            bttnGiriş.Size = new Size(133, 36);
            bttnGiriş.TabIndex = 3;
            bttnGiriş.Text = "Giriş";
            bttnGiriş.UseVisualStyleBackColor = true;
            bttnGiriş.Click += bttnGiriş_Click;
            // 
            // KilitEkranı
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(406, 218);
            Controls.Add(bttnGiriş);
            Controls.Add(lblSifre);
            Controls.Add(lblAdi);
            Controls.Add(txtŞifre);
            Controls.Add(txtAd);
            Name = "KilitEkranı";
            Text = "KilitEkranı";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtAd;
        private Label lblAdi;
        private TextBox txtŞifre;
        private Label lblSifre;
        private Button bttnGiriş;
    }
}