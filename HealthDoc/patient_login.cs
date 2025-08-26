using System;
using System.Windows.Forms;
using BusinessLogicLayer;
namespace HealthDoc
{
    public partial class patient_login : Form
    {
        public patient_login()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form f = new admin_portal();
            f.Show();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                if (!int.TryParse(txtLogin.Text.Trim(), out int log))
                {
                    MessageBox.Show("Please enter a valid numeric Patient ID.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                BLL b = new BLL();
                bool loginSuccessful = b.Login_patient(log);

                if (loginSuccessful)
                {
                    MessageBox.Show("Logged in successfully ✅", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Hide();
                    Form f = new Dashboard_patient(log);
                    f.Show();
                }
                else
                {
                    MessageBox.Show("Incorrect Patient ID. Please try again.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtLogin.Clear();
                    txtLogin.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An unexpected error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void patient_login_Load(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
