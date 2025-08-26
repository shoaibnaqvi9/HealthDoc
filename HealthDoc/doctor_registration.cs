using System;
using BusinessLogicLayer;
using System.Windows.Forms;

namespace HealthDoc
{
    public partial class doctor_registration : Form
    {
        public doctor_registration()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            try
            {
                int Doctorid = int.Parse(txtDoctorid.Text);
                string Doctorname = txtDoctorname.Text;
                string Doctorspecialization = txtDoctorspecialization.Text;
                string Doctorcontact = txtDoctorcontact.Text;
                string Doctoraddress = txtDoctoraddress.Text;

                if (Doctorid <= 0)
                {
                    throw new FormatException("Doctor ID must be a positive number.");
                }
                if (string.IsNullOrWhiteSpace(Doctorname))
                {
                    throw new FormatException("Doctor name cannot be empty.");
                }
                if (!System.Text.RegularExpressions.Regex.IsMatch(Doctorname, @"^[a-zA-Z\s]+$"))
                {
                    throw new FormatException("Doctor name should only contain alphabets.");
                }
                if (string.IsNullOrWhiteSpace(Doctorspecialization))
                {
                    throw new FormatException("Specialization cannot be empty.");
                }
                if (string.IsNullOrWhiteSpace(Doctoraddress))
                {
                    throw new FormatException("Address cannot be empty.");
                }

                if (!System.Text.RegularExpressions.Regex.IsMatch(Doctorcontact, @"^\d{12}$"))
                {
                    throw new FormatException("Invalid contact number format. Contact number must be 12 digits long and contain only numbers.");
                }
                DoctorRegistration doctorRegistration = new DoctorRegistration();
                doctorRegistration.Doctorid = Doctorid;
                doctorRegistration.Doctorname = Doctorname;
                doctorRegistration.Doctorspecialization = Doctorspecialization;
                doctorRegistration.Doctorcontact = Doctorcontact;
                doctorRegistration.Doctoraddress = Doctoraddress;
                
                doctorRegistration.Register();
                
                MessageBox.Show("Registered successfully ✅", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                txtDoctorid.Clear();
                txtDoctorname.Clear();
                txtDoctorcontact.Clear();
                txtDoctoraddress.Clear();
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

        private void doctor_registration_Load(object sender, EventArgs e)
        {
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form f = new admin_portal();
            f.Show();
        }
    }
}
