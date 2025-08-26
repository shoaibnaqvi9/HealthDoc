using System;
using System.Data;
using BusinessLogicLayer;
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

            doctorName = bll.Dashboard_doctor(doctorid);
            did = bll.Dashboard_doctorname(doctorid);
            lbldoctor.Text = "Welcome, " + doctorName;
        }
        private void LoadAppointments()
        {
            int docId = Convert.ToInt32(did);
            DataTable patientDetails = bll.GetAppointmentsForDoctor(docId);
            dgvDoctor.DataSource = patientDetails;

            if (!dgvDoctor.Columns.Contains("NewStatus"))
            {
                DataGridViewComboBoxColumn statusColumn = new DataGridViewComboBoxColumn
                {
                    HeaderText = "Update Status",
                    Name = "NewStatus"
                };
                statusColumn.Items.AddRange("Pending", "Approved", "Completed", "Cancelled");
                dgvDoctor.Columns.Add(statusColumn);
            }
        }
        private void doctor_checkappointment_Load(object sender, EventArgs e)
        {
            LoadAppointments();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
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
                    if (row.Cells["NewStatus"].Value != null && row.Cells["appointmentId"].Value != null)
                    {
                        int appointmentId = Convert.ToInt32(row.Cells["appointmentId"].Value);
                        string newStatus = row.Cells["NewStatus"].Value.ToString();
                        bll.UpdateAppointmentStatus(appointmentId, newStatus);
                    }
                }
                MessageBox.Show("Appointment statuses updated successfully!", "Appointment Success");
                LoadAppointments();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error while updating status: " + ex.Message);
            }
        }
    }
}