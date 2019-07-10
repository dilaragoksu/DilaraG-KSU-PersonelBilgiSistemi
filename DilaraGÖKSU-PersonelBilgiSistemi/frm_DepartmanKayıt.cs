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
    public partial class frm_DepartmanKayıt : Form
    {
        public frm_DepartmanKayıt()
        {
            InitializeComponent();
        }
        Repository<Department> repoDepartman = new Repository<Department>();
        Department d = new Department();
        int GlobalId;

        private void frm_DepartmanKayıt_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = repoDepartman.SelectAll();
        }

        private void btnDKaydet_Click(object sender, EventArgs e)
        {

            try
            {
                int sonuc = repoDepartman.SelectAll().Count;
                d.DepartmentName = txtDepartmanAdi.Text;
                d.Explanation = txtDAciklama.Text;
                repoDepartman.Kaydet(d);
                dataGridView1.DataSource = repoDepartman.SelectAll();
                if (repoDepartman.SelectAll().Count > sonuc)
                {
                    MessageBox.Show("Her şey yolunda. Kayıt eklendi.");
                }
                else MessageBox.Show("Bir şeyler ters gitti. Kayıt eklenemedi.");

            }
            catch (Exception ex)
            {
                //errorProvider1.SetError(ex.Message);
            }
            
        }

        private void btnDGuncelle_Click(object sender, EventArgs e)
        {
            try
            {
                var sonuc =repoDepartman.SelectById(GlobalId);
                sonuc.DepartmentName = txtDepartmanAdi.Text;
                sonuc.Explanation = txtDAciklama.Text;
                repoDepartman.Güncelle(sonuc);
                dataGridView1.DataSource = repoDepartman.SelectAll();
                MessageBox.Show("Her şey yolunda. Kayıt güncellendi.");

            }
            catch (Exception ex)
            {
                MessageBox.Show("Bir şeyler ters gitti. Kayot güncellenemedi.");
            }

        }

        private void btnDSil_Click(object sender, EventArgs e)
        {
            try
            {
                int sonuc = repoDepartman.SelectAll().Count;
                repoDepartman.Sil(GlobalId);
                dataGridView1.DataSource = repoDepartman.SelectAll();
                if (sonuc> repoDepartman.SelectAll().Count )
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
            txtDepartmanAdi.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            txtDAciklama.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
        }
    }
}
