using System;

using System.Collections.Generic;

using System.Data;

using System.Drawing;

using System.IO;

using System.Runtime.InteropServices;

using System.Windows.Forms;

using poinf_of_Sell;

using SelectAll;


using SelectAllWhere; // Import this

using PrinterUtility;

using System.Text;

using System.Drawing.Printing;
using SaveData;



namespace point_of_Sell

{

    public partial class FrmMakeOrder : Form





    {

        // Define fields to store the last total price and whether the last deletion was through "Delete All" button



        public FrmMakeOrder()

        {

            InitializeComponent();



        }



        int Hozintal;

        int Vertical;



        int Horizontal2;

        int Verticale2;



        private void FrmMakeOrder_Load(object sender, EventArgs e)

        {

            // disable these buttons on form load

            BtnDelete1Item.Enabled = false;
            QtnQty.Enabled = false;
            BtnDeleteAll.Enabled = false;
            txtChange.Enabled = false; // Disable the txtChange text box
            txtChange.Text = "0.00"; // Set the initial value of txtChange to "0.00"
            txtAmountPaid.Enabled = false;
            txtAmountPaid.Text = "0.00";




            // List make order properties

            ListOrderProperties();

            SelectAllTable sel = new SelectAllTable();
            
            DataSet Ds = sel.SelectFirstButton();

            DataTable Dt = Ds.Tables[0];
            DataRow Dr = Dt.Rows[0];
            DataColumn Dc = Dt.Columns[0];

            for (int i = 0; i < Dt.Rows.Count; i++)
            {
                for (int j = 0; j < Dt.Columns.Count; j++)
                {
                    Button Btn = new Button(); // create a button
                    Btn.Name = Dr[0].ToString(); // get the name of the automatic button
                    Btn.Text = Dt.Rows[i][j].ToString(); // get the text name on the button
                    Btn.Location = new Point(Hozintal, Vertical); //  location of the button
                    Btn.Width = 170;
                    Btn.Height = 90;
                    int mySize = 18;
                    Btn.Font = new System.Drawing.Font(Btn.Font.FontFamily, mySize);
                    Btn.ForeColor = Color.Blue;
                    Btn.BackColor = Color.Yellow;

                    int n = 5; // 5 buttons

                    if (i == n)  // if my buttons are number of 5 than put them on one
                    {
                        Hozintal = 5;
                        Vertical = Vertical + Btn.Height; //  button under each other
                    }
                    else
                    {
                        Hozintal = Hozintal + Btn.Width;  //  button next after each other
                        PnFirstButton.Controls.Add(Btn);
                        Btn.Click += new EventHandler(Btn_Click);
                    }
                }
            }
        }


        private void BtnDelete1Item_Click(object sender, EventArgs e)
        {
            // Get the price of the last item before deletion
            double lastItemPrice = 0;

            // Remove selected item(s) from the list
            foreach (ListViewItem item in LsOrders.SelectedItems)
            {
                lastItemPrice = Convert.ToDouble(item.SubItems[4].Text);
                LsOrders.Items.Remove(item);
            }

            // Calculate the total price
            CalculateTotalPrice();

            // Display the price of the last item in the total amount textbox with currency symbol
            txtTotalAmount.Text = LsOrders.Items.Count == 0 ? "0.00" : txtTotalAmount.Text;

            // Recalculate the change
            UpdateChange();

            // Check if there are any items left
            if (LsOrders.Items.Count == 0)
            {
                // If there are no items left, set txtAmountPaid.Text to "0.00"
                txtAmountPaid.Text = "0.00";

                // Set focus to another control to prevent automatic selection of "0.00" in txtAmountPaid
                BtnPrint.Focus(); // Replace BtnPrint with the desired control
            }

            // Enable or disable the "Delete Item" button based on selection
            EnableorDisableDelete1ItemButton();
        }

        // Method to update the change

        private void UpdateChange()
        {
            double totalAmount = 0;

            // Validate if the text in txtTotalAmount can be converted to a valid double
            if (!double.TryParse(txtTotalAmount.Text, out totalAmount))
            {
                // Display an error message or handle the invalid input appropriately
                txtChange.Text = "Invalid Total Amount";
                return;
            }

            // Calculate the change
            double amountPaid = 0;
            if (double.TryParse(txtAmountPaid.Text, out amountPaid))
            {
                double change = totalAmount - amountPaid;
                txtChange.Text = change.ToString("0.00");
            }
            else
            {
                txtChange.Text = "Invalid Amount Paid";
            }
        }




        // Clear the panel before creating buttons

        void clearSecondPane()

        {

            PnButton2And3.Controls.Clear();

        }



        void Btn_Click(object sender, EventArgs e)

        {







            // clear first before creating buttons

            clearSecondPane(); // call the clear 2nd panel 



            //get the the argument for my parameter . It must be the same name of the button

            Button b = (Button)sender;

            string GetButtonName = b.Text;



            SelectWhere sel = new SelectWhere();

            DataSet Ds = sel.SelectSecondButton(GetButtonName);



            // no data in the database error preventing

            if (Ds.Tables[0].Rows.Count == 0)

            {

                string messageX = "Sorry no item for the button : " + b.Text + "   Would you like to add buttons please ?";

                string titleX = "Point of Sell System";

                MessageBoxButtons buttons = MessageBoxButtons.YesNo;

                DialogResult result;

                result = MessageBox.Show(this, messageX, titleX, buttons, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1,

                    MessageBoxOptions.RightAlign);



                if (result == DialogResult.Yes)

                {

                    AddSecondButton fr = new AddSecondButton();

                    fr.ShowDialog();

                }

                else

                {



                }

            }

            else

            {

                DataTable Dt = Ds.Tables[0];

                DataRow Dr = Dt.Rows[0];

                DataColumn Dc = Dt.Columns[0];



                for (int i = 0; i < Dt.Rows.Count; i++)



                    for (int j = 0; j < Dt.Columns.Count; j++)

                    {

                        Button btn2 = new Button(); // create a new button



                        btn2.Name = Dr[0].ToString();

                        btn2.Text = Dt.Rows[i][j].ToString();

                        btn2.Location = new Point(Horizontal2, Verticale2);

                        btn2.Width = 160;

                        btn2.Height = 100;

                        btn2.BackColor = Color.Green;

                        int mySize = 10;

                        btn2.Font = new System.Drawing.Font(btn2.Font.FontFamily, mySize);



                        int n = 5;

                        if (i == n)

                        {

                            Horizontal2 = 5;

                            Verticale2 = Verticale2 + btn2.Height;

                        }

                        else

                        {

                            Horizontal2 = Horizontal2 + btn2.Width;

                            PnButton2And3.Controls.Add(btn2);

                            btn2.Click += new EventHandler(btn2_Click);

                        }

                    }

            }

        }



        void btn2_Click(object sender, EventArgs e)

        {

            clearSecondPane(); // clear the 2 category button before u create 3rd category buttons



            // fill with the  third category button to make orders

            Button b = (Button)sender;

            string GetButtonName = b.Text;



            SelectWhere sel = new SelectWhere();

            DataSet Ds = sel.SelectThirdButton(GetButtonName);

            // no data in the database error preventing

            if (Ds.Tables[0].Rows.Count == 0)

            {

                string messageX = "Sorry no item for the button : " + b.Text + "   Would you like to add buttons please ?";

                string titleX = "Point of Sell System";

                MessageBoxButtons buttons = MessageBoxButtons.YesNo;

                DialogResult result;

                result = MessageBox.Show(this, messageX, titleX, buttons, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1,

                    MessageBoxOptions.RightAlign);



                if (result == DialogResult.Yes)

                {

                    frmThirdButtoncateg fr = new frmThirdButtoncateg();

                    fr.ShowDialog();

                }

                else

                {

                }



            }

            else

            {// else means there is data in the database ==> create them as buttons

                DataTable Dt = Ds.Tables[0];

                DataRow Dr = Dt.Rows[0];

                DataColumn Dc = Dt.Columns[0];



                for (int i = 0; i < Dt.Rows.Count; i++)



                    for (int j = 0; j < Dt.Columns.Count; j++)

                    {

                        Button Btn3 = new Button();

                        Btn3.Name = Dr[0].ToString();

                        Btn3.Text = Dt.Rows[i][j].ToString();

                        Btn3.Location = new Point(Horizontal2, Verticale2);

                        Btn3.Width = 160;

                        Btn3.Height = 100;

                        Btn3.BackColor = Color.Aquamarine;

                        Btn3.ForeColor = Color.Blue;

                        int newsize = 20;

                        Btn3.Font = new Font(Btn3.Font.FontFamily, newsize);



                        int n = 5;

                        if (i == n)

                        {

                            Horizontal2 = 5;

                            Verticale2 = Verticale2 + Btn3.Width;

                        }

                        else

                        {

                            Horizontal2 = 5;

                            Verticale2 = Verticale2 + Btn3.Height;

                            PnButton2And3.Controls.Add(Btn3);

                            Btn3.Click += new EventHandler(Btn3_Click);

                        }

                    }

            }

        }
        void Btn3_Click(object sender, EventArgs e)
        {
            double UP = 0;

            Button b = (Button)sender;
            string NameButton = b.Text;

            SelectWhere sel = new SelectWhere();
            DataSet Ds = sel.Select3rdandPrice(NameButton);
            DataView Dv = new DataView(Ds.Tables[0]);

            ListViewItem lv = new ListViewItem();

            // Get the price from the database
            UP = Convert.ToDouble(Dv[0]["Price"]);

            lv.SubItems.Add("1");
            // Add the item name directly to the ListViewItem
            lv.SubItems.Add(NameButton); // Designation
            lv.SubItems.Add(UP.ToString("n")); // Unit Price
            lv.SubItems.Add(UP.ToString("n"));

            LsOrders.Items.Add(lv);

            // Set the price in the txtPrice box
            txtPrice.Text = UP.ToString("n0");

            CalculateTotalPrice(); // get calculation
            UnableButtonDeleteAll(); // check if three is item in the list orders then enable button delete all
            UpdateChange(); // Update the change display
            txtAmountPaid.Enabled = true;
        }



        // unable or disable the button Delete all

        void UnableButtonDeleteAll()

        {

            for (int i = 0; i < LsOrders.Items.Count; i++)

            {

                if (i == 0)

                {

                    BtnDeleteAll.Enabled = false;



                }

                else

                {

                    BtnDeleteAll.Enabled = true;

                }

            }

        }









        // calculation of total price

        void CalculateTotalPrice()

        {

            Double colTotal = 0;



            foreach (ListViewItem ls in LsOrders.Items)

            {

                colTotal += Convert.ToDouble(ls.SubItems[4].Text);

            }



            // Display the total price with currency symbol in the textbox

            txtTotalAmount.Text = colTotal.ToString("n");

        }





        // Create the properties of listview which display order for customer

        void ListOrderProperties()

        {

            LsOrders.Clear();

            LsOrders.GridLines = true;

            LsOrders.View = View.Details;



            LsOrders.Columns.Add("", 0);

            LsOrders.Columns.Add("Qty", 50);

            LsOrders.Columns.Add("Designation", 210);

            LsOrders.Columns.Add("Unit Price", 110);

            LsOrders.Columns.Add("Total Price", 130);



            LsOrders.FullRowSelect = true;

        }



        private void LsOrders_Validating(object sender, EventArgs e)

        {

            UnableButtonDeleteAll();

        }



        private void LsOrders_VisibleChanged(object sender, EventArgs e)

        {

            UnableButtonDeleteAll();

        }


        private void BtnDeleteAll_Click(object sender, EventArgs e)
        {
            // Clear all items in the list orders
            LsOrders.Items.Clear();

            // Set txtTotalAmount, txtAmountPaid, and txtChange to zero
            txtTotalAmount.Text = "0.00";
            txtAmountPaid.Text = "0.00";
            txtChange.Text = "0.00";

            // Disable the "Delete All" button
            BtnDeleteAll.Enabled = false;

            // Call the method to enable or disable the "Delete Item" button
            EnableorDisableDelete1ItemButton();

            // Set focus to another control to prevent automatic selection of "0.00" in txtAmountPaid
            BtnPrint.Focus(); // Replace BtnPrint with the desired control

            // Update the change only if the amount paid is a valid number
            UpdateChange();
        }





        private void QtnQty_FontChanged(object sender, EventArgs e)

        {

            // Handle font change event if needed

        }



        private void LsOrders_Click(object sender, EventArgs e)

        {

            EnableorDisableDelete1ItemButton();

            QtnQty.Enabled = true; // enable the button Qty

        }




        void EnableorDisableDelete1ItemButton()
        {
            // Check if any item is selected
            if (LsOrders.SelectedItems.Count == 0)
            {
                // Disable the "Delete Item" button if no item is selected
                BtnDelete1Item.Enabled = false;
            }
            else
            {
                // Enable the "Delete Item" button if any item is selected
                BtnDelete1Item.Enabled = true;
            }

            // Check if there are any items left
            if (LsOrders.Items.Count == 0)
            {
                // Disable the "Delete All" button if there are no items left
                BtnDeleteAll.Enabled = false;

                // Disable the Quantity button if there are no items left
                QtnQty.Enabled = false;
            }
            else
            {
                // Enable the "Delete All" button if there are items left
                BtnDeleteAll.Enabled = true;

                // Enable the Quantity button if there are items left
                QtnQty.Enabled = true;
            }
        }




        private void QtnQty_Click(object sender, EventArgs e)
        {
            if (LsOrders.SelectedItems.Count == 0)
            {
                QtnQty.Enabled = false;
            }
            else
            {
                QtnQty.Enabled = true;
                ListViewItem item = LsOrders.SelectedItems[0];
                frmQty frm = new frmQty();
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    item.SubItems[1].Text = frm.MyValue;

                    Double Up = 0;
                    Double Tp = 0;
                    Double Qt = 0;

                    Qt = Convert.ToDouble(item.SubItems[1].Text);
                    Up = Convert.ToDouble(item.SubItems[3].Text);

                    Tp = Qt * Up;

                    item.SubItems[4].Text = Tp.ToString("n");

                    CalculateTotalPrice(); // Refresh total price

                    // Recalculate change
                    UpdateChange();
                }
            }
        }
        private void LsOrders_SelectedIndexChanged(object sender, EventArgs e)

        {



        }













        private void txtTotalAmount_TextChanged(object sender, EventArgs e)

        {



        }







        private void txtAmountPaid_TextChanged(object sender, EventArgs e)
        {
            double changeC = 0;

            // Check if the entered amount is a valid number
            if (!double.TryParse(txtAmountPaid.Text, out double AmountPaid))
            {
                // If not a valid number, set txtChange.Text to "0.00" and return
                txtChange.Text = "0.00";
                return;
            }

            // Validate if the text in txtTotalAmount can be converted to a valid double
            if (!double.TryParse(txtTotalAmount.Text, out double TotalAmount))
            {
                // If txtTotalAmount is not a valid number, set txtChange.Text to "0.00" and return
                txtChange.Text = "0.00";
                return;
            }

            // Calculate the change
            changeC = TotalAmount - AmountPaid;

            // Set txtChange.Text to the calculated change formatted with two decimal places
            txtChange.Text = changeC.ToString("0.00");
        }



        public byte[] CutPage()

        {

            List<byte> oby = new List<byte>();

            oby.Add(Convert.ToByte(Convert.ToChar(0x10)));

            oby.Add(Convert.ToByte('V'));

            oby.Add((byte)66);

            oby.Add((byte)3);

            return oby.ToArray();

        }



        private void txtAmountPaid_KeyPress(object sender, KeyPressEventArgs e)

        {

            // if press the KEY ENTER call the button Print receipt

            if (e.KeyChar == 13)

            {

                BtnPrint.PerformClick(); // to force the key BtnPrint to execute 

            }

        }


        private void BtnPrint_Click(object sender, EventArgs e)
        {
            // Create a new PrintDocument object
            PrintDocument pd = new PrintDocument();

            // Subscribe to the PrintPage event
            pd.PrintPage += new PrintPageEventHandler(PrintPage);

            try
            {
                // Start printing
                pd.Print();
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while printing: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void PrintPage(object sender, PrintPageEventArgs e)
{
    // Define the font
    Font font = new Font("Arial", 12);
    Font headingFont = new Font("Arial", 14, FontStyle.Bold);

    // Define the brush
    SolidBrush brush = new SolidBrush(Color.Black);

    // Starting point for the receipt
    float startX = 100;
    float startY = 100;
    float offsetY = 30;

    // Draw the receipt heading
    e.Graphics.DrawString("**** MY RECEIPT ****", headingFont, brush, startX, startY);
    startY += offsetY;
    e.Graphics.DrawString(DateTime.Now.ToShortDateString(), font, brush, startX, startY);
    startY += offsetY;
    e.Graphics.DrawString("****************", font, brush, startX, startY);
    startY += offsetY;

    // Draw table headings
    e.Graphics.DrawString("Qty", headingFont, brush, startX, startY);
    e.Graphics.DrawString("Item", headingFont, brush, startX + 60, startY);
    e.Graphics.DrawString("Unit Price", headingFont, brush, startX + 210, startY);
    e.Graphics.DrawString("Total Price", headingFont, brush, startX + 350, startY);
    startY += offsetY;

    // Draw a line under the headings
    e.Graphics.DrawString(new string('-', 60), font, brush, startX, startY);
    startY += offsetY;

    // Print each item in the ListView
    foreach (ListViewItem item in LsOrders.Items)
    {
        string qty = item.SubItems[1].Text;
        string designation = item.SubItems[2].Text;
        string unitPrice = item.SubItems[3].Text;
        string totalPrice = item.SubItems[4].Text;

        // Print each row
        e.Graphics.DrawString(qty, font, brush, startX, startY);
        e.Graphics.DrawString(designation, font, brush, startX + 60, startY);
        e.Graphics.DrawString(unitPrice, font, brush, startX + 210, startY);
        e.Graphics.DrawString(totalPrice, font, brush, startX + 350, startY);

        startY += offsetY;
    }

    // Add the footer message
    startY += offsetY;
    e.Graphics.DrawString("Thank you for your support. Enjoy your day", font, brush, startX, startY);
}



        public class RawPrinterHelper
        {
            [DllImport("winspool.Drv", EntryPoint = "OpenPrinterA", SetLastError = true, CharSet = CharSet.Ansi, ExactSpelling = true, CallingConvention = CallingConvention.StdCall)]
            public static extern bool OpenPrinter([MarshalAs(UnmanagedType.LPStr)] string szPrinter, ref IntPtr hPrinter, IntPtr pd);

            [DllImport("winspool.Drv", EntryPoint = "ClosePrinter", SetLastError = true, ExactSpelling = true, CallingConvention = CallingConvention.StdCall)]
            public static extern bool ClosePrinter(IntPtr hPrinter);

            [DllImport("winspool.Drv", EntryPoint = "StartDocPrinterA", SetLastError = true, CharSet = CharSet.Ansi, ExactSpelling = true, CallingConvention = CallingConvention.StdCall)]
            public static extern bool StartDocPrinter(IntPtr hPrinter, Int32 level, [In(), MarshalAs(UnmanagedType.LPStruct)] DOCINFOA di);

            [DllImport("winspool.Drv", EntryPoint = "EndDocPrinter", SetLastError = true, ExactSpelling = true, CallingConvention = CallingConvention.StdCall)]
            public static extern bool EndDocPrinter(IntPtr hPrinter);

            [DllImport("winspool.Drv", EntryPoint = "StartPagePrinter", SetLastError = true, ExactSpelling = true, CallingConvention = CallingConvention.StdCall)]
            public static extern bool StartPagePrinter(IntPtr hPrinter);

            [DllImport("winspool.Drv", EntryPoint = "EndPagePrinter", SetLastError = true, ExactSpelling = true, CallingConvention = CallingConvention.StdCall)]
            public static extern bool EndPagePrinter(IntPtr hPrinter);

            [DllImport("winspool.Drv", EntryPoint = "WritePrinter", SetLastError = true, ExactSpelling = true, CallingConvention = CallingConvention.StdCall)]
            public static extern bool WritePrinter(IntPtr hPrinter, IntPtr pBytes, Int32 dwCount, ref Int32 dwWritten);

            public static bool SendBytesToPrinter(string szPrinterName, byte[] pBytes)
            {
                IntPtr pUnmanagedBytes = IntPtr.Zero;
                Int32 dwCount = pBytes.Length;
                Int32 dwWritten = 0;

                pUnmanagedBytes = Marshal.AllocCoTaskMem(dwCount);
                Marshal.Copy(pBytes, 0, pUnmanagedBytes, dwCount);

                IntPtr hPrinter = IntPtr.Zero;
                DOCINFOA di = new DOCINFOA();
                bool bSuccess = false;
                di.pDocName = "My C#.NET RAW Document";
                di.pDataType = "RAW";

                if (OpenPrinter(szPrinterName.Normalize(), ref hPrinter, IntPtr.Zero))
                {
                    if (StartDocPrinter(hPrinter, 1, di))
                    {
                        if (StartPagePrinter(hPrinter))
                        {
                            bSuccess = WritePrinter(hPrinter, pUnmanagedBytes, dwCount, ref dwWritten);
                            EndPagePrinter(hPrinter);
                        }
                        EndDocPrinter(hPrinter);
                    }
                    ClosePrinter(hPrinter);
                }
                Marshal.FreeCoTaskMem(pUnmanagedBytes);
                return bSuccess;
            }

            public static bool SendStringToPrinter(string szPrinterName, string szString)
            {
                IntPtr pBytes = default(IntPtr);
                Int32 dwCount = default(Int32);
                dwCount = szString.Length;
                pBytes = Marshal.StringToCoTaskMemAnsi(szString);
                SendBytesToPrinter(szPrinterName, Encoding.ASCII.GetBytes(szString));
                Marshal.FreeCoTaskMem(pBytes);
                return true;
            }

            public class DOCINFOA
            {
                [MarshalAs(UnmanagedType.LPStr)]
                public string pDocName;
                [MarshalAs(UnmanagedType.LPStr)]
                public string pOutputFile;
                [MarshalAs(UnmanagedType.LPStr)]
                public string pDataType;
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void PnFirstButton_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}




