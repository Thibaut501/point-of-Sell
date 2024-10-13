using System;
using System.Data;
using System.Windows.Forms;
using SelectAll;  // Import the namespace for SelectAllTable

namespace poinf_of_Sell
{
    public partial class AddSecondButton : Form
    {
        public AddSecondButton()
        {
            InitializeComponent();
        }

        private void AddSecondButton_Load(object sender, EventArgs e)
        {
            // Fetch and bind first button data to the combobox
            SelectAllTable sel = new SelectAllTable();
            DataSet Ds = sel.SelectSecondButton();

            if (Ds != null && Ds.Tables.Count > 0 && Ds.Tables[0].Rows.Count > 0)
            {
                // Bind the data to the combobox
                CboFirstB.DataSource = Ds.Tables[0];
                CboFirstB.DisplayMember = "SecondButton";  // Ensure this matches the actual column name
            }
            else
            {
                MessageBox.Show("No data found for the second buttons.");
            }
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            // Saving logic for second button here
        }
    }
}
