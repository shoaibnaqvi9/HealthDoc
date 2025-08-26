using System.Data;
using System.Data.SqlClient;

namespace DataAccessLayer
{
    public class DAL
    {
        private static DAL _instance;
        private static readonly object _lock = new object();

        private static System.Collections.Hashtable SqlparamCache = System.Collections.Hashtable.Synchronized(new System.Collections.Hashtable());
        private SqlConnection Connection = new SqlConnection();
        public static string ConnectionString = System.Configuration.ConfigurationSettings.AppSettings["dbCon"].ToString();
        private SqlCommand DbCommand = new SqlCommand();
        private SqlDataAdapter DtAdapter = new SqlDataAdapter();
        private DataSet SqlDataSet = new DataSet();
        private DataTable SqlTable = new System.Data.DataTable();

        private DAL()
        {

        }
        public static DAL Instance
        {
            get
            {
                lock (_lock)
                {
                    if (_instance == null)
                    {
                        _instance = new DAL();
                    }
                    return _instance;
                }
            }
        }

        public void UnLoadSpParameters()
        {
            DbCommand.Parameters.Clear();
        }
        public void LoadSpParameters(string SpName, params object[] ParaValues)
        {
            SqlParameter[] TheParameters = (SqlParameter[])SqlparamCache[SpName];
            DbCommand.Parameters.Clear();
            if (TheParameters == null)
            {
                DbCommand.CommandType = CommandType.StoredProcedure;
                DbCommand.CommandText = SpName;
                SqlCommandBuilder.DeriveParameters(DbCommand);
                TheParameters = new SqlParameter[DbCommand.Parameters.Count];

                DbCommand.Parameters.CopyTo(TheParameters, 0);
                SqlparamCache[SpName] = TheParameters;

            }
            else
            {
                short i;
                SqlParameter SqPr;
                DbCommand.CommandType = CommandType.StoredProcedure;
                DbCommand.CommandText = SpName;
                for (i = 0; i < TheParameters.Length; i++)
                {
                    SqPr = (SqlParameter)((System.ICloneable)(TheParameters[i])).Clone();
                    DbCommand.Parameters.Add(SqPr);
                }

            }
            MoveSqlParameters(ParaValues);

        }
        private void MoveSqlParameters(object[] Paras)
        {
            short ic;
            SqlParameter sqlPara;
            if (Paras.Length >= 0)
            {
                for (ic = 0; ic < Paras.Length; ic++)
                {
                    sqlPara = DbCommand.Parameters[ic + 1];
                    string s = sqlPara.ParameterName;
                    sqlPara.Value = Paras[ic];
                }
            }
        }

        public SqlParameter Parameters(int P)
        {
            return DbCommand.Parameters[P];
        }
        public bool OpenConnection()
        {
            try
            {
                if (Connection.State == ConnectionState.Open) return true;

                Connection = new SqlConnection();
                Connection.ConnectionString = ConnectionString;
                Connection.Open();

                if (Connection.State == ConnectionState.Open)
                {
                    if (DbCommand == null)
                        DbCommand = new SqlCommand();

                    DbCommand.Connection = Connection;
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (System.Exception ee)
            {
                throw new System.Exception("Database:OpenConnection:" + ee.Message);
            }
        }

        public void CloseConnection()
        {
            if (Connection.State != ConnectionState.Closed)
            {
                Connection.Close();

                DtAdapter?.Dispose();
                DtAdapter = new SqlDataAdapter();

                SqlDataSet?.Dispose();
                SqlDataSet = new DataSet();

                SqlTable?.Dispose();
                SqlTable = new DataTable();
            }
        }

        public SqlDataReader GetDataReader()
        {
            return DbCommand.ExecuteReader();

        }

        public int ExecuteQuery()
        {
            return DbCommand.ExecuteNonQuery();
        }

        public object ExecuteValue()
        {
            return DbCommand.ExecuteScalar();
        }

        public object ExecuteValue(string SQLStatement)
        {
            DbCommand.CommandType = CommandType.Text;
            DbCommand.CommandText = SQLStatement;
            return DbCommand.ExecuteScalar();
        }
        public string ReturnValue(string _PName)
        {
            DbCommand.ExecuteNonQuery();
            return (string)DbCommand.Parameters[_PName].Value.ToString();
        }
        public DataTable GetDataTable()
        {
            DtAdapter.SelectCommand = DbCommand;
            DtAdapter.Fill(SqlTable);
            return SqlTable;
        }
        public SqlConnection ConnectionObject
        {
            get
            {
                return this.Connection;
            }
        }
        public void UpdatePatient(int patientId, string contact)
        {
            using (SqlConnection conn = new SqlConnection(ConnectionString))
            {
                conn.Open();
                string query = "UPDATE Patients SET patientcontact = @contact WHERE patientid = @patientId";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@contact", contact);
                    cmd.Parameters.AddWithValue("@patientId", patientId);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void DeletePatient(int patientId)
        {
            using (SqlConnection conn = new SqlConnection(ConnectionString))
            {
                conn.Open();
                string query = "DELETE FROM Patients WHERE patientid = @patientId";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@patientId", patientId);
                    cmd.ExecuteNonQuery();
                }
            }
        }
        public bool ValidatePatient(int patientId)
        {
            using (SqlConnection conn = new SqlConnection(ConnectionString))
            {
                conn.Open();
                string query = "SELECT COUNT(1) FROM patient_detail WHERE patientid = @patientId";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@patientId", patientId);
                    int count = (int)cmd.ExecuteScalar();
                    return count > 0;
                }
            }
        }
        public bool ValidateUser(string username, string password)
        {
            try
            {
                if (OpenConnection())
                {
                    DbCommand.CommandType = CommandType.Text;
                    DbCommand.CommandText = "SELECT COUNT(*) FROM admin_detail WHERE adminname=@username AND adminpassword=@password";

                    DbCommand.Parameters.Clear();
                    DbCommand.Parameters.AddWithValue("@username", username);
                    DbCommand.Parameters.AddWithValue("@password", password);

                    int result = (int)DbCommand.ExecuteScalar();

                    return result > 0;
                }
                return false;
            }
            catch (System.Exception ex)
            {
                throw new System.Exception("Database:ValidateUser:" + ex.Message);
            }
            finally
            {
                CloseConnection();
            }
        }

    }
}