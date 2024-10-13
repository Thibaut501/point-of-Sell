using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using SaveAll;
using SelectAll; // u need to import this class (function)

namespace Login_App
{
    public partial class frmSignup : Form
    {
        public frmSignup()
        {
            InitializeComponent();
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            SaveDetails Sv = new SaveDetails();
            Sv.AddUserDetails(txtName.Text, txtPaaword.Text);

            MessageBox.Show("Save data succeeded");
            BtnDisplay.PerformClick(); // button Show must get a click
        }

        private void BtnDisplay_Click(object sender, EventArgs e)
        {
            SelectInAll obj = new SelectInAll();
           DataSet Ds =  obj.SelectfromUserTable();


            DvUserDetails.DataSource = Ds.Tables[0].DefaultView;

        }
    }
}
