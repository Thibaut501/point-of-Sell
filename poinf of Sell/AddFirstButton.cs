using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SaveData; // import this first class and create  a reference of is first

namespace point_of_Sell
{
    public partial class AddFirstButton : Form
    {
        public AddFirstButton()
        {
            InitializeComponent();
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            // code  to add data first button in the database
            SaveDetails Sv = new SaveDetails();
            Sv.AddFirstButton(txtFirstButton.Text);

            MessageBox.Show("FirstButton  added sucessfully");
        }
    }
}
