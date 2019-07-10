namespace DilaraGÖKSU_PersonelBilgiSistemi
{
    partial class frm_PersonelKayıt
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
            this.cmbOgrenimDurumu = new System.Windows.Forms.ComboBox();
            this.txtTelefonNumarasi = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.dTPDogumTarihi = new System.Windows.Forms.DateTimePicker();
            this.txtDogumYeri = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtAdres = new System.Windows.Forms.TextBox();
            this.txtPSoyad = new System.Windows.Forms.TextBox();
            this.txtTCKimlik = new System.Windows.Forms.TextBox();
            this.btnPSil = new System.Windows.Forms.Button();
            this.btnPGuncelle = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnPKaydet = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPAd = new System.Windows.Forms.TextBox();
            this.cmbDepartmanlar = new System.Windows.Forms.ComboBox();
            this.cmbCinsiyet = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txtMaas = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbOgrenimDurumu
            // 
            this.cmbOgrenimDurumu.FormattingEnabled = true;
            this.cmbOgrenimDurumu.Location = new System.Drawing.Point(848, 93);
            this.cmbOgrenimDurumu.Name = "cmbOgrenimDurumu";
            this.cmbOgrenimDurumu.Size = new System.Drawing.Size(200, 37);
            this.cmbOgrenimDurumu.TabIndex = 107;
            // 
            // txtTelefonNumarasi
            // 
            this.txtTelefonNumarasi.Location = new System.Drawing.Point(848, 199);
            this.txtTelefonNumarasi.Name = "txtTelefonNumarasi";
            this.txtTelefonNumarasi.Size = new System.Drawing.Size(200, 34);
            this.txtTelefonNumarasi.TabIndex = 106;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(576, 199);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(235, 29);
            this.label11.TabIndex = 105;
            this.label11.Text = "Telefon Numarası :";
            // 
            // dTPDogumTarihi
            // 
            this.dTPDogumTarihi.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dTPDogumTarihi.Location = new System.Drawing.Point(286, 247);
            this.dTPDogumTarihi.Name = "dTPDogumTarihi";
            this.dTPDogumTarihi.Size = new System.Drawing.Size(200, 34);
            this.dTPDogumTarihi.TabIndex = 104;
            // 
            // txtDogumYeri
            // 
            this.txtDogumYeri.Location = new System.Drawing.Point(286, 297);
            this.txtDogumYeri.Name = "txtDogumYeri";
            this.txtDogumYeri.Size = new System.Drawing.Size(200, 34);
            this.txtDogumYeri.TabIndex = 103;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(87, 297);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(165, 29);
            this.label9.TabIndex = 102;
            this.label9.Text = "Doğum Yeri :";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(586, 93);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(225, 29);
            this.label10.TabIndex = 101;
            this.label10.Text = "Öğrenim Durumu :";
            // 
            // txtAdres
            // 
            this.txtAdres.Location = new System.Drawing.Point(848, 249);
            this.txtAdres.Multiline = true;
            this.txtAdres.Name = "txtAdres";
            this.txtAdres.Size = new System.Drawing.Size(200, 39);
            this.txtAdres.TabIndex = 99;
            // 
            // txtPSoyad
            // 
            this.txtPSoyad.Location = new System.Drawing.Point(286, 147);
            this.txtPSoyad.Name = "txtPSoyad";
            this.txtPSoyad.Size = new System.Drawing.Size(200, 34);
            this.txtPSoyad.TabIndex = 98;
            // 
            // txtTCKimlik
            // 
            this.txtTCKimlik.Location = new System.Drawing.Point(286, 197);
            this.txtTCKimlik.Name = "txtTCKimlik";
            this.txtTCKimlik.Size = new System.Drawing.Size(200, 34);
            this.txtTCKimlik.TabIndex = 97;
            // 
            // btnPSil
            // 
            this.btnPSil.BackColor = System.Drawing.Color.Salmon;
            this.btnPSil.Location = new System.Drawing.Point(968, 312);
            this.btnPSil.Name = "btnPSil";
            this.btnPSil.Size = new System.Drawing.Size(80, 39);
            this.btnPSil.TabIndex = 96;
            this.btnPSil.Text = "Sil";
            this.btnPSil.UseVisualStyleBackColor = false;
            this.btnPSil.Click += new System.EventHandler(this.btnPSil_Click);
            // 
            // btnPGuncelle
            // 
            this.btnPGuncelle.BackColor = System.Drawing.Color.Salmon;
            this.btnPGuncelle.Location = new System.Drawing.Point(790, 312);
            this.btnPGuncelle.Name = "btnPGuncelle";
            this.btnPGuncelle.Size = new System.Drawing.Size(155, 39);
            this.btnPGuncelle.TabIndex = 95;
            this.btnPGuncelle.Text = "Güncelle";
            this.btnPGuncelle.UseVisualStyleBackColor = false;
            this.btnPGuncelle.Click += new System.EventHandler(this.btnPGuncelle_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(716, 249);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(95, 29);
            this.label8.TabIndex = 94;
            this.label8.Text = "Adres :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(691, 46);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(120, 29);
            this.label7.TabIndex = 93;
            this.label7.Text = "Cinsiyet :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(65, 247);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(185, 29);
            this.label6.TabIndex = 92;
            this.label6.Text = "Doğum Tarihi :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(722, 144);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 29);
            this.label5.TabIndex = 91;
            this.label5.Text = "Maaş :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(69, 197);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(182, 29);
            this.label4.TabIndex = 90;
            this.label4.Text = "TC Kimlik No :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(157, 147);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 29);
            this.label3.TabIndex = 89;
            this.label3.Text = "Soyad :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(204, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 29);
            this.label2.TabIndex = 88;
            this.label2.Text = "Ad :";
            // 
            // btnPKaydet
            // 
            this.btnPKaydet.BackColor = System.Drawing.Color.Salmon;
            this.btnPKaydet.Location = new System.Drawing.Point(635, 312);
            this.btnPKaydet.Name = "btnPKaydet";
            this.btnPKaydet.Size = new System.Drawing.Size(129, 39);
            this.btnPKaydet.TabIndex = 87;
            this.btnPKaydet.Text = "Kaydet";
            this.btnPKaydet.UseVisualStyleBackColor = false;
            this.btnPKaydet.Click += new System.EventHandler(this.btnPKaydet_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(96, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(154, 29);
            this.label1.TabIndex = 86;
            this.label1.Text = "Departman :";
            // 
            // txtPAd
            // 
            this.txtPAd.Location = new System.Drawing.Point(286, 97);
            this.txtPAd.Name = "txtPAd";
            this.txtPAd.Size = new System.Drawing.Size(200, 34);
            this.txtPAd.TabIndex = 85;
            // 
            // cmbDepartmanlar
            // 
            this.cmbDepartmanlar.FormattingEnabled = true;
            this.cmbDepartmanlar.Location = new System.Drawing.Point(286, 46);
            this.cmbDepartmanlar.Name = "cmbDepartmanlar";
            this.cmbDepartmanlar.Size = new System.Drawing.Size(200, 37);
            this.cmbDepartmanlar.TabIndex = 83;
            // 
            // cmbCinsiyet
            // 
            this.cmbCinsiyet.FormattingEnabled = true;
            this.cmbCinsiyet.Location = new System.Drawing.Point(848, 43);
            this.cmbCinsiyet.Name = "cmbCinsiyet";
            this.cmbCinsiyet.Size = new System.Drawing.Size(200, 37);
            this.cmbCinsiyet.TabIndex = 108;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(40, 376);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1042, 231);
            this.dataGridView1.TabIndex = 109;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // txtMaas
            // 
            this.txtMaas.Location = new System.Drawing.Point(848, 144);
            this.txtMaas.Name = "txtMaas";
            this.txtMaas.Size = new System.Drawing.Size(200, 34);
            this.txtMaas.TabIndex = 110;
            // 
            // frm_PersonelKayıt
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1139, 619);
            this.Controls.Add(this.txtMaas);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.cmbCinsiyet);
            this.Controls.Add(this.cmbOgrenimDurumu);
            this.Controls.Add(this.txtTelefonNumarasi);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.dTPDogumTarihi);
            this.Controls.Add(this.txtDogumYeri);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtAdres);
            this.Controls.Add(this.txtPSoyad);
            this.Controls.Add(this.txtTCKimlik);
            this.Controls.Add(this.btnPSil);
            this.Controls.Add(this.btnPGuncelle);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnPKaydet);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtPAd);
            this.Controls.Add(this.cmbDepartmanlar);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "frm_PersonelKayıt";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "frm_PersonelKayıt";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frm_PersonelKayıt_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox cmbOgrenimDurumu;
        private System.Windows.Forms.TextBox txtTelefonNumarasi;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DateTimePicker dTPDogumTarihi;
        private System.Windows.Forms.TextBox txtDogumYeri;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtAdres;
        private System.Windows.Forms.TextBox txtPSoyad;
        private System.Windows.Forms.TextBox txtTCKimlik;
        private System.Windows.Forms.Button btnPSil;
        private System.Windows.Forms.Button btnPGuncelle;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnPKaydet;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPAd;
        private System.Windows.Forms.ComboBox cmbDepartmanlar;
        private System.Windows.Forms.ComboBox cmbCinsiyet;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtMaas;
    }
}