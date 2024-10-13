using System.Data;
using ConnectAndCommand; // Ensure this namespace handles the database connection

namespace SelectAll
{
    public class SelectAllTable
    {
   
        
            // get connection from ConnectAndCommand Method
            DataSetConnectApplication objCOnDs = null;

            // Select data from UserTable (all data)
            public SelectAllTable()

            {

                objCOnDs = new DataSetConnectApplication();

            }
            // select data from 1st category button
            public DataSet SelectFirstButton()
            {
                return objCOnDs.GetandSetForAlltheConnection("select  * from FirstButton", null);
            }


            // select data from 2 category 
            public DataSet SelectSecondButton()
            {
                return objCOnDs.GetandSetForAlltheConnection("select * from SecondButton", null);
            }
        }

    }

