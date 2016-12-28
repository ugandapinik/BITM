namespace FirstApp {
    partial class Form1 {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.ClickButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.FirstNameTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.LastNameextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.FirstNumTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SecondNumTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // ClickButton
            // 
            this.ClickButton.Location = new System.Drawing.Point(153, 231);
            this.ClickButton.Name = "ClickButton";
            this.ClickButton.Size = new System.Drawing.Size(75, 23);
            this.ClickButton.TabIndex = 0;
            this.ClickButton.Text = "Click";
            this.ClickButton.UseVisualStyleBackColor = true;
            this.ClickButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(83, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "First Name";
            this.label1.Visible = false;
            // 
            // FirstNameTextBox
            // 
            this.FirstNameTextBox.Location = new System.Drawing.Point(143, 16);
            this.FirstNameTextBox.Name = "FirstNameTextBox";
            this.FirstNameTextBox.Size = new System.Drawing.Size(172, 20);
            this.FirstNameTextBox.TabIndex = 2;
            this.FirstNameTextBox.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(82, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Last Name";
            this.label2.Visible = false;
            // 
            // LastNameextBox
            // 
            this.LastNameextBox.Location = new System.Drawing.Point(143, 38);
            this.LastNameextBox.Name = "LastNameextBox";
            this.LastNameextBox.Size = new System.Drawing.Size(172, 20);
            this.LastNameextBox.TabIndex = 2;
            this.LastNameextBox.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(74, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "First Number";
            // 
            // FirstNumTextBox
            // 
            this.FirstNumTextBox.Location = new System.Drawing.Point(143, 79);
            this.FirstNumTextBox.Name = "FirstNumTextBox";
            this.FirstNumTextBox.Size = new System.Drawing.Size(172, 20);
            this.FirstNumTextBox.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(56, 108);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Second Number";
            // 
            // SecondNumTextBox
            // 
            this.SecondNumTextBox.Location = new System.Drawing.Point(143, 105);
            this.SecondNumTextBox.Name = "SecondNumTextBox";
            this.SecondNumTextBox.Size = new System.Drawing.Size(172, 20);
            this.SecondNumTextBox.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(392, 395);
            this.Controls.Add(this.SecondNumTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.FirstNumTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.LastNameextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.FirstNameTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ClickButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ClickButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox FirstNameTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox LastNameextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox FirstNumTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox SecondNumTextBox;
    }
}

