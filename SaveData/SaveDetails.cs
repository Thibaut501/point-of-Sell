using ConnectAndCommand;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace SaveData
{
    public class SaveDetails
    {
        // Code for connecting to the database
        DataSetConnectApplication objConDs = null;

        public SaveDetails()
        {
            objConDs = new DataSetConnectApplication();
        }

        // Add first Button in DB
        public void AddFirstButton(string FirstB)
        {
            string AddD = "insert into FirstButton (FirstButtonName) values ('" + FirstB + "')";
            objConDs.COmCOnString(AddD);
        }

        // Add Second Button in DB
        public void AddSecondButton(string First, string Second)
        {
            string AddS = "insert into SecondButton (FirstButton, SecondButton) values ('" + First + "','" + Second + "')";
            objConDs.COmCOnString(AddS);
        }

        // Add 3rd Category button for making orders
        public void AddThirdCategButton(string SecondCateg, string ThirdCateg, decimal Price)
        {
            string Add = "insert into ThirdButton(ThirdButton, SecondButton, Price) values ('" + ThirdCateg + "', '" + SecondCateg + "' ,'" + Price + "')";
            objConDs.COmCOnString(Add);
        }


        
      
    }
}
