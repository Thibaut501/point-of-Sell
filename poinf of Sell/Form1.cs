using poinf_of_Sell;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace point_of_Sell
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddFirstButton fr = new AddFirstButton();
            fr.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FrmMakeOrder frd =new FrmMakeOrder();
            frd.ShowDialog();
        }

        private void BtnSecond_Click(object sender, EventArgs e)
        {
            AddSecondButton fr = new AddSecondButton(); 
            fr.ShowDialog();
        }

        private void BtnThird_Click(object sender, EventArgs e)
        {
            frmThirdButtoncateg fr = new frmThirdButtoncateg();
            fr.ShowDialog();
        }
    }
}
