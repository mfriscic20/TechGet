namespace TechGet
{
    partial class FrmProcurations
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
            this.dgvProcurations = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProcurations)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvProcurations
            // 
            this.dgvProcurations.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProcurations.Location = new System.Drawing.Point(2, 1);
            this.dgvProcurations.Name = "dgvProcurations";
            this.dgvProcurations.Size = new System.Drawing.Size(735, 409);
            this.dgvProcurations.TabIndex = 0;
            // 
            // FrmProcurations
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgvProcurations);
            this.Name = "FrmProcurations";
            this.Text = "FrmProcurations";
            this.Load += new System.EventHandler(this.FrmProcurations_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProcurations)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvProcurations;
    }
}