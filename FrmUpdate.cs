using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TechGet.Repositories;
using TechGet.Models;


namespace TechGet
{
    public partial class FrmUpdate : Form
    {
        public static List<Procuration> nabava { get; set; }
        public FrmUpdate()
        {
            InitializeComponent();
        }

        private void FrmUpdate_Load(object sender, EventArgs e)
        {

            
        nabava=ProcurationRepository.GetProcurations();
            cboOdaberiNabavu.DataSource = nabava;
            dgvAzurirajNabavu.DataSource = nabava;

            
        }

        private void cboOdaberiNabavu_SelectedIndexChanged(object sender, EventArgs e)
        {
            Procuration selected = nabava[cboOdaberiNabavu.SelectedIndex];
            txtIdAzuriranje.Text = selected.Opis_predmeta_nabave;
        }
    }
}
