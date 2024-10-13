namespace point_of_Sell
{
    partial class FrmMakeOrder
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMakeOrder));
            this.PnFirstButton = new System.Windows.Forms.Panel();
            this.PnButton2And3 = new System.Windows.Forms.FlowLayoutPanel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.LsOrders = new System.Windows.Forms.ListView();
            this.txtTotalAmount = new System.Windows.Forms.TextBox();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.BtnDeleteAll = new System.Windows.Forms.Button();
            this.BtnDelete1Item = new System.Windows.Forms.Button();
            this.QtnQty = new System.Windows.Forms.Button();
            this.txtChange = new System.Windows.Forms.Label();
            this.txtAmountPaid = new System.Windows.Forms.TextBox();
            this.BtnPrint = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // PnFirstButton
            // 
            this.PnFirstButton.Location = new System.Drawing.Point(12, 343);
            this.PnFirstButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.PnFirstButton.Name = "PnFirstButton";
            this.PnFirstButton.Size = new System.Drawing.Size(1181, 235);
            this.PnFirstButton.TabIndex = 0;
            this.PnFirstButton.Paint += new System.Windows.Forms.PaintEventHandler(this.PnFirstButton_Paint);
            // 
            // PnButton2And3
            // 
            this.PnButton2And3.Location = new System.Drawing.Point(12, 603);
            this.PnButton2And3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.PnButton2And3.Name = "PnButton2And3";
            this.PnButton2And3.Size = new System.Drawing.Size(1181, 229);
            this.PnButton2And3.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.LsOrders);
            this.groupBox1.Location = new System.Drawing.Point(287, 12);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(706, 287);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // LsOrders
            // 
            this.LsOrders.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LsOrders.HideSelection = false;
            this.LsOrders.Location = new System.Drawing.Point(17, 16);
            this.LsOrders.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.LsOrders.Name = "LsOrders";
            this.LsOrders.Size = new System.Drawing.Size(672, 246);
            this.LsOrders.TabIndex = 0;
            this.LsOrders.UseCompatibleStateImageBehavior = false;
            this.LsOrders.SelectedIndexChanged += new System.EventHandler(this.LsOrders_SelectedIndexChanged);
            this.LsOrders.Click += new System.EventHandler(this.LsOrders_Click);
            // 
            // txtTotalAmount
            // 
            this.txtTotalAmount.BackColor = System.Drawing.SystemColors.HighlightText;
            this.txtTotalAmount.Enabled = false;
            this.txtTotalAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalAmount.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.txtTotalAmount.Location = new System.Drawing.Point(999, 22);
            this.txtTotalAmount.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTotalAmount.Name = "txtTotalAmount";
            this.txtTotalAmount.Size = new System.Drawing.Size(421, 98);
            this.txtTotalAmount.TabIndex = 3;
            this.txtTotalAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(82, 295);
            this.txtPrice.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(100, 22);
            this.txtPrice.TabIndex = 2;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.BtnDeleteAll);
            this.groupBox2.Controls.Add(this.BtnDelete1Item);
            this.groupBox2.Controls.Add(this.QtnQty);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(12, 28);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Size = new System.Drawing.Size(269, 234);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            // 
            // BtnDeleteAll
            // 
            this.BtnDeleteAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnDeleteAll.Location = new System.Drawing.Point(0, 163);
            this.BtnDeleteAll.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnDeleteAll.Name = "BtnDeleteAll";
            this.BtnDeleteAll.Size = new System.Drawing.Size(269, 67);
            this.BtnDeleteAll.TabIndex = 2;
            this.BtnDeleteAll.Text = "Delete All";
            this.BtnDeleteAll.UseVisualStyleBackColor = true;
            this.BtnDeleteAll.Click += new System.EventHandler(this.BtnDeleteAll_Click);
            // 
            // BtnDelete1Item
            // 
            this.BtnDelete1Item.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnDelete1Item.Location = new System.Drawing.Point(0, 104);
            this.BtnDelete1Item.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnDelete1Item.Name = "BtnDelete1Item";
            this.BtnDelete1Item.Size = new System.Drawing.Size(269, 55);
            this.BtnDelete1Item.TabIndex = 1;
            this.BtnDelete1Item.Text = "Delete Item";
            this.BtnDelete1Item.UseVisualStyleBackColor = true;
            this.BtnDelete1Item.Click += new System.EventHandler(this.BtnDelete1Item_Click);
            // 
            // QtnQty
            // 
            this.QtnQty.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.QtnQty.Location = new System.Drawing.Point(0, 35);
            this.QtnQty.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.QtnQty.Name = "QtnQty";
            this.QtnQty.Size = new System.Drawing.Size(269, 63);
            this.QtnQty.TabIndex = 0;
            this.QtnQty.Text = "Quantity";
            this.QtnQty.UseVisualStyleBackColor = true;
            this.QtnQty.Click += new System.EventHandler(this.QtnQty_Click);
            // 
            // txtChange
            // 
            this.txtChange.AutoSize = true;
            this.txtChange.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.txtChange.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtChange.Location = new System.Drawing.Point(1449, 22);
            this.txtChange.Name = "txtChange";
            this.txtChange.Size = new System.Drawing.Size(249, 91);
            this.txtChange.TabIndex = 4;
            this.txtChange.Text = "label1";
            // 
            // txtAmountPaid
            // 
            this.txtAmountPaid.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAmountPaid.Location = new System.Drawing.Point(1341, 170);
            this.txtAmountPaid.Name = "txtAmountPaid";
            this.txtAmountPaid.Size = new System.Drawing.Size(152, 61);
            this.txtAmountPaid.TabIndex = 5;
            this.txtAmountPaid.TextChanged += new System.EventHandler(this.txtAmountPaid_TextChanged);
            this.txtAmountPaid.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAmountPaid_KeyPress);
            // 
            // BtnPrint
            // 
            this.BtnPrint.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BtnPrint.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnPrint.Location = new System.Drawing.Point(6, 2);
            this.BtnPrint.Name = "BtnPrint";
            this.BtnPrint.Size = new System.Drawing.Size(316, 167);
            this.BtnPrint.TabIndex = 0;
            this.BtnPrint.Text = "Print";
            this.BtnPrint.UseVisualStyleBackColor = false;
            this.BtnPrint.Click += new System.EventHandler(this.BtnPrint_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.BtnPrint);
            this.groupBox3.Location = new System.Drawing.Point(993, 132);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(329, 167);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            // 
            // FrmMakeOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1720, 870);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.txtTotalAmount);
            this.Controls.Add(this.txtChange);
            this.Controls.Add(this.txtAmountPaid);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.PnButton2And3);
            this.Controls.Add(this.PnFirstButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FrmMakeOrder";
            this.Text = "FrmMakeOrder";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmMakeOrder_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel PnFirstButton;
        private System.Windows.Forms.FlowLayoutPanel PnButton2And3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button BtnDeleteAll;
        private System.Windows.Forms.Button BtnDelete1Item;
        private System.Windows.Forms.Button QtnQty;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.TextBox txtTotalAmount;
        private System.Windows.Forms.Label txtChange;
        private System.Windows.Forms.TextBox txtAmountPaid;
        private System.Windows.Forms.Button BtnPrint;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ListView LsOrders;
    }
}