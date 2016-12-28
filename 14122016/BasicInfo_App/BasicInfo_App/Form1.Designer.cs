namespace BasicInfo_App
{
    partial class basicsalaryinformationForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.nametextBox = new System.Windows.Forms.TextBox();
            this.medicalAllowancetextBox = new System.Windows.Forms.TextBox();
            this.basicSalarytextBox = new System.Windows.Forms.TextBox();
            this.otherAllowancetextBox = new System.Windows.Forms.TextBox();
            this.totalSalarytextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.showButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(121, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name";
            // 
            // nametextBox
            // 
            this.nametextBox.Location = new System.Drawing.Point(175, 53);
            this.nametextBox.Name = "nametextBox";
            this.nametextBox.Size = new System.Drawing.Size(189, 20);
            this.nametextBox.TabIndex = 1;
            // 
            // medicalAllowancetextBox
            // 
            this.medicalAllowancetextBox.Location = new System.Drawing.Point(175, 105);
            this.medicalAllowancetextBox.Name = "medicalAllowancetextBox";
            this.medicalAllowancetextBox.Size = new System.Drawing.Size(189, 20);
            this.medicalAllowancetextBox.TabIndex = 2;
            // 
            // basicSalarytextBox
            // 
            this.basicSalarytextBox.Location = new System.Drawing.Point(175, 79);
            this.basicSalarytextBox.Name = "basicSalarytextBox";
            this.basicSalarytextBox.Size = new System.Drawing.Size(189, 20);
            this.basicSalarytextBox.TabIndex = 3;
            // 
            // otherAllowancetextBox
            // 
            this.otherAllowancetextBox.Location = new System.Drawing.Point(175, 132);
            this.otherAllowancetextBox.Name = "otherAllowancetextBox";
            this.otherAllowancetextBox.Size = new System.Drawing.Size(189, 20);
            this.otherAllowancetextBox.TabIndex = 5;
            // 
            // totalSalarytextBox
            // 
            this.totalSalarytextBox.Location = new System.Drawing.Point(175, 158);
            this.totalSalarytextBox.Name = "totalSalarytextBox";
            this.totalSalarytextBox.Size = new System.Drawing.Size(189, 20);
            this.totalSalarytextBox.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(60, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Medical Allowance";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(91, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Basic Salary";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(71, 135);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Other Allowance";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(93, 161);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Total Salary";
            // 
            // showButton
            // 
            this.showButton.Location = new System.Drawing.Point(289, 205);
            this.showButton.Name = "showButton";
            this.showButton.Size = new System.Drawing.Size(75, 23);
            this.showButton.TabIndex = 13;
            this.showButton.Text = "Show";
            this.showButton.UseVisualStyleBackColor = true;
            this.showButton.Click += new System.EventHandler(this.showButton_Click);
            // 
            // basicsalaryinformationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(673, 457);
            this.Controls.Add(this.showButton);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.totalSalarytextBox);
            this.Controls.Add(this.otherAllowancetextBox);
            this.Controls.Add(this.basicSalarytextBox);
            this.Controls.Add(this.medicalAllowancetextBox);
            this.Controls.Add(this.nametextBox);
            this.Controls.Add(this.label1);
            this.Name = "basicsalaryinformationForm";
            this.Text = "Basic Salary Information";
            this.Load += new System.EventHandler(this.basicsalaryinformationForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox nametextBox;
        private System.Windows.Forms.TextBox medicalAllowancetextBox;
        private System.Windows.Forms.TextBox basicSalarytextBox;
        private System.Windows.Forms.TextBox otherAllowancetextBox;
        private System.Windows.Forms.TextBox totalSalarytextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button showButton;
    }
}

