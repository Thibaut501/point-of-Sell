namespace poinf_of_Sell
{
    partial class FrmEditMenu
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
            this.tbFirstButton = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnConfirm1st = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cbo1stbutton = new System.Windows.Forms.ComboBox();
            this.txtFirstButton = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.optionEdit = new System.Windows.Forms.RadioButton();
            this.optionDelete = new System.Windows.Forms.RadioButton();
            this.tb2ndButton = new System.Windows.Forms.TabPage();
            this.tb3rdButtons = new System.Windows.Forms.TabPage();
            this.tbFirstButton.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbFirstButton
            // 
            this.tbFirstButton.Controls.Add(this.tabPage1);
            this.tbFirstButton.Controls.Add(this.tb2ndButton);
            this.tbFirstButton.Controls.Add(this.tb3rdButtons);
            this.tbFirstButton.Location = new System.Drawing.Point(12, 45);
            this.tbFirstButton.Name = "tbFirstButton";
            this.tbFirstButton.SelectedIndex = 0;
            this.tbFirstButton.Size = new System.Drawing.Size(729, 381);
            this.tbFirstButton.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btnConfirm1st);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.cbo1stbutton);
            this.tabPage1.Controls.Add(this.txtFirstButton);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(721, 352);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "1st Buttons";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btnConfirm1st
            // 
            this.btnConfirm1st.Location = new System.Drawing.Point(154, 296);
            this.btnConfirm1st.Name = "btnConfirm1st";
            this.btnConfirm1st.Size = new System.Drawing.Size(135, 31);
            this.btnConfirm1st.TabIndex = 4;
            this.btnConfirm1st.Text = "Confirm";
            this.btnConfirm1st.UseVisualStyleBackColor = true;
            this.btnConfirm1st.Click += new System.EventHandler(this.btnConfirm1st_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 242);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "Select :";
            // 
            // cbo1stbutton
            // 
            this.cbo1stbutton.FormattingEnabled = true;
            this.cbo1stbutton.Location = new System.Drawing.Point(140, 234);
            this.cbo1stbutton.Name = "cbo1stbutton";
            this.cbo1stbutton.Size = new System.Drawing.Size(298, 33);
            this.cbo1stbutton.TabIndex = 2;
            this.cbo1stbutton.SelectedIndexChanged += new System.EventHandler(this.cho1stbutton_SelectedIndexChanged);
            // 
            // txtFirstButton
            // 
            this.txtFirstButton.Location = new System.Drawing.Point(140, 173);
            this.txtFirstButton.Name = "txtFirstButton";
            this.txtFirstButton.Size = new System.Drawing.Size(298, 30);
            this.txtFirstButton.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.optionEdit);
            this.groupBox1.Controls.Add(this.optionDelete);
            this.groupBox1.Location = new System.Drawing.Point(25, 32);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(413, 100);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // optionEdit
            // 
            this.optionEdit.AutoSize = true;
            this.optionEdit.Location = new System.Drawing.Point(212, 51);
            this.optionEdit.Name = "optionEdit";
            this.optionEdit.Size = new System.Drawing.Size(70, 29);
            this.optionEdit.TabIndex = 2;
            this.optionEdit.TabStop = true;
            this.optionEdit.Text = "Edit";
            this.optionEdit.UseVisualStyleBackColor = true;
            // 
            // optionDelete
            // 
            this.optionDelete.AutoSize = true;
            this.optionDelete.Location = new System.Drawing.Point(6, 51);
            this.optionDelete.Name = "optionDelete";
            this.optionDelete.Size = new System.Drawing.Size(95, 29);
            this.optionDelete.TabIndex = 1;
            this.optionDelete.TabStop = true;
            this.optionDelete.Text = "Delete";
            this.optionDelete.UseVisualStyleBackColor = true;
            // 
            // tb2ndButton
            // 
            this.tb2ndButton.Location = new System.Drawing.Point(4, 25);
            this.tb2ndButton.Name = "tb2ndButton";
            this.tb2ndButton.Padding = new System.Windows.Forms.Padding(3);
            this.tb2ndButton.Size = new System.Drawing.Size(721, 352);
            this.tb2ndButton.TabIndex = 1;
            this.tb2ndButton.Text = "2nd Buttons";
            this.tb2ndButton.UseVisualStyleBackColor = true;
            // 
            // tb3rdButtons
            // 
            this.tb3rdButtons.Location = new System.Drawing.Point(4, 25);
            this.tb3rdButtons.Name = "tb3rdButtons";
            this.tb3rdButtons.Padding = new System.Windows.Forms.Padding(3);
            this.tb3rdButtons.Size = new System.Drawing.Size(721, 352);
            this.tb3rdButtons.TabIndex = 2;
            this.tb3rdButtons.Text = "3rd Buttons";
            this.tb3rdButtons.UseVisualStyleBackColor = true;
            // 
            // FrmEditMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(479, 451);
            this.Controls.Add(this.tbFirstButton);
            this.Name = "FrmEditMenu";
            this.Text = "Edit Menu Buttons";
            this.Load += new System.EventHandler(this.FrmEditMenu_Load);
            this.tbFirstButton.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tbFirstButton;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tb2ndButton;
        private System.Windows.Forms.TabPage tb3rdButtons;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton optionEdit;
        private System.Windows.Forms.RadioButton optionDelete;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbo1stbutton;
        private System.Windows.Forms.TextBox txtFirstButton;
        private System.Windows.Forms.Button btnConfirm1st;
    }
}