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
    public partial class frm_PersonelArama : Form
    {
        public frm_PersonelArama()
        {
            InitializeComponent();
        }
        Repository<Employee> repoPersonel = new Repository<Employee>();
        private void btnAra_Click(object sender, EventArgs e)
        {           
            var sonuc = repoPersonel.SelectAll().Where(p => p.TCIndentityNumber == txtAraTcNo.Text);           
            dataGridView1.DataSource = sonuc.ToList();
        }
    }
}
