using PersonelBilgiSistemiBL;
using PersonelBilgiSistemiDAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DilaraGÖKSU_PersonelBilgiSistemi
{
    public partial class frm_PersonelKayıt : Form
    {
        public frm_PersonelKayıt()
        {
            InitializeComponent();
        }
        Repository<Employee> repoPersonel = new Repository<Employee>();
        Repository<Department> repoDepartman = new Repository<Department>();
        int GlobalId;
        public enum Ogrenim
        {
            Ilkogretim, Lise, OnLisans, Lisans, YuksekLisans,Diger
        }
        private void frm_PersonelKayıt_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = repoPersonel.SelectAll();
            cmbDepartmanlar.DisplayMember ="DepartmentName";
            cmbDepartmanlar.ValueMember = "Explanation";
            cmbDepartmanlar.DataSource = repoDepartman.SelectAll();
            cmbCinsiyet.Items.Add("Kadın"); 
            cmbCinsiyet.Items.Add("Erkek");
            cmbOgrenimDurumu.Items.AddRange(Enum.GetNames(typeof(Ogrenim)));

        }
        private void btnPKaydet_Click(object sender, EventArgs e)
        {
            
            try
            {
                int sonuc = repoPersonel.SelectAll().Count;
                Employee emp = new Employee();
                //emp.DepartmentName =cmbDepartmanlar.SelectedValue;
                emp.FirstName = txtPAd.Text;
                emp.LastName = txtPSoyad.Text;
                emp.TCIndentityNumber = txtTCKimlik.Text;
                emp.BirthDate = dTPDogumTarihi.Value;
                emp.BirthPlace = txtDogumYeri.Text;
                emp.Cinsiyet = cmbCinsiyet.SelectedText;
                emp.OgrenimDurumu = cmbOgrenimDurumu.SelectedText;
                emp.Salary= Convert.ToInt32(txtMaas.Text);
                emp.PhoneNumber = txtTelefonNumarasi.Text;
                emp.Adress = txtAdres.Text;             
                repoPersonel.Kaydet(emp);
                dataGridView1.DataSource = repoPersonel.SelectAll();
                if (repoPersonel.SelectAll().Count > sonuc)
                {
                    MessageBox.Show("Her şey yolunda. Kayıt eklendi.");
                }
                else MessageBox.Show("Bir şeyler ters gitti. Kayıt eklenemedi.");

            }
            catch (Exception ex)
            {
            }
        }

        private void btnPGuncelle_Click(object sender, EventArgs e)
        {
            try
            {
                var sonuc = repoPersonel.SelectById(GlobalId);
                //sonuc.DepartmentID =txtAdres.Text;
                sonuc.FirstName = txtPAd.Text;
                sonuc.LastName = txtPSoyad.Text;
                sonuc.TCIndentityNumber = txtTCKimlik.Text;
                sonuc.BirthDate = dTPDogumTarihi.Value;
                sonuc.BirthPlace = txtDogumYeri.Text;
                sonuc.Cinsiyet = cmbCinsiyet.SelectedText;
                sonuc.OgrenimDurumu = cmbOgrenimDurumu.SelectedText;
                sonuc.Salary= Convert.ToInt32(txtMaas.Text);
                sonuc.PhoneNumber = txtTelefonNumarasi.Text;
                sonuc.Adress = txtAdres.Text;
                repoPersonel.Güncelle(sonuc);
                dataGridView1.DataSource = repoPersonel.SelectAll();
                MessageBox.Show("Her şey yolunda. Kayıt güncellendi.");

            }
            catch (Exception ex)
            {
                MessageBox.Show("Bir şeyler ters gitti. Kayot güncellenemedi.");
            }
        }

        private void btnPSil_Click(object sender, EventArgs e)
        {
            try
            {
                int sonuc = repoPersonel.SelectAll().Count;
                repoPersonel.Sil(GlobalId);
                dataGridView1.DataSource = repoPersonel.SelectAll();
                if (sonuc > repoPersonel.SelectAll().Count)
                {
                    MessageBox.Show("Her şey yolunda. Kayıt silindi.");

                }
                else MessageBox.Show("Bir şeyler ters gitti. Kayıt silinemedi.");
            }
            catch (Exception ex)
            {
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            GlobalId = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            txtPAd.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            txtPSoyad.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            txtTCKimlik.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            //dTPDogumTarihi.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            txtDogumYeri.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            cmbCinsiyet.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
            cmbOgrenimDurumu.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();
            txtMaas.Text = dataGridView1.CurrentRow.Cells[8].Value.ToString();
            txtTelefonNumarasi.Text = dataGridView1.CurrentRow.Cells[9].Value.ToString();
            txtAdres.Text = dataGridView1.CurrentRow.Cells[10].Value.ToString();
            //cmbDepartmanlar.Text = dataGridView1.CurrentRow.Cells[11].Value.ToString();
            
        }

        
    }
}
