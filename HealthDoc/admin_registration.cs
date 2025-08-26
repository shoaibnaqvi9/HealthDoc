using System;
using BusinessLogicLayer;
using System.Windows.Forms;
using System.Text.RegularExpressions;

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
                string Adminname = txtAdminname.Text.Trim();
                string Adminpassword = txtAdminpassword.Text.Trim();
                string Adminrepass = txtAdminrepass.Text.Trim();
                string Admincontact = txtAdmincontact.Text.Trim();
                string Adminaddress = txtAdminaddress.Text.Trim();

                if (string.IsNullOrWhiteSpace(Adminname) ||
                    string.IsNullOrWhiteSpace(Adminpassword) ||
                    string.IsNullOrWhiteSpace(Adminrepass) ||
                    string.IsNullOrWhiteSpace(Admincontact) ||
                    string.IsNullOrWhiteSpace(Adminaddress))
                {
                    throw new FormatException("All fields are required.");
                }

                if (!Regex.IsMatch(Adminpassword, @"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[^\da-zA-Z]).{8,}$"))
                {
                    throw new FormatException("Invalid password format. Password must contain at least one uppercase letter, one lowercase letter, one number, one special character, and be at least 8 characters long.");
                }
                if (Adminpassword != Adminrepass)
                {
                    throw new FormatException("Passwords do not match.");
                }
                if (!Regex.IsMatch(Admincontact, @"^\d{12}$"))
                {
                    throw new FormatException("Invalid contact number format. Contact number must be 12 digits long.");
                }

                AdminRegistration adminRegistration = new AdminRegistration
                {
                    Adminname = Adminname,
                    Adminpassword = Adminpassword,
                    Adminrepass = Adminrepass,
                    Admincontact = Admincontact,
                    Adminaddress = Adminaddress
                };

                adminRegistration.Register();

                MessageBox.Show("Admin registered successfully ✅", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                txtAdminname.Clear();
                txtAdminpassword.Clear();
                txtAdminrepass.Clear();
                txtAdmincontact.Clear();
                txtAdminaddress.Clear();
            }
            catch (FormatException ex)
            {
                MessageBox.Show("Invalid input: " + ex.Message, "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            Dashboard f = new Dashboard();
            f.Show();
        }

        private void admin_registration_Load(object sender, EventArgs e)
        {

        }
    }
}
