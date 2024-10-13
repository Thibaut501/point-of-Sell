using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SaveData;
using SelectAll;
using UpdateAllTable;
using UpdateFunction;


namespace poinf_of_Sell
{
    public partial class frmThirdButtoncateg : Form
    {
        public frmThirdButtoncateg()
        {
            InitializeComponent();
        }

        private void BtnAddThirdCateg_Click(object sender, EventArgs e)
        {
            SaveDetails Sv = new SaveDetails();
            Sv.AddThirdCategButton(CboSecondCateg.Text, txtThirdCateg.Text, Convert.ToDecimal(txtPrice.Text));

            MessageBox.Show("Save successfully");
        }

        private void frmThirdButtoncateg_Load(object sender, EventArgs e)
        {
            SelectAllTable sel = new SelectAllTable();
            DataSet Ds = sel.SelectSecondButton();

            // fill the combobox
            CboSecondCateg.DataSource = Ds.Tables[0];
            CboSecondCateg.DisplayMember = "SecondButton";

        }
    }
}
