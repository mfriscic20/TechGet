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

namespace TechGet
{
    public partial class FrmProcurations : Form
    {
        public FrmProcurations()
        {
            InitializeComponent();
        }

        private void FrmProcurations_Load(object sender, EventArgs e)
        {
            ShowProcurations();
        }

        private void ShowProcurations()
        {
            var procurations = ProcurationRepository.GetProcurations();
            dgvProcurations.DataSource = procurations;

            dgvProcurations.Columns["Id"].DisplayIndex = 0;
            dgvProcurations.Columns["FinanciranjeId"].DisplayIndex = 1;
            dgvProcurations.Columns["Realizirano"].DisplayIndex = 2;
            dgvProcurations.Columns["Datum"].DisplayIndex = 3;
            dgvProcurations.Columns["ZaposlenikId"].DisplayIndex = 4; //koji stupac je za kaj

        }
    }
}
