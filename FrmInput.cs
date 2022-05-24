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

            int id=int.Parse(txtId.Text);

            int ur_broj = int.Parse(txtUrBroj.Text);
            int klasa=int.Parse(txtKlasa.Text);
            string datum = txtDatum1.Text;
            string opis_predmeta_nabave = txtOpisPredmetaNabave.Text;
            int br_projekta = int.Parse(txtBrojProjekta.Text);

            int p1_odabrano = int.Parse(txtPonuda1Odabrano.Text);
            int p2_odabrano = int.Parse(txtPonuda2Odabrano.Text);
            //ne popunjavaju se sekundarni ključevi
            int p1_cijena=int.Parse(txtPonuda1Cijena.Text);
            int p2_cijena = int.Parse(txtPonuda2Cijena.Text);

            string p1_ponuditelj=txtPonuda1Ponuditelj.Text;
            string p2_ponuditelj = txtPonuda2Ponuditelj.Text;

            string naziv_projekta=txtNazivProjekta.Text;
            string dodatna_pojasnjenja=txtDodatnaPojasnjenja.Text;

            

            //id se dohvaca sam
            //realizirano je po defaultu 0
            //zaposlenik se dohvaca ko this zaposlenik nekak

            string  izvor_financiranja=cboFundingSources.Text;





            //tak za sve

            Procuration nova_nabava = new Procuration();

            nova_nabava.Id=id;
            nova_nabava.Realizirano = 0;
            nova_nabava.ur_broj= ur_broj;
            nova_nabava.klasa=klasa;
            nova_nabava.Opis_predmeta_nabave = opis_predmeta_nabave;
            nova_nabava.p1_odabrano= p1_odabrano;
            nova_nabava.p1_cijena = p1_cijena;
            nova_nabava.p1_ponuditelj = p1_ponuditelj;
            nova_nabava.p2_odabrano = p2_odabrano;
            nova_nabava.p2_cijena = p2_cijena;
            nova_nabava.p2_ponuditelj = p2_ponuditelj;
            nova_nabava.br_projekta=br_projekta;
            nova_nabava.naziv_projekta = naziv_projekta;
            nova_nabava.Datum = datum;

            nova_nabava.dodatna_pojasnjenja = dodatna_pojasnjenja;
            nova_nabava.FinanciranjeId = FundingSourceRepository.GetFundingSource(cboFundingSources.SelectedIndex);
            nova_nabava.ZaposlenikId=PersonRepository.GetPerson(FrmLogin.LoggedEmployee.Id);

            //this.zaposlenik isti način ko na vježbama
            //svojstva preimenuj da pocnu velikim slovom


            ProcurationRepository.InsertProcuration(nova_nabava);
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click_1(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void bntUrediNabavu_Click(object sender, EventArgs e)
        {
            FrmUpdate frmUpdates = new FrmUpdate();
            Hide();
            frmUpdates.ShowDialog();
            Close();
        }
    }
}
