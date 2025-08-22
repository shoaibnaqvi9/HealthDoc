using BusinessLogicLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HealthDoc
{
    public partial class doctor_checkappointment : Form
    {
        private string doctorid;
        private string doctorName;
        private string did;
        private BLL bll = new BLL();
        public doctor_checkappointment(string doctorid)
        {
            InitializeComponent();
            this.doctorid = doctorid;
            BLL b = new BLL();
            doctorName = b.Dashboard_doctor(doctorid);
            did = b.Dashboard_doctorname(doctorid);
            lbldoctor.Text = "Welcome, " + doctorName;
        }

        private void doctor_checkappointment_Load(object sender, EventArgs e)
        {
            try
            {
                //DataTable patientDetails = bll.GetAppointmentsForDoctor(Convert.ToInt32(did));
                DataTable patientDetails = bll.GetPatientDetails();
                dgvDoctor.DataSource = patientDetails;
                if (!dgvDoctor.Columns.Contains("NewStatus"))
                {
                    DataGridViewComboBoxColumn statusColumn = new DataGridViewComboBoxColumn();
                    statusColumn.HeaderText = "Update Status";
                    statusColumn.Name = "NewStatus";
                    statusColumn.Items.AddRange("Pending", "Approved", "Completed", "Cancelled");
                    dgvDoctor.Columns.Add(statusColumn);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
            Environment.Exit(0);

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
            Environment.Exit(0);
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form f = new Dashboard_doctor(doctorid);
            f.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void dgvDoctor_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnUpdateStatus_Click(object sender, EventArgs e)
        {
            try
            {
                foreach (DataGridViewRow row in dgvDoctor.Rows)
                {
                    if (row.Cells["NewStatus"].Value != null)
                    {
                        int appointmentId = Convert.ToInt32(row.Cells["appointmentId"].Value);
                        string newStatus = row.Cells["NewStatus"].Value.ToString();
                        bll.UpdateAppointmentStatus(appointmentId, newStatus);
                    }
                }

                MessageBox.Show("Appointment statuses updated successfully!");
                doctor_checkappointment_Load(null, null);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error while updating status: " + ex.Message);
            }
        }
    }
}
