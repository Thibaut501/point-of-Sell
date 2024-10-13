using point_of_Sell;
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
    public partial class frmUSER : Form
    {
        public frmUSER()
        {
            InitializeComponent();
        }

        private void BtnInvoicing_Click(object sender, EventArgs e)
        {
          FrmMakeOrder fr = new FrmMakeOrder();
            fr.ShowDialog();
        }

        private void backOfficeSystemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmBackOrder fr = new frmBackOrder();
            fr.ShowDialog();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            frmThirdButtoncateg  fr = new frmThirdButtoncateg();    
            fr.ShowDialog();
        }
    }
}
