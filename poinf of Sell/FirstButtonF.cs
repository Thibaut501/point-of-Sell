
using System.Windows.Forms;
using System;
using UpdateAllTable;
using SelectAll;
using UpdateFunction;
using SaveData;
using System.Data;



namespace poinf_of_Sell
{
    public partial class FirstButtonF : Form
    {
        public FirstButtonF()
        {
            InitializeComponent();
        }

        private void BtnExecute_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtExecute.Text) || string.IsNullOrWhiteSpace(txtExecute.Text))
            {
                MessageBox.Show("Edit or write the Button name to Add");
            }
            else
            {
                if (rAdd.Checked == true)
                {
                    // Instantiate SaveDetails1, not SaveDetails
                    SaveDetails sv = new SaveDetails();
                    sv.AddFirstButton(txtExecute.Text);  // Calling Save1stButtonCateg from SaveDetails1
                    MessageBox.Show("Added Successfully");

                }
                if (rEdit.Checked == true)
                {
                    // edit data
                    UpdateAll up = new UpdateAll();
                    up.Update1stButton(Save1stButtonCateg.Text, txtExecute.Text);
                    MessageBox.Show("");

                }
                if (rDelete.Checked == true)
                {


                }

            }
        }

        private void FirstButtonF_Load(object sender, EventArgs e)
        {
            // fill the combobox for 1st button


            SelectAllTable sel = new SelectAllTable();
            DataSet Ds = sel.SelectSecondButton();

            Save1stButtonCateg.DataSource = Ds.Tables[0];
            Save1stButtonCateg.DisplayMember = "FirstButton";

        }
    }
}

