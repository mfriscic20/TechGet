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
    public partial class FrmChooseOperation : Form
    {
        public static List<Procuration> nabava { get; set; }
        public FrmChooseOperation()
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
            txtOpisPredmetaAzuriranje.Text = selected.Opis_predmeta_nabave;

        }

        private void txtIdAzuriranje_TextChanged(object sender, EventArgs e)
        {

            Procuration selected = nabava[cboOdaberiNabavu.SelectedIndex];
            txtNazivProjektaAzuriranje.Text = selected.naziv_projekta;


        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

            Procuration selected = nabava[cboOdaberiNabavu.SelectedIndex];
            txtNazivProjektaAzuriranje.Text = selected.naziv_projekta;

        }

        private void txtDodatnaPojasnjenjaAzuriranje_TextChanged(object sender, EventArgs e)
        {
            Procuration selected = nabava[cboOdaberiNabavu.SelectedIndex];
            txtDodatnaPojasnjenjaAzuriranje.Text = selected.dodatna_pojasnjenja;
        }

        private void btnUrediNabavu_Click(object sender, EventArgs e)
        {
            Procuration odabrana_nabava=dgvAzurirajNabavu.CurrentRow.DataBoundItem as Procuration;
            FrmUpdate frmAzuriraj = new FrmUpdate(odabrana_nabava);
            Hide();
            frmAzuriraj.ShowDialog();
            Close();
            
        }

        private void btnObrisiNabavu_Click(object sender, EventArgs e)
        {
            Procuration odabrana_nabava = dgvAzurirajNabavu.CurrentRow.DataBoundItem as Procuration;
            ProcurationRepository.DeleteProcuration(odabrana_nabava);
            MessageBox.Show("Uspješno ste obrisali nabavu!");

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
           var za_search= ProcurationRepository.SearchProcurations(textBox1.Text);
           dgvAzurirajNabavu.DataSource= za_search;
        }
    }
}
