using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace poinf_of_Sell
{
    public partial class frmQty : Form
    {
        public frmQty()
        {
            InitializeComponent();
        }

        private string myValue;
            public string MyValue
        {
            get { return myValue;  }
            set { myValue = value; }
    }
        private void BtnAddQty_Click(object sender, EventArgs e)
        {
          MyValue = txtQty.Text;


        }

        private void txtQty_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13) // key press is ENTER
            {
                BtnAddQty.PerformClick();// execute this button. or click on button BtnAddQty
            }

        }
    }
}
