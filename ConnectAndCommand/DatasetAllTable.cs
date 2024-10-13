using System.Data.SqlClient;

namespace ConnectAndCommand
{
    public class DatasetAllTable
    {
        private string connectionString = @"Server=(LocalDb)\MSSQLLocalDB;Database=Point of Sell for Teaching;Trusted_Connection=True;";

        // Method to get the SQL connection
        public SqlConnection GetConnection()
        {
            return new SqlConnection(connectionString);
        }

        // Method to execute SQL command passed as a string (formerly referred to as 'ComConString')
        public void ComConString(string sql)
        {
            using (SqlConnection connection = GetConnection())
            {
                using (SqlCommand command = new SqlCommand(sql, connection))
                {
                    connection.Open();
                    command.ExecuteNonQuery();
                }
            }
        }
    }
}


