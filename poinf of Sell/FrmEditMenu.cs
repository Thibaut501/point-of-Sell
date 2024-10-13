using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SelectAll;
using DeleteAll;// import this function for deleting data
using UpdateFunction; // import this 
using SaveData;

namespace poinf_of_Sell
{
    public partial class FrmEditMenu : Form
    {
        public FrmEditMenu()
        {
            InitializeComponent();
        }

        // fill with 1st button in the combobox

        void fillFirstButtonCombobox()
        {
            // on form load (open) fill the combox with the 1st button name
            SelectAllTable sel = new SelectAllTable();


            // fill the combobox
            DataSet Ds = sel.SelectSecondButton();
            cbo1stbutton.DataSource = Ds.Tables[0];
            cbo1stbutton.DisplayMember = "FirstButtonName";
        }
        private void FrmEditMenu_Load(object sender, EventArgs e)
        {
            fillFirstButtonCombobox(); // open form load please fill the combobox with 1st button



        }

        private void btnConfirm1st_Click(object sender, EventArgs e)
        {
            if (optionDelete.Checked == true)

            {
                // codes to delete the button selected
                string message = "Are you sure you want to delete the button  :" + txtFirstButton.Text;
                string caption = "click on Cancel to Cancel this operation or click on Yes to delete that button";
                MessageBoxButtons butt = MessageBoxButtons.OKCancel;
                DialogResult result;
                result = MessageBox.Show(this, message, caption, butt, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
                if (result == DialogResult.OK)
                {
                    DeleteFromDB del = new DeleteFromDB();
                    del.firstbuttonDelete(txtFirstButton.Text);
                    MessageBox.Show("The Button :" + txtFirstButton.Text + " has been deleted from the database");



                    fillFirstButtonCombobox(); // open form load please fill the combobox with 1st button
                }
                else if (result == DialogResult.Cancel)
                {
                    MessageBox.Show("Delete process was cancelled");
                }
                // codes to delete the button selected
            }
            else if (optionEdit.Checked == true)
            {
                
                    //code to edit the selected  buttons
                    UpdateAll2 up = new UpdateAll2();
                    up.FirstButtonUpdate(cbo1stbutton.Text, txtFirstButton.Text);
                    MessageBox.Show("update Successfully");
                    fillFirstButtonCombobox(); // open form load please fill the combobox with 1st button

                }
            }




            private void cho1stbutton_SelectedIndexChanged(object sender, EventArgs e)
            {
                txtFirstButton.Text = cbo1stbutton.Text;
            }
        }
    }

