using BusinessLogicLayer;
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
    public partial class doctor_registration : Form
    {
        public doctor_registration()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
            Environment.Exit(0);
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

        private void doctor_registration_Load(object sender, EventArgs e)
        {
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form f = new Admin_Portal();
            f.Show();
        }
    }
}
