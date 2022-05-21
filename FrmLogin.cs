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
    public partial class FrmLogin : Form
    {

        public static Person LoggedEmployee { get; set; }
        public FrmLogin()
        {
            InitializeComponent();
        }

     

        private void btnLogin_Click(object sender, EventArgs e)
        {

            LoggedEmployee = PersonRepository.GetPerson(txtUsername.Text); // sa strelicama biras koju oces od overloadanih, u ovom txt je korisnicko ime nas

            if (txtUsername.Text == "")
            {
                MessageBox.Show("Korisničko ime nije uneseno!", "Problem", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txtPassword.Text == "")
            {
                MessageBox.Show("Lozinka nije unesena!", "Problem", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                // if (txtUsername.Text == username && txtPassword.Text == password)
                if (LoggedEmployee != null & LoggedEmployee.CheckPassword(txtPassword.Text))
                {
                    Form1 frmEmployees = new Form1();
                    Hide();
                    frmEmployees.ShowDialog();
                    Close();
                }
                else
                {
                    MessageBox.Show("Krivi podaci!", "Problem", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }


    }

