using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ConnectAndCommand;

namespace DeleteAll
{
    public class DeleteFromDB
    {
        // get connection from ConnectAndCommand Methosd

        DataSetConnectApplication objCOnDs = null;
        public DeleteFromDB()
        {
            objCOnDs=new DataSetConnectApplication();
        }
        // CODE FOR DELETING DATA FROM THE DB
        public void firstbuttonDelete(string firstButton)
        {
            string sqlC = "Delete from FirstButton where FirstButtonName = '" + firstButton + "'";
            objCOnDs.COmCOnString(sqlC);

        }
       
    }
}
