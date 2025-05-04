using System;
using System.Windows.Forms;

namespace HealthDoc
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        private void btnrgdoc_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form f = new doctor_registration();
            f.Show();
        }

        private void btnlgdoc_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form f = new doctor_login();
            f.Show();
        }

        private void btnrgpat_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form f = new patient_registration();
            f.Show();
        }

        private void btnlgpat_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form f = new patient_login();
            f.Show();
        }

        private void btnrgadm_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form f = new admin_registration();
            f.Show();
        }

        private void btnlgadm_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form f = new admin_login();
            f.Show();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
            Environment.Exit(0);
        }

        private void lbldoc_Click(object sender, EventArgs e)
        {

        }

        private void lblpat_Click(object sender, EventArgs e)
        {

        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
            Environment.Exit(0);
        }
    }
}