using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data; // be imported
using System.Data.SqlClient;
using System.Security.Cryptography.X509Certificates; // import it also

namespace ConnectAndCommand
{
    public class DataSetConnectApplication
    {
        // Connection to the database
        string strConnect = @"Data Source=(LocalDb)\MSSQLLocalDB;Initial Catalog=""Point of Sell for Teaching"";Integrated Security=True";

        //Set and Set connection, command and datasset for all tables and forms
        public DataSet GetandSetForAlltheConnection(string StoreProcedure, SqlParameter[] objParameter)
        {
            SqlConnection con = new SqlConnection(strConnect);
            con.Open(); // Open connection

            //Command to fill the dataset
            SqlCommand com = new SqlCommand(StoreProcedure, con);

            // if the command goes through the execute
            if (objParameter != null)
            {
                com.Parameters.AddRange(objParameter);
            }
            DataSet Ds = new DataSet();
            SqlDataAdapter Da = new SqlDataAdapter(com);
            Da.Fill(Ds, "DataTable1");
            return Ds;
        }

        // Connection and command for all function
        public void COmCOnString(string StrString)
        {
            try
            {
                using (SqlConnection objCon = new SqlConnection(strConnect))
                {
                    objCon.Open();
                    using (SqlCommand objCom = new SqlCommand(StrString, objCon))
                    {
                        objCom.ExecuteNonQuery();
                    }
                }
            }
            catch (SqlException ex)
            {
                Console.WriteLine("SQL Error: " + ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
        }

    }


}