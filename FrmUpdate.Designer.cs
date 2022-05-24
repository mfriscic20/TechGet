namespace TechGet
{
    partial class FrmUpdate
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
            this.txtIdAzuriranje = new System.Windows.Forms.TextBox();
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
            // txtIdAzuriranje
            // 
            this.txtIdAzuriranje.Location = new System.Drawing.Point(134, 218);
            this.txtIdAzuriranje.Name = "txtIdAzuriranje";
            this.txtIdAzuriranje.Size = new System.Drawing.Size(100, 20);
            this.txtIdAzuriranje.TabIndex = 3;
            // 
            // FrmUpdate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1416, 519);
            this.Controls.Add(this.txtIdAzuriranje);
            this.Controls.Add(this.dgvAzurirajNabavu);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cboOdaberiNabavu);
            this.Name = "FrmUpdate";
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
        private System.Windows.Forms.TextBox txtIdAzuriranje;
    }
}