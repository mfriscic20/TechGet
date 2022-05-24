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
        public FrmUpdate()
        {
            InitializeComponent();
        }

        private void FrmUpdate_Load(object sender, EventArgs e)
        {
            var nabava=ProcurationRepository.GetProcurations();
            cboOdaberiNabavu.DataSource = nabava;
            dgvAzurirajNabavu.DataSource = nabava;

            
        }
    }
}
