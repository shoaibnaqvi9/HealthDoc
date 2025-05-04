using BusinessLogicLayer;
using HealthDoc;
using System;
using System.Windows.Forms;

namespace HealthDoc
{
    public partial class doctor_login : Form
    {
        public doctor_login()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                string log = txtLogin.Text;
                BLL b = new BLL();
                bool loginSuccessful = b.Login_doctor(log);
                if (loginSuccessful)
                {
                    MessageBox.Show("LoggedIn Successfully");
                    this.Hide();
                    Form f = new Dashboard_doctor(log);
                    f.Show();
                }
                else
                {
                    MessageBox.Show("Incorrect Doctor ID");
                }
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
        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form f = new Admin_Portal();
            f.Show();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
            Environment.Exit(0);
        }

        private void doctor_login_Load(object sender, EventArgs e)
        {

        }
    }
}