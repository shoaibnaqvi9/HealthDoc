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
            Form f = new Admin_Portal();
            f.Show();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                int log = int.Parse(txtLogin.Text);
                BLL b = new BLL();
                bool loginSuccessful=b.Login_patient(log);
                if (loginSuccessful)
                {
                    MessageBox.Show("LoggedIn Successfully");
                    this.Hide();
                    Form f = new Dashboard_patient(log);
                    f.Show();
                }
                else
                {
                    MessageBox.Show("Incorrect Patient ID");
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

        private void patient_login_Load(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
            Environment.Exit(0);
        }
    }
}
