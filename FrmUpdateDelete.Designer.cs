namespace TechGet
{
    partial class FrmUpdateDelete
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
            this.cboOdaberiNabavu = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvAzurirajNabavu = new System.Windows.Forms.DataGridView();
            this.txtOpisPredmetaAzuriranje = new System.Windows.Forms.TextBox();
            this.txtNazivProjektaAzuriranje = new System.Windows.Forms.TextBox();
            this.txtDodatnaPojasnjenjaAzuriranje = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnUrediNabavu = new System.Windows.Forms.Button();
            this.btnObrisiNabavu = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAzurirajNabavu)).BeginInit();
            this.SuspendLayout();
            // 
            // cboOdaberiNabavu
            // 
            this.cboOdaberiNabavu.FormattingEnabled = true;
            this.cboOdaberiNabavu.Location = new System.Drawing.Point(134, 12);
            this.cboOdaberiNabavu.Name = "cboOdaberiNabavu";
            this.cboOdaberiNabavu.Size = new System.Drawing.Size(191, 21);
            this.cboOdaberiNabavu.TabIndex = 0;
            this.cboOdaberiNabavu.SelectedIndexChanged += new System.EventHandler(this.cboOdaberiNabavu_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "ODABERI NABAVU";
            // 
            // dgvAzurirajNabavu
            // 
            this.dgvAzurirajNabavu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAzurirajNabavu.Location = new System.Drawing.Point(15, 66);
            this.dgvAzurirajNabavu.Name = "dgvAzurirajNabavu";
            this.dgvAzurirajNabavu.Size = new System.Drawing.Size(1400, 106);
            this.dgvAzurirajNabavu.TabIndex = 2;
            // 
            // txtOpisPredmetaAzuriranje
            // 
            this.txtOpisPredmetaAzuriranje.Location = new System.Drawing.Point(15, 278);
            this.txtOpisPredmetaAzuriranje.Multiline = true;
            this.txtOpisPredmetaAzuriranje.Name = "txtOpisPredmetaAzuriranje";
            this.txtOpisPredmetaAzuriranje.Size = new System.Drawing.Size(159, 56);
            this.txtOpisPredmetaAzuriranje.TabIndex = 3;
            this.txtOpisPredmetaAzuriranje.TextChanged += new System.EventHandler(this.txtIdAzuriranje_TextChanged);
            // 
            // txtNazivProjektaAzuriranje
            // 
            this.txtNazivProjektaAzuriranje.Location = new System.Drawing.Point(290, 278);
            this.txtNazivProjektaAzuriranje.Multiline = true;
            this.txtNazivProjektaAzuriranje.Name = "txtNazivProjektaAzuriranje";
            this.txtNazivProjektaAzuriranje.Size = new System.Drawing.Size(167, 115);
            this.txtNazivProjektaAzuriranje.TabIndex = 4;
            this.txtNazivProjektaAzuriranje.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtDodatnaPojasnjenjaAzuriranje
            // 
            this.txtDodatnaPojasnjenjaAzuriranje.Location = new System.Drawing.Point(563, 278);
            this.txtDodatnaPojasnjenjaAzuriranje.Multiline = true;
            this.txtDodatnaPojasnjenjaAzuriranje.Name = "txtDodatnaPojasnjenjaAzuriranje";
            this.txtDodatnaPojasnjenjaAzuriranje.Size = new System.Drawing.Size(152, 115);
            this.txtDodatnaPojasnjenjaAzuriranje.TabIndex = 5;
            this.txtDodatnaPojasnjenjaAzuriranje.TextChanged += new System.EventHandler(this.txtDodatnaPojasnjenjaAzuriranje_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 221);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Opis predmeta nabave";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(560, 221);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Dodatna pojašnjenja";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(290, 220);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Naziv projekta";
            // 
            // btnUrediNabavu
            // 
            this.btnUrediNabavu.Location = new System.Drawing.Point(845, 278);
            this.btnUrediNabavu.Name = "btnUrediNabavu";
            this.btnUrediNabavu.Size = new System.Drawing.Size(167, 67);
            this.btnUrediNabavu.TabIndex = 9;
            this.btnUrediNabavu.Text = "UREDI NABAVU";
            this.btnUrediNabavu.UseVisualStyleBackColor = true;
            this.btnUrediNabavu.Click += new System.EventHandler(this.btnUrediNabavu_Click);
            // 
            // btnObrisiNabavu
            // 
            this.btnObrisiNabavu.Location = new System.Drawing.Point(1098, 278);
            this.btnObrisiNabavu.Name = "btnObrisiNabavu";
            this.btnObrisiNabavu.Size = new System.Drawing.Size(167, 67);
            this.btnObrisiNabavu.TabIndex = 10;
            this.btnObrisiNabavu.Text = "IZBRIŠI NABAVU";
            this.btnObrisiNabavu.UseVisualStyleBackColor = true;
            this.btnObrisiNabavu.Click += new System.EventHandler(this.btnObrisiNabavu_Click);
            // 
            // FrmUpdateDelete
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1416, 519);
            this.Controls.Add(this.btnObrisiNabavu);
            this.Controls.Add(this.btnUrediNabavu);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtDodatnaPojasnjenjaAzuriranje);
            this.Controls.Add(this.txtNazivProjektaAzuriranje);
            this.Controls.Add(this.txtOpisPredmetaAzuriranje);
            this.Controls.Add(this.dgvAzurirajNabavu);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cboOdaberiNabavu);
            this.Name = "FrmUpdateDelete";
            this.Text = "FrmUpdate";
            this.Load += new System.EventHandler(this.FrmUpdate_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAzurirajNabavu)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cboOdaberiNabavu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvAzurirajNabavu;
        private System.Windows.Forms.TextBox txtOpisPredmetaAzuriranje;
        private System.Windows.Forms.TextBox txtNazivProjektaAzuriranje;
        private System.Windows.Forms.TextBox txtDodatnaPojasnjenjaAzuriranje;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnUrediNabavu;
        private System.Windows.Forms.Button btnObrisiNabavu;
    }
}