namespace DilaraGÖKSU_PersonelBilgiSistemi
{
    partial class frm_PersonelArama
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
            this.txtAraTcNo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnAra = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtAraTcNo
            // 
            this.txtAraTcNo.Location = new System.Drawing.Point(271, 33);
            this.txtAraTcNo.Name = "txtAraTcNo";
            this.txtAraTcNo.Size = new System.Drawing.Size(191, 34);
            this.txtAraTcNo.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(64, 37);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(182, 29);
            this.label3.TabIndex = 12;
            this.label3.Text = "TC Kimlik No :";
            // 
            // btnAra
            // 
            this.btnAra.BackColor = System.Drawing.Color.Olive;
            this.btnAra.Location = new System.Drawing.Point(502, 29);
            this.btnAra.Name = "btnAra";
            this.btnAra.Size = new System.Drawing.Size(117, 44);
            this.btnAra.TabIndex = 11;
            this.btnAra.Text = "Ara";
            this.btnAra.UseVisualStyleBackColor = false;
            this.btnAra.Click += new System.EventHandler(this.btnAra_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(34, 103);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1003, 316);
            this.dataGridView1.TabIndex = 14;
            // 
            // frm_PersonelArama
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1070, 447);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txtAraTcNo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnAra);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Name = "frm_PersonelArama";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "frm_PersonelArama";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtAraTcNo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnAra;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}