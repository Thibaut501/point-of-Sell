using ConnectAndCommand;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UpdateFunction
{
    public class UpdateAll2
    {
        // get the connection
        DataSetConnectApplication objCOnDs = null;
        public UpdateAll2() 
        {
            objCOnDs=new DataSetConnectApplication();

        }
        // update 1st button
        public void FirstButtonUpdate(string FirstBUpdate, string FirstB)

        {
            string sql = "Update FirstButton set FirstButtonName = '"+ FirstBUpdate + "' where FirstButtonName = '"+ FirstB +"' ";
            objCOnDs.COmCOnString(sql);
        }
    }
}
