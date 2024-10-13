using System;
using System.Collections.Generic;
using System.Data; // import it
using System.Linq;
using System.Text;
using ConnectAndCommand;


namespace SelectAllWhere
{
    public class SelectWhere
    {
        DataSetConnectApplication objConDs = null;
        public SelectWhere()
        {
            objConDs = new DataSetConnectApplication();
        }

        public DataSet SelectSecondButton(string FirstB)
        {
            return objConDs.GetandSetForAlltheConnection("select SecondButton from SecondButton where FirstButton = '"+ FirstB +"'", null);
            
        }
        // select data from thrid category button
        public DataSet SelectThirdButton(string SecondB)
        {
            return objConDs.GetandSetForAlltheConnection("select ThirdButton from ThirdButton where SecondButton = '"+ SecondB +"'", null);
        }
        // select item name (3rd Button name) and Prices unit price
        public DataSet Select3rdandPrice(string thirdB)
        {
            return objConDs.GetandSetForAlltheConnection("select ThirdButton, Price from ThirdButton where ThirdButton = '" + thirdB +"'", null);
        }

    }
}
