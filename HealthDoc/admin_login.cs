using System;
using BusinessLogicLayer;
using System.Windows.Forms;

namespace HealthDoc
{
    public partial class admin_login : Form
    {
        private BLL _bll;
        private AppointmentNotificationSystem _notificationSystem;
        public admin_login()
        {
            _bll = new BLL();
            InitializeComponent();
            InitializeNotifications();
        }
        private void InitializeNotifications()
        {
            _notificationSystem = AppointmentNotificationSystem.Instance;

            var uiNotification = new UINotification(ShowNotificationMessage);
            _notificationSystem.Attach(uiNotification);
        }
        private void ShowNotificationMessage(string message)
        {
            if (InvokeRequired)
            {
                Invoke(new Action<string>(ShowNotificationMessage), message);
                return;
            }
            MessageBox.Show(message, "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void admin_login_Load(object sender, EventArgs e)
        {
            txtname.Focus();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                string name = txtname.Text.Trim();
                string password = txtpassword.Text.Trim();

                if (string.IsNullOrWhiteSpace(name) || string.IsNullOrWhiteSpace(password))
                {
                    MessageBox.Show("Please enter both username and password");
                    return;
                }

                bool loginSuccessful = _bll.Login_admin(name, password);

                if (loginSuccessful)
                {
                    MessageBox.Show("Logged in successfully ✅", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Hide();
                    Form f = new admin_portal();
                    f.Show();
                }
                else
                {
                    MessageBox.Show("Incorrect ID or password");
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
            Form f = new Dashboard();
            f.Show();
        }

        private void lblPLF_Click(object sender, EventArgs e)
        {

        }

        private void lblpassword_Click(object sender, EventArgs e)
        {

        }

        private void txtpassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblname_Click(object sender, EventArgs e)
        {

        }

        private void txtname_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}