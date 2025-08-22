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
    public partial class admin_registration : Form
    {
        public admin_registration()
        {
            InitializeComponent();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            try
            {
                string Adminname = txtAdminname.Text;
                string Adminpassword = txtAdminpassword.Text;
                string Adminrepass = txtAdminrepass.Text;
                string Admincontact = txtAdmincontact.Text;
                string Adminaddress = txtAdminaddress.Text;

                if (!System.Text.RegularExpressions.Regex.IsMatch(Adminpassword, @"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[^\da-zA-Z]).{8,}$"))
                {
                    throw new FormatException("Invalid password format. Password must contain at least one uppercase letter, one lowercase letter, one number, one special character, and be at least 8 characters long.");
                }
                if (Adminpassword != Adminrepass)
                {
                    throw new FormatException("Passwords do not match.");
                }
                if (!System.Text.RegularExpressions.Regex.IsMatch(Admincontact, @"^\d{12}$"))
                {
                    throw new FormatException("Invalid contact number format. Contact number must be 12 digits long and contain only numbers.");
                }
                AdminRegistration adminRegistration = new AdminRegistration();
                adminRegistration.Adminname=Adminname;
                adminRegistration.Adminpassword=Adminpassword;
                adminRegistration.Adminrepass=Adminrepass;
                adminRegistration.Admincontact=Admincontact;
                adminRegistration.Adminaddress=Adminaddress;
                adminRegistration.Register();
                
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

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
            Environment.Exit(0);
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form f = new Dashboard();
            f.Show();
        }

        private void admin_registration_Load(object sender, EventArgs e)
        {

        }
    }
}
