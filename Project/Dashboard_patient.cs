using BusinessLogicLayer;
using System;
using System.Windows.Forms;

namespace HealthDoc
{
    public partial class Dashboard_patient : Form
    {
        private int patientid;
        private string patientName;
        public Dashboard_patient(int patientid)
        {
            InitializeComponent();
            this.patientid = patientid;
            BLL b = new BLL();
            patientName = b.Dashboard_patient(patientid);
            lblPatient.Text = "Welcome, " + patientName;
        }
        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form f = new patient_login();
            f.Show();
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

        private void btnAppointment_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form f = new patient_appointment(patientid);
            f.Show();
        }

        private void Dashboard_patient_Load(object sender, EventArgs e)
        {

        }

        private void lblPRF_Click(object sender, EventArgs e)
        {

        }
    }
}