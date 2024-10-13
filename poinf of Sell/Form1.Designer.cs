namespace point_of_Sell
{
    partial class Form1
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.BtnSecond = new System.Windows.Forms.Button();
            this.BtnThird = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(25, 65);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(76, 45);
            this.button1.TabIndex = 0;
            this.button1.Text = "Add First Button";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(371, 60);
            this.button2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(140, 50);
            this.button2.TabIndex = 1;
            this.button2.Text = "Open Form Order";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // BtnSecond
            // 
            this.BtnSecond.Location = new System.Drawing.Point(121, 65);
            this.BtnSecond.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BtnSecond.Name = "BtnSecond";
            this.BtnSecond.Size = new System.Drawing.Size(86, 45);
            this.BtnSecond.TabIndex = 2;
            this.BtnSecond.Text = "Add Second Button";
            this.BtnSecond.UseVisualStyleBackColor = true;
            this.BtnSecond.Click += new System.EventHandler(this.BtnSecond_Click);
            // 
            // BtnThird
            // 
            this.BtnThird.Location = new System.Drawing.Point(230, 65);
            this.BtnThird.Name = "BtnThird";
            this.BtnThird.Size = new System.Drawing.Size(104, 45);
            this.BtnThird.TabIndex = 3;
            this.BtnThird.Text = "Add Third Button";
            this.BtnThird.UseVisualStyleBackColor = true;
            this.BtnThird.Click += new System.EventHandler(this.BtnThird_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(620, 373);
            this.Controls.Add(this.BtnThird);
            this.Controls.Add(this.BtnSecond);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button BtnSecond;
        private System.Windows.Forms.Button BtnThird;
    }
}

