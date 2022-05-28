using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TechGet.Models;
using TechGet.Repositories;

namespace TechGet
{
    public partial class FrmAzuriraj : Form
    {

        private Procuration procuration;

        public Procuration selected_procuration { get => procuration; set=> procuration = value; }
        public FrmAzuriraj(Procuration selected_procuration)
        {
            InitializeComponent();
            this.selected_procuration = selected_procuration;
        }

        private void FrmAzuriraj_Load(object sender, EventArgs e)
        {
            txtUrBroj.Text = this.selected_procuration.ur_broj.ToString();
            //tak napravi za sve elemente
        }

        private void txtUrBroj_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var objekt_nabava = this.selected_procuration;
            int ur_broj = int.Parse(txtUrBroj.Text.ToString());
            ProcurationRepository.UpdateProcuration(objekt_nabava, ur_broj);
            //opet za sve
            Close();
            FrmUpdateDelete frmUpdateDelete = new FrmUpdateDelete();
            frmUpdateDelete.ShowDialog();


        }
    }
}
