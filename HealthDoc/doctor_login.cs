using System;
using BusinessLogicLayer;
using System.Windows.Forms;

namespace HealthDoc
{
    public partial class doctor_login : Form
    {
        private readonly BLL _bll;
        public doctor_login()
        {
            InitializeComponent();
            _bll = new BLL();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                string log = txtLogin.Text;


                if (string.IsNullOrWhiteSpace(log))
                {
                    MessageBox.Show("Please enter Doctor ID");
                    return;
                }
                
                bool loginSuccessful = _bll.Login_doctor(log);
                if (loginSuccessful)
                {
                    MessageBox.Show("Logged in successfully ✅", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Dashboard_doctor f = new Dashboard_doctor(log);
                    f.Show();
                    this.Close();
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
            Form f = new admin_portal();
            f.Show();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void doctor_login_Load(object sender, EventArgs e)
        {

        }
    }
}