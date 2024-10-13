namespace poinf_of_Sell
{
    partial class FirstButtonF
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
            this.rDelete = new System.Windows.Forms.RadioButton();
            this.rEdit = new System.Windows.Forms.RadioButton();
            this.rAdd = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtExecute = new System.Windows.Forms.TextBox();
            this.Save1stButtonCateg = new System.Windows.Forms.ComboBox();
            this.BtnExecute = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rDelete);
            this.groupBox1.Controls.Add(this.rEdit);
            this.groupBox1.Controls.Add(this.rAdd);
            this.groupBox1.Location = new System.Drawing.Point(31, 44);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(451, 100);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Select Option:";
            // 
            // rDelete
            // 
            this.rDelete.AutoSize = true;
            this.rDelete.Location = new System.Drawing.Point(277, 35);
            this.rDelete.Name = "rDelete";
            this.rDelete.Size = new System.Drawing.Size(68, 20);
            this.rDelete.TabIndex = 1;
            this.rDelete.TabStop = true;
            this.rDelete.Text = "Delete";
            this.rDelete.UseVisualStyleBackColor = true;
            // 
            // rEdit
            // 
            this.rEdit.AutoSize = true;
            this.rEdit.Location = new System.Drawing.Point(144, 35);
            this.rEdit.Name = "rEdit";
            this.rEdit.Size = new System.Drawing.Size(51, 20);
            this.rEdit.TabIndex = 1;
            this.rEdit.TabStop = true;
            this.rEdit.Text = "Edit";
            this.rEdit.UseVisualStyleBackColor = true;
            // 
            // rAdd
            // 
            this.rAdd.AutoSize = true;
            this.rAdd.Location = new System.Drawing.Point(26, 35);
            this.rAdd.Name = "rAdd";
            this.rAdd.Size = new System.Drawing.Size(53, 20);
            this.rAdd.TabIndex = 0;
            this.rAdd.TabStop = true;
            this.rAdd.Text = "Add";
            this.rAdd.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtExecute);
            this.groupBox2.Controls.Add(this.Save1stButtonCateg);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(31, 174);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(451, 115);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            // 
            // txtExecute
            // 
            this.txtExecute.Location = new System.Drawing.Point(16, 60);
            this.txtExecute.Name = "txtExecute";
            this.txtExecute.Size = new System.Drawing.Size(276, 30);
            this.txtExecute.TabIndex = 1;
            // 
            // Save1stButtonCateg
            // 
            this.Save1stButtonCateg.FormattingEnabled = true;
            this.Save1stButtonCateg.Location = new System.Drawing.Point(16, 21);
            this.Save1stButtonCateg.Name = "Save1stButtonCateg";
            this.Save1stButtonCateg.Size = new System.Drawing.Size(276, 33);
            this.Save1stButtonCateg.TabIndex = 0;
            // 
            // BtnExecute
            // 
            this.BtnExecute.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnExecute.Location = new System.Drawing.Point(250, 295);
            this.BtnExecute.Name = "BtnExecute";
            this.BtnExecute.Size = new System.Drawing.Size(132, 34);
            this.BtnExecute.TabIndex = 2;
            this.BtnExecute.Text = "Execute";
            this.BtnExecute.UseVisualStyleBackColor = true;
            this.BtnExecute.Click += new System.EventHandler(this.BtnExecute_Click);
            // 
            // FirstButtonF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(569, 341);
            this.Controls.Add(this.BtnExecute);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FirstButtonF";
            this.Text = "FirstButtonF";
            this.Load += new System.EventHandler(this.FirstButtonF_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rDelete;
        private System.Windows.Forms.RadioButton rEdit;
        private System.Windows.Forms.RadioButton rAdd;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtExecute;
        private System.Windows.Forms.ComboBox Save1stButtonCateg;
        private System.Windows.Forms.Button BtnExecute;
    }
}