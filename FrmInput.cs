using DBLayer;
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
    public partial class FrmInput : Form
    {

       
        public FrmInput() 
        {
            InitializeComponent();
            //fundingSource=selectedSource;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            List<FundingSource> fundingSources = FundingSourceRepository.GetFundingSources();
            cboFundingSources.DataSource = fundingSources;
            
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void textBox13_TextChanged(object sender, EventArgs e)
        {

        }

        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void label18_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

            FrmProcurations frmProcurations = new FrmProcurations();
            Hide();
            frmProcurations.ShowDialog();
            Close();

        }

      

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void cboFundingSources_SelectedIndexChanged(object sender, EventArgs e)
        {
            FundingSource currentSource= cboFundingSources.SelectedItem as FundingSource;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int ur_broj = int.Parse(txtUrBroj.Text);
            int klasa=int.Parse(txtKlasa.Text);
            //string opis_predmeta_nabave = int.Parse(txtOpisPredmetaNabave).ToString();
            int br_projekta = int.Parse(txtBrojProjekta.Text);
            int p1_odabrano = int.Parse(txtPonuda1Odabrano.Text);
            int p2_odabrano = int.Parse(txtPonuda2Odabrano.Text);
            //realizirano se ne popunjava na formi, deni da smije biti null




            //tak za sve

            Procuration nova_nabava = new Procuration();
            nova_nabava.ur_broj= ur_broj;
            //this.zaposlenik isti način ko na vježbama
            //svojstva preimenuj da pocnu velikim slovom

            
                ProcurationRepository.InsertEvaluation(nova_nabava);
        }
    }
}
