using System;
using System.Data;
using DataAccessLayer;
using System.Data.SqlClient;

namespace BusinessLogicLayer
{
    public enum UserType { Admin, Patient, Doctor }
    public interface IUserFactory
    {
        Registration CreateUser(UserType userType);
    }

    public class UserFactory : IUserFactory
    {
        public Registration CreateUser(UserType userType)
        {
            switch (userType)
            {
                case UserType.Admin: return new AdminRegistration();
                case UserType.Patient: return new PatientRegistration();
                case UserType.Doctor: return new DoctorRegistration();
                default: throw new ArgumentException("Invalid user type");
            }
        }
    }
    public abstract class Registration
    {
        protected DAL d;
        public Registration()
        {
            d = DAL.Instance;
        }

        public abstract void Register();

        protected void OpenAndCloseConnection(Action action)
        {
            d.OpenConnection();
            action();
            d.CloseConnection();
        }
    }
    public class AdminRegistration : Registration
    {
        public override void Register()
        {
            OpenAndCloseConnection(() =>
            {
                d.LoadSpParameters("_spinsertadmin_detail", Adminname, Adminpassword, Adminrepass, Admincontact,Adminaddress);
                d.ExecuteQuery();
                d.UnLoadSpParameters();
            });
        }

        public string Adminname { get; set; }
        public string Adminpassword { get; set; }
        public string Adminrepass { get; set; }
        public string Admincontact { get; set; }
        public string Adminaddress { get; set; }
    }

    public class PatientRegistration : Registration
    {
        public override void Register()
        {
            OpenAndCloseConnection(() =>
            {
                d.LoadSpParameters("_spinsertpatient_detail", Patientid, Patientname, Patientdob, Patientgender, PatientCNIC, Patientweight, Patientcontact, Patientaddress);
                d.ExecuteQuery();
                d.UnLoadSpParameters();
            });
        }

        public int Patientid { get; set; }
        public string Patientname { get; set; }
        public DateTime Patientdob { get; set; }
        public string Patientgender { get; set; }
        public string PatientCNIC { get; set; }
        public int Patientweight { get; set; }
        public string Patientcontact { get; set; }
        public string Patientaddress { get; set; }
    }

    public class DoctorRegistration : Registration
    {
        public override void Register()
        {
            OpenAndCloseConnection(() =>
            {
                d.LoadSpParameters("_spinsertdoctor_detail", Doctorid, Doctorname, Doctorspecialization, Doctorcontact, Doctoraddress);
                d.ExecuteQuery();
                d.UnLoadSpParameters();
            });
        }
        public int Doctorid { get; set; }
        public string Doctorname { get; set; }
        public string Doctorspecialization { get; set; }
        public string Doctorcontact { get; set; }
        public string Doctoraddress { get; set; }
    }

    public class PatientUpdate : Registration
    {
        public override void Register()
        {
            OpenAndCloseConnection(() =>
            {
                d.LoadSpParameters("_spupdatepatient_details", Patientid, Patientcontact);
                d.ExecuteQuery();
                d.UnLoadSpParameters();
            });
        }

        public int Patientid { get; set; }
        public string Patientcontact { get; set; }
    }

    public class AppointmentBooking : Registration
    {
        public override void Register()
        {
            OpenAndCloseConnection(() =>
            {
                d.LoadSpParameters("_spinsertappointment_detail", appointmentId, patientid,doctorId, appointmentDate, appointmentPurpose, appointment_status);
                d.ExecuteQuery();
                d.UnLoadSpParameters();
            });
        }
        public int appointmentId { get; set; }
        public int patientid { get; set; }
        public int doctorId { get; set; }
        public DateTime appointmentDate { get; set; }
        public string appointmentPurpose { get; set; }
        public string appointment_status { get; set; }
    }
    public class BLL
    {
        private DAL _dal;
        public BLL()
        {
            _dal = DAL.Instance; // Using singleton
        }
        public bool Login_patient(int log)
        {
            _dal.OpenConnection();
            _dal.LoadSpParameters("_spselectpatient", log);
            SqlDataReader reader = _dal.GetDataReader();
            bool loginSuccessful = reader.Read();
            _dal.CloseConnection();
            return loginSuccessful;
        }
        public string Dashboard_patient(int log)
        {
            string patientName = string.Empty;
            _dal.OpenConnection();
            _dal.LoadSpParameters("_spdasboardpatient", log);
            SqlDataReader reader = _dal.GetDataReader();
            if (reader.Read())
            {
                patientName = reader["patientname"].ToString();
            }
            _dal.CloseConnection();
            return patientName;
        }
        public string Dashboard_patientname(int log)
        {
            string pid=null;
            _dal.OpenConnection();
            _dal.LoadSpParameters("_spdashboard_patientname", log);
            SqlDataReader reader = _dal.GetDataReader();
            if (reader.Read())
            {
                pid = reader["patientid"].ToString();
            }
            _dal.CloseConnection();
            return pid;
        }
        public string Dashboard_doctor(string log)
        {
            string doctorName = string.Empty;
            _dal.OpenConnection();
            _dal.LoadSpParameters("_spdasboarddoctor", log);
            SqlDataReader reader = _dal.GetDataReader();
            if (reader.Read())
            {
                doctorName = reader["doctorname"].ToString();
            }
            _dal.CloseConnection();
            return doctorName;
        }
        public string Dashboard_doctorname(string log)
        {
            string did = null;
            _dal.OpenConnection();
            _dal.LoadSpParameters("_spdashboard_doctorname", log);
            SqlDataReader reader = _dal.GetDataReader();
            if (reader.Read())
            {
                did = reader["doctorid"].ToString();
            }
            _dal.CloseConnection();
            return did;
        }
        public bool Login_doctor(string log)
        {
            _dal.OpenConnection();
            _dal.LoadSpParameters("_spselectdoctor", log);
            SqlDataReader reader = _dal.GetDataReader();
            bool loginSuccessful = reader.Read();
            _dal.CloseConnection();
            return loginSuccessful;
        }

        public bool Login_admin(string name, string password)
        {
            _dal.OpenConnection();
            _dal.LoadSpParameters("_spselectadmin", name, password);
            SqlDataReader reader = _dal.GetDataReader();
            bool loginSuccessful = reader.HasRows;
            _dal.CloseConnection();
            return loginSuccessful;
        }
        public DataTable GetDoctorDetails()
        {
            _dal.OpenConnection();
            _dal.LoadSpParameters("_spgetdoctor_details");
            DataTable dt = _dal.GetDataTable();
            _dal.CloseConnection();
            return dt;
        }
        public DataTable GetPatientDetails()
        {
            _dal.OpenConnection();
            _dal.LoadSpParameters("_spgetPatientAppointment");
            DataTable dt = _dal.GetDataTable();
            _dal.CloseConnection();
            return dt;
        }
        public void Patient_Update(int patientId, string contact)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(contact) || contact.Length != 12)
                {
                    throw new ArgumentException("Contact number must be exactly 12 digits.");
                }

                _dal.UpdatePatient(patientId, contact);
            }
            catch (Exception ex)
            {
                throw new Exception("Error updating patient: " + ex.Message);
            }
        }
        public void Patient_Delete(int pid)
        {
            _dal.OpenConnection();
            _dal.LoadSpParameters("_spdeletepatient_details", pid);
            _dal.ExecuteQuery();
            _dal.CloseConnection();
        }
        public bool PatientExists(int patientId)
        {
            return _dal.ValidatePatient(patientId);
        }
        public DataTable GetAppointmentsForDoctor(int doctorId)
        {
            _dal.OpenConnection();
            _dal.LoadSpParameters("_spgetPatientAppointmentForDoctor", doctorId);
            DataTable dt = _dal.GetDataTable();
            _dal.CloseConnection();
            return dt;
        }
        public DataTable GetAllAppointments()
        {
            _dal.OpenConnection();
            _dal.LoadSpParameters("_spgetAllAppointments");
            DataTable dt = _dal.GetDataTable();
            _dal.CloseConnection();
            return dt;
        }

        public void UpdateAppointmentStatus(int appointmentId, string newStatus)
        {
            _dal.OpenConnection();
            _dal.LoadSpParameters("_spupdateAppointmentStatus", appointmentId, newStatus);
            _dal.ExecuteQuery();
            _dal.CloseConnection();
        }
    }
}