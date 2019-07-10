namespace DilaraGÖKSU_PersonelBilgiSistemi
{
    partial class frm_DepartmanKayıt
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
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lblAciklama = new System.Windows.Forms.Label();
            this.txtDAciklama = new System.Windows.Forms.TextBox();
            this.btnDSil = new System.Windows.Forms.Button();
            this.btnDGuncelle = new System.Windows.Forms.Button();
            this.btnDKaydet = new System.Windows.Forms.Button();
            this.lblDepartmanAdi = new System.Windows.Forms.Label();
            this.txtDepartmanAdi = new System.Windows.Forms.TextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(20, 201);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(527, 212);
            this.dataGridView1.TabIndex = 44;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // lblAciklama
            // 
            this.lblAciklama.AutoSize = true;
            this.lblAciklama.Location = new System.Drawing.Point(130, 90);
            this.lblAciklama.Name = "lblAciklama";
            this.lblAciklama.Size = new System.Drawing.Size(132, 29);
            this.lblAciklama.TabIndex = 43;
            this.lblAciklama.Text = "Açıklama :";
            // 
            // txtDAciklama
            // 
            this.txtDAciklama.Location = new System.Drawing.Point(285, 87);
            this.txtDAciklama.Name = "txtDAciklama";
            this.txtDAciklama.Size = new System.Drawing.Size(225, 34);
            this.txtDAciklama.TabIndex = 42;
            // 
            // btnDSil
            // 
            this.btnDSil.BackColor = System.Drawing.Color.DarkCyan;
            this.btnDSil.Location = new System.Drawing.Point(377, 137);
            this.btnDSil.Name = "btnDSil";
            this.btnDSil.Size = new System.Drawing.Size(124, 39);
            this.btnDSil.TabIndex = 41;
            this.btnDSil.Text = "Sil";
            this.btnDSil.UseVisualStyleBackColor = false;
            this.btnDSil.Click += new System.EventHandler(this.btnDSil_Click);
            // 
            // btnDGuncelle
            // 
            this.btnDGuncelle.BackColor = System.Drawing.Color.DarkCyan;
            this.btnDGuncelle.Location = new System.Drawing.Point(202, 137);
            this.btnDGuncelle.Name = "btnDGuncelle";
            this.btnDGuncelle.Size = new System.Drawing.Size(169, 39);
            this.btnDGuncelle.TabIndex = 40;
            this.btnDGuncelle.Text = "Güncelle";
            this.btnDGuncelle.UseVisualStyleBackColor = false;
            this.btnDGuncelle.Click += new System.EventHandler(this.btnDGuncelle_Click);
            // 
            // btnDKaydet
            // 
            this.btnDKaydet.BackColor = System.Drawing.Color.DarkCyan;
            this.btnDKaydet.Location = new System.Drawing.Point(61, 137);
            this.btnDKaydet.Name = "btnDKaydet";
            this.btnDKaydet.Size = new System.Drawing.Size(135, 39);
            this.btnDKaydet.TabIndex = 39;
            this.btnDKaydet.Text = "Kaydet";
            this.btnDKaydet.UseVisualStyleBackColor = false;
            this.btnDKaydet.Click += new System.EventHandler(this.btnDKaydet_Click);
            // 
            // lblDepartmanAdi
            // 
            this.lblDepartmanAdi.AutoSize = true;
            this.lblDepartmanAdi.Location = new System.Drawing.Point(55, 42);
            this.lblDepartmanAdi.Name = "lblDepartmanAdi";
            this.lblDepartmanAdi.Size = new System.Drawing.Size(199, 29);
            this.lblDepartmanAdi.TabIndex = 38;
            this.lblDepartmanAdi.Text = "Departman Adı :";
            // 
            // txtDepartmanAdi
            // 
            this.txtDepartmanAdi.Location = new System.Drawing.Point(285, 39);
            this.txtDepartmanAdi.Name = "txtDepartmanAdi";
            this.txtDepartmanAdi.Size = new System.Drawing.Size(225, 34);
            this.txtDepartmanAdi.TabIndex = 37;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // frm_DepartmanKayıt
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(567, 453);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.lblAciklama);
            this.Controls.Add(this.txtDAciklama);
            this.Controls.Add(this.btnDSil);
            this.Controls.Add(this.btnDGuncelle);
            this.Controls.Add(this.btnDKaydet);
            this.Controls.Add(this.lblDepartmanAdi);
            this.Controls.Add(this.txtDepartmanAdi);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "frm_DepartmanKayıt";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "frm_DepartmanKayıt";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frm_DepartmanKayıt_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lblAciklama;
        private System.Windows.Forms.TextBox txtDAciklama;
        private System.Windows.Forms.Button btnDSil;
        private System.Windows.Forms.Button btnDGuncelle;
        private System.Windows.Forms.Button btnDKaydet;
        private System.Windows.Forms.Label lblDepartmanAdi;
        private System.Windows.Forms.TextBox txtDepartmanAdi;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}