using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessLogicLayer;
using System.Data.SqlClient;
namespace HealthDoc
{
    public partial class server_connection : Form
    {
        private const string ConfigFilePath = "config.txt";
        public server_connection()
        {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            string server = txtServer.Text;
            string database = txtDName.Text;
            string db_username = txtDID.Text;
            string db_password = txtDPassword.Text;
            if (IsDataValid(server, database, db_username, db_password))
            {
                SaveConnectionDetails(server, database, db_username, db_password);
                OpenForm2();
            }
            else
            {
                MessageBox.Show("Invalid data provided. Please make sure all fields are filled correctly.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private bool IsDataValid(string server, string database, string db_username, string db_password)
        {
            if (string.IsNullOrWhiteSpace(server) || string.IsNullOrWhiteSpace(database) || string.IsNullOrWhiteSpace(db_username) || string.IsNullOrWhiteSpace(db_password))
            {
                return false;
            }

            string connectionString = $"Server={server};Database={database};User ID={db_username};Password={db_password};";

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    return true;
                }
            }
            catch (SqlException)
            {
                return false;
            }
        }
        private void SaveConnectionDetails(string server, string database, string db_username, string db_password)
        {
            try
            {
                using (StreamWriter writer = new StreamWriter(ConfigFilePath))
                {
                    writer.WriteLine(server);
                    writer.WriteLine(database);
                    writer.WriteLine(db_username);
                    writer.WriteLine(db_password);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Failed to save connection details: {ex.Message}");
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void OpenForm2()
        {
            Form f = new Dashboard();
            f.Shown += (sender, e) =>
            {
                this.Hide();
            };
            f.Show();
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
            Environment.Exit(0);
        }
        private void server_connection_Load(object sender, EventArgs e)
        {
            if (File.Exists(ConfigFilePath))
            {
                string[] lines = File.ReadAllLines(ConfigFilePath);
                if (lines.Length >= 4)
                {
                    string server = lines[0];
                    string database = lines[1];
                    string db_username = lines[2];
                    string db_password = lines[3];
                    if (IsDataValid(server, database, db_username, db_password))
                    {
                        OpenForm2();
                        return;
                    }
                    else
                    {
                        MessageBox.Show("Incorrect data found in the configuration file. Please provide valid connection details.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
            Environment.Exit(0);
        }
    }
}