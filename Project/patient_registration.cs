using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessLogicLayer;
namespace HealthDoc
{
    public partial class patient_registration : Form
    {
        public patient_registration()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form f = new Admin_Portal();
            f.Show();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            try
            {
                int Patientid = int.Parse(txtPatientid.Text);
                string Patientname = txtPatientname.Text;
                DateTime Patientdob = DateTime.Parse(dTPicker1txtPatientdob.Text);
                string Patientgender = txtPatientgender.Text;
                string PatientCNIC = txtCNIC.Text;
                int Patientweight = int.Parse(txtPatientweight.Text);
                string Patientcontact = txtPatientcontact.Text;
                string Patientaddress = txtPatientaddress.Text;

                if (!System.Text.RegularExpressions.Regex.IsMatch(PatientCNIC, @"^\d{13}$"))
                {
                    throw new FormatException("Invalid CNIC format. CNIC must be 13 digits long and contain only numbers.");
                }

                if (!System.Text.RegularExpressions.Regex.IsMatch(Patientcontact, @"^\d{12}$"))
                {
                    throw new FormatException("Invalid contact number format. Contact number must be 12 digits long and contain only numbers.");
                }
                PatientRegistration patientRegistration = new PatientRegistration();
                patientRegistration.Patientid = Patientid;
                patientRegistration.Patientname = Patientname;
                patientRegistration.Patientdob = Patientdob;
                patientRegistration.Patientgender = Patientgender;
                patientRegistration.PatientCNIC = PatientCNIC;
                patientRegistration.Patientweight = Patientweight;
                patientRegistration.Patientcontact = Patientcontact;
                patientRegistration.Patientaddress = Patientaddress;

                patientRegistration.Register();
                MessageBox.Show("Registered");
            }
            catch (FormatException ex)
            {
                MessageBox.Show("Invalid input format: " + ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }

        private void patient_registration_Load(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
            Environment.Exit(0);
        }
    }
}