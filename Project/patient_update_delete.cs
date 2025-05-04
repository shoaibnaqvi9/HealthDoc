using BusinessLogicLayer;
using System;
using System.Windows.Forms;

namespace HealthDoc
{
    public partial class patient_update_delete : Form
    {
        public patient_update_delete()
        {
            InitializeComponent();
        }

        private void patient_update_delete_Load(object sender, EventArgs e)
        {

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form f = new Admin_Portal();
            f.Show();
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {

            try
            {
                int pid = int.Parse(txtpatientid.Text);
                string pcontact = txtpatientcontact.Text;
                if (!System.Text.RegularExpressions.Regex.IsMatch(pcontact, @"^\d{12}$"))
                {
                    throw new FormatException("Invalid contact number format. Contact number must be 12 digits long and contain only numbers.");
                }
                PatientUpdate patientUpdate = new PatientUpdate();
                patientUpdate.Patientid = pid;
                patientUpdate.Patientcontact = pcontact;
                patientUpdate.Register();
                MessageBox.Show("Updated successfully");
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

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                int pid = int.Parse(txtpatientid.Text);
                BLL b = new BLL();
                b.Patient_Delete(pid);
                MessageBox.Show("Patient ID deleted successfully");
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

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
            Environment.Exit(0);
        }
    }
}