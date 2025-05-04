using BusinessLogicLayer;
using System;
using System.Windows.Forms;

namespace HealthDoc
{
    public partial class Dashboard_doctor : Form
    {
        private string doctorid;
        private string doctorName;
        public Dashboard_doctor(string doctorid)
        {
            InitializeComponent();
            this.doctorid = doctorid;
            BLL b = new BLL();
            doctorName = b.Dashboard_doctor(doctorid);
            lblDoctor.Text = "Welcome, " + doctorName;
        }

        private void btnAppointment_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form f = new doctor_checkappointment(doctorid);
            f.Show();
        }

        private void Dashboard_doctor_Load(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
            Environment.Exit(0);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
            Environment.Exit(0);
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form f = new doctor_login();
            f.Show();
        }
    }
}
