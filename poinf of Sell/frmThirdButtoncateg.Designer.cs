namespace poinf_of_Sell
{
    partial class frmThirdButtoncateg
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.CboSecondCateg = new System.Windows.Forms.ComboBox();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.txtThirdCateg = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.BtnAddThirdCateg = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.CboSecondCateg);
            this.groupBox1.Controls.Add(this.txtPrice);
            this.groupBox1.Controls.Add(this.txtThirdCateg);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(64, 30);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(645, 258);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // CboSecondCateg
            // 
            this.CboSecondCateg.FormattingEnabled = true;
            this.CboSecondCateg.Location = new System.Drawing.Point(281, 18);
            this.CboSecondCateg.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CboSecondCateg.Name = "CboSecondCateg";
            this.CboSecondCateg.Size = new System.Drawing.Size(191, 24);
            this.CboSecondCateg.TabIndex = 5;
           
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(281, 121);
            this.txtPrice.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(88, 22);
            this.txtPrice.TabIndex = 4;
            // 
            // txtThirdCateg
            // 
            this.txtThirdCateg.Location = new System.Drawing.Point(281, 64);
            this.txtThirdCateg.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtThirdCateg.Name = "txtThirdCateg";
            this.txtThirdCateg.Size = new System.Drawing.Size(191, 22);
            this.txtThirdCateg.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(121, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Price :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(121, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Product Name :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(121, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Category :";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.BtnAddThirdCateg);
            this.groupBox2.Location = new System.Drawing.Point(301, 330);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Size = new System.Drawing.Size(297, 100);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "groupBox2";
            // 
            // BtnAddThirdCateg
            // 
            this.BtnAddThirdCateg.Location = new System.Drawing.Point(93, 38);
            this.BtnAddThirdCateg.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnAddThirdCateg.Name = "BtnAddThirdCateg";
            this.BtnAddThirdCateg.Size = new System.Drawing.Size(129, 43);
            this.BtnAddThirdCateg.TabIndex = 0;
            this.BtnAddThirdCateg.Text = "Save";
            this.BtnAddThirdCateg.UseVisualStyleBackColor = true;
            this.BtnAddThirdCateg.Click += new System.EventHandler(this.BtnAddThirdCateg_Click);
            // 
            // frmThirdButtoncateg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(757, 450);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmThirdButtoncateg";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "frmThirdButtoncateg";
            this.Load += new System.EventHandler(this.frmThirdButtoncateg_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox CboSecondCateg;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.TextBox txtThirdCateg;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button BtnAddThirdCateg;
    }
}