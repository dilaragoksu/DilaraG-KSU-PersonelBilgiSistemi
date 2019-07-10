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
    public partial class frm_AnaForm : Form
    {
        public frm_AnaForm()
        {
            InitializeComponent();
        }
        void FormKontrol(Form form)
        {
            this.Width = form.Width;
            this.Height = form.Height;

            bool GelenFormAcikMi = false;
            foreach (Form item in this.MdiChildren)
            {
                if (item.Text == form.Text)
                {
                    form.Activate();

                    GelenFormAcikMi = true;
                }
                else item.Close();

            }
            if (GelenFormAcikMi == false)
            {
                form.MdiParent = this;
                form.Show();
            }
        }

        private void personelAramaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormKontrol(new frm_PersonelArama());
        }

        private void personelKayıtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormKontrol(new frm_PersonelKayıt());
        }

        private void departmanKayıtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormKontrol(new frm_DepartmanKayıt());
        }

        private void çıkışToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

       
    }
}
