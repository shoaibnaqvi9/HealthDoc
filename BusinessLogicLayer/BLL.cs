using System;
using System.Data;
using System.Data.SqlClient;
using DataAccessLayer;

namespace BusinessLogicLayer
{
    public abstract class Registration
    {
        protected DAL d;

        public Registration()
        {
            d = new DAL();
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
        public bool Login_patient(int log)
        {
            DAL d = new DAL();
            d.OpenConnection();
            d.LoadSpParameters("_spselectpatient", log);
            SqlDataReader reader = d.GetDataReader();
            bool loginSuccessful = reader.Read();
            d.CloseConnection();
            return loginSuccessful;
        }
        public string Dashboard_patient(int log)
        {
            string patientName = string.Empty;
            DAL d = new DAL();
            d.OpenConnection();
            d.LoadSpParameters("_spdasboardpatient", log);
            SqlDataReader reader = d.GetDataReader();
            if (reader.Read())
            {
                patientName = reader["patientname"].ToString();
            }
            d.CloseConnection();
            return patientName;
        }
        public string Dashboard_patientname(int log)
        {
            string pid=null;
            DAL d = new DAL();
            d.OpenConnection();
            d.LoadSpParameters("_spdashboard_patientname", log);
            SqlDataReader reader = d.GetDataReader();
            if (reader.Read())
            {
                pid = reader["patientid"].ToString();
            }
            d.CloseConnection();
            return pid;
        }
        public string Dashboard_doctor(string log)
        {
            string doctorName = string.Empty;
            DAL d = new DAL();
            d.OpenConnection();
            d.LoadSpParameters("_spdasboarddoctor", log);
            SqlDataReader reader = d.GetDataReader();
            if (reader.Read())
            {
                doctorName = reader["doctorname"].ToString();
            }
            d.CloseConnection();
            return doctorName;
        }
        public string Dashboard_doctorname(string log)
        {
            string did = null;
            DAL d = new DAL();
            d.OpenConnection();
            d.LoadSpParameters("_spdashboard_doctorname", log);
            SqlDataReader reader = d.GetDataReader();
            if (reader.Read())
            {
                did = reader["doctorid"].ToString();
            }
            d.CloseConnection();
            return did;
        }
        public bool Login_doctor(string log)
        {
            DAL d = new DAL();
            d.OpenConnection();
            d.LoadSpParameters("_spselectdoctor", log);
            SqlDataReader reader = d.GetDataReader();
            bool loginSuccessful = reader.Read();
            d.CloseConnection();
            return loginSuccessful;
        }

        public bool Login_admin(string name, string password)
        {
            DAL d = new DAL();
            d.OpenConnection();
            d.LoadSpParameters("_spselectadmin", name, password);
            SqlDataReader reader = d.GetDataReader();
            bool loginSuccessful = reader.HasRows;
            d.CloseConnection();
            return loginSuccessful;
        }
        public DataTable GetDoctorDetails()
        {
            DAL d = new DAL();
            d.OpenConnection();
            d.LoadSpParameters("_spgetdoctor_details");
            DataTable dt = d.GetDataTable();
            d.CloseConnection();
            return dt;
        }
        public DataTable GetPatientDetails()
        {
            DAL d = new DAL();
            d.OpenConnection();
            d.LoadSpParameters("_spgetPatientAppointment");
            DataTable dt = d.GetDataTable();
            d.CloseConnection();
            return dt;
        }
        public void Patient_Delete(int pid)
        {
            DAL d = new DAL();
            d.OpenConnection();
            d.LoadSpParameters("_spdeletepatient_details", pid);
            d.ExecuteQuery();
            d.CloseConnection();
        }
    }
}