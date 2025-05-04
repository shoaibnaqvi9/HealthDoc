using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HealthDoc
{
    public partial class Admin_Portal : Form
    {
        public Admin_Portal()
        {
            InitializeComponent();
        }

        private void Admin_Portal_Load(object sender, EventArgs e)
        {

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

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form f = new Dashboard();
            f.Show();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
            Environment.Exit(0);
        }

        private void btnupdatedelete_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form f = new patient_update_delete();
            f.Show();
        }
    }
}
