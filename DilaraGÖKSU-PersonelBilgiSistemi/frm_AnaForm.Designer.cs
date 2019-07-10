namespace DilaraGÖKSU_PersonelBilgiSistemi
{
    partial class frm_AnaForm
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.personelBilgileriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.personelAramaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.personelKayıtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.departmanBilgileriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.departmanKayıtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.çıkışToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.personelBilgileriToolStripMenuItem,
            this.departmanBilgileriToolStripMenuItem,
            this.çıkışToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // personelBilgileriToolStripMenuItem
            // 
            this.personelBilgileriToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.personelAramaToolStripMenuItem,
            this.personelKayıtToolStripMenuItem});
            this.personelBilgileriToolStripMenuItem.Name = "personelBilgileriToolStripMenuItem";
            this.personelBilgileriToolStripMenuItem.Size = new System.Drawing.Size(131, 24);
            this.personelBilgileriToolStripMenuItem.Text = "Personel Bilgileri";
            // 
            // personelAramaToolStripMenuItem
            // 
            this.personelAramaToolStripMenuItem.Name = "personelAramaToolStripMenuItem";
            this.personelAramaToolStripMenuItem.Size = new System.Drawing.Size(187, 26);
            this.personelAramaToolStripMenuItem.Text = "Personel Arama";
            this.personelAramaToolStripMenuItem.Click += new System.EventHandler(this.personelAramaToolStripMenuItem_Click);
            // 
            // personelKayıtToolStripMenuItem
            // 
            this.personelKayıtToolStripMenuItem.Name = "personelKayıtToolStripMenuItem";
            this.personelKayıtToolStripMenuItem.Size = new System.Drawing.Size(187, 26);
            this.personelKayıtToolStripMenuItem.Text = "Personel Kayıt";
            this.personelKayıtToolStripMenuItem.Click += new System.EventHandler(this.personelKayıtToolStripMenuItem_Click);
            // 
            // departmanBilgileriToolStripMenuItem
            // 
            this.departmanBilgileriToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.departmanKayıtToolStripMenuItem});
            this.departmanBilgileriToolStripMenuItem.Name = "departmanBilgileriToolStripMenuItem";
            this.departmanBilgileriToolStripMenuItem.Size = new System.Drawing.Size(151, 24);
            this.departmanBilgileriToolStripMenuItem.Text = "Departman Bilgileri";
            // 
            // departmanKayıtToolStripMenuItem
            // 
            this.departmanKayıtToolStripMenuItem.Name = "departmanKayıtToolStripMenuItem";
            this.departmanKayıtToolStripMenuItem.Size = new System.Drawing.Size(196, 26);
            this.departmanKayıtToolStripMenuItem.Text = "Departman Kayıt";
            this.departmanKayıtToolStripMenuItem.Click += new System.EventHandler(this.departmanKayıtToolStripMenuItem_Click);
            // 
            // çıkışToolStripMenuItem
            // 
            this.çıkışToolStripMenuItem.Name = "çıkışToolStripMenuItem";
            this.çıkışToolStripMenuItem.Size = new System.Drawing.Size(51, 24);
            this.çıkışToolStripMenuItem.Text = "Çıkış";
            this.çıkışToolStripMenuItem.Click += new System.EventHandler(this.çıkışToolStripMenuItem_Click);
            // 
            // frm_AnaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frm_AnaForm";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem personelBilgileriToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem personelAramaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem personelKayıtToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem departmanBilgileriToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem departmanKayıtToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem çıkışToolStripMenuItem;
    }
}

