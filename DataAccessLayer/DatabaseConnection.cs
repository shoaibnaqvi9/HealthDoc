using System.Data;
using System.Data.SqlClient;

namespace DataAccessLayer
{
    internal sealed class DatabaseConnection
    {
        private static readonly DatabaseConnection instance = new DatabaseConnection();
        private readonly SqlConnection connection;
        public void Dispose()
        {
            if (connection != null)
            {
                connection.Dispose();
            }
        }
        private DatabaseConnection()
        {
            connection = new SqlConnection(DAL.ConnectionString);
        }

        public static DatabaseConnection Instance
        {
            get { return instance; }
        }

        public SqlConnection GetConnection()
        {
            if (connection.State == System.Data.ConnectionState.Closed)
                connection.Open();
            return connection;
        }

        public void CloseConnection()
        {
            if (connection.State != System.Data.ConnectionState.Closed)
                connection.Close();
        }
    }
}
