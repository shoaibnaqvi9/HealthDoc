using System;
using BusinessLogicLayer;
using System.Windows.Forms;

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
            Form f = new admin_portal();
            f.Show();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            try
            {
                if (!int.TryParse(txtPatientid.Text, out int Patientid))
                {
                    MessageBox.Show("Invalid Patient ID. Please enter a valid number.");
                    return;
                }
                string Patientname = txtPatientname.Text;
                DateTime Patientdob = dTPicker1txtPatientdob.Value;
                string Patientgender = txtPatientgender.Text;
                string PatientCNIC = txtCNIC.Text;
                if (!int.TryParse(txtPatientweight.Text, out int Patientweight))
                {
                    MessageBox.Show("Invalid weight. Please enter a valid number.");
                    return;
                }
                string Patientcontact = txtPatientcontact.Text;
                string Patientaddress = txtPatientaddress.Text;

                if (!System.Text.RegularExpressions.Regex.IsMatch(PatientCNIC, @"^\d{13}$"))
                {
                    MessageBox.Show("CNIC must be exactly 13 digits.");
                    return;
                }

                if (!System.Text.RegularExpressions.Regex.IsMatch(Patientcontact, @"^\d{11,12}$"))
                {
                    MessageBox.Show("Contact number must be 11 or 12 digits.");
                    return;
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
                MessageBox.Show("Registered successfully ✅", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                txtPatientid.Clear();
                txtPatientname.Clear();
                txtCNIC.Clear();
                txtPatientweight.Clear();
                txtPatientcontact.Clear();
                txtPatientaddress.Clear();
                dTPicker1txtPatientdob.Value = DateTime.Now;
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
        }
    }
}