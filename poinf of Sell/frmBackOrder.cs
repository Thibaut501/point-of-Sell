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
    public partial class frmBackOrder : Form
    {
        public frmBackOrder()
        {
            InitializeComponent();
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            frmUSER fr = new frmUSER();
            fr.ShowDialog();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void firstButtonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddFirstButton fr = new AddFirstButton();
            fr.ShowDialog();

        }

        private void secondButtonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddSecondButton fr = new AddSecondButton(); 
            fr.ShowDialog();
        }

        private void thirdButtonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmThirdButtoncateg fr = new frmThirdButtoncateg();
            fr.ShowDialog();


        }
    }
}
