using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ConnectAndCommand;
using System.Data;
using System.Data.SqlClient;

namespace SelectAll
{
    public class SelectInAll
    {
        // get connection from ConnectAndCommand Method
        DataSetConnectApplication objCOnDs = new DataSetConnectApplication(); // Initialize objCOnDs

        // Select data from UserTable (all data)
        public DataSet SelectfromUserTable()
        {
            // Ensure objCOnDs is not null before calling GetandSetForAlltheConnection
            if (objCOnDs != null)
            {
                return objCOnDs.GetandSetForAlltheConnection("select * from UserTable", null);
            }
            else
            {
                // Handle the case where objCOnDs is null
                // You might want to return null or throw an exception, depending on your requirements.
                return null;
            }
        }
    }
}
