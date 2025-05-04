using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using BusinessLogicLayer;

namespace HealthDoc
{
    public partial class patient_appointment : Form
    {
        private int patientid;
        private string patientName;
        private string pid;

        private BLL bll = new BLL();
        Random random = new Random();
        public patient_appointment(int patientid)
        {
            InitializeComponent();
            this.patientid = patientid;
            BLL b = new BLL();
            patientName = b.Dashboard_patient(patientid);
            pid = b.Dashboard_patientname(patientid);
            lblPatient.Text = "Welcome, " + patientName;
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
            Form f = new Dashboard_patient(patientid);
            f.Show();
        }
        private void patient_appointment_Load(object sender, EventArgs e)
        {
            try
            {
                DataTable doctorDetails = bll.GetDoctorDetails();
                dgvDoctor.DataSource = doctorDetails;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void dgvDoctor_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                dgvDoctor.ClearSelection();
                dgvDoctor.Rows[e.RowIndex].Selected = true;
            }
        }

        private void dtpAppoint_ValueChanged(object sender, EventArgs e)
        {
            DateTime selectedDate = dtpAppoint.Value;
            DateTime currentDate = DateTime.Today;
            if (selectedDate < currentDate)
            {
                MessageBox.Show("Please select a date that is not in the past.");
                dtpAppoint.Value = currentDate;
            }
        }
        private void btnAppoint_Click(object sender, EventArgs e)
        {
            if (dgvDoctor.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a doctor.");
                return;
            }
            try
            {
                int appointmentId = random.Next(100000);
                int doctorId = Convert.ToInt32(dgvDoctor.SelectedRows[0].Cells[0].Value);
                DateTime appointmentDate = dtpAppoint.Value;
                string appointmentPurpose = rtbAppointmentpurpose.Text;
                string appointment_status = "Booked";
                BLL b = new BLL();
                AppointmentBooking booking = new AppointmentBooking();
                booking.appointmentId = appointmentId;
                booking.patientid = int.Parse(pid);
                booking.doctorId = doctorId;
                booking.appointmentDate = appointmentDate;
                booking.appointmentPurpose = appointmentPurpose;
                booking.appointment_status = appointment_status;

                booking.Register();
                MessageBox.Show("Appointment booked successfully.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }
    }
}