namespace BookInformationKeeper {
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.isbntextBox1 = new System.Windows.Forms.TextBox();
            this.nametextBox2 = new System.Windows.Forms.TextBox();
            this.isbnradioButton1 = new System.Windows.Forms.RadioButton();
            this.nameradioButton2 = new System.Windows.Forms.RadioButton();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.addbutton1 = new System.Windows.Forms.Button();
            this.searchbutton1 = new System.Windows.Forms.Button();
            this.AddlistBox1 = new System.Windows.Forms.ListBox();
            this.SearchlistBox2 = new System.Windows.Forms.ListBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.AddlistBox1);
            this.groupBox1.Controls.Add(this.addbutton1);
            this.groupBox1.Controls.Add(this.nametextBox2);
            this.groupBox1.Controls.Add(this.isbntextBox1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(40, 32);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(289, 497);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Add Book";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.SearchlistBox2);
            this.groupBox2.Controls.Add(this.searchbutton1);
            this.groupBox2.Controls.Add(this.textBox3);
            this.groupBox2.Controls.Add(this.nameradioButton2);
            this.groupBox2.Controls.Add(this.isbnradioButton1);
            this.groupBox2.Location = new System.Drawing.Point(374, 32);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(310, 487);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Search Book";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 112);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(41, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "ISBN";
            // 
            // isbntextBox1
            // 
            this.isbntextBox1.Location = new System.Drawing.Point(114, 42);
            this.isbntextBox1.Name = "isbntextBox1";
            this.isbntextBox1.Size = new System.Drawing.Size(108, 20);
            this.isbntextBox1.TabIndex = 2;
            // 
            // nametextBox2
            // 
            this.nametextBox2.Location = new System.Drawing.Point(114, 105);
            this.nametextBox2.Name = "nametextBox2";
            this.nametextBox2.Size = new System.Drawing.Size(138, 20);
            this.nametextBox2.TabIndex = 3;
            // 
            // isbnradioButton1
            // 
            this.isbnradioButton1.AutoSize = true;
            this.isbnradioButton1.Location = new System.Drawing.Point(68, 57);
            this.isbnradioButton1.Name = "isbnradioButton1";
            this.isbnradioButton1.Size = new System.Drawing.Size(50, 17);
            this.isbnradioButton1.TabIndex = 0;
            this.isbnradioButton1.TabStop = true;
            this.isbnradioButton1.Text = "ISBN";
            this.isbnradioButton1.UseVisualStyleBackColor = true;
            // 
            // nameradioButton2
            // 
            this.nameradioButton2.AutoSize = true;
            this.nameradioButton2.Location = new System.Drawing.Point(185, 57);
            this.nameradioButton2.Name = "nameradioButton2";
            this.nameradioButton2.Size = new System.Drawing.Size(53, 17);
            this.nameradioButton2.TabIndex = 1;
            this.nameradioButton2.TabStop = true;
            this.nameradioButton2.Text = "Name";
            this.nameradioButton2.UseVisualStyleBackColor = true;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(68, 102);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(170, 20);
            this.textBox3.TabIndex = 2;
            this.textBox3.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // addbutton1
            // 
            this.addbutton1.Location = new System.Drawing.Point(177, 150);
            this.addbutton1.Name = "addbutton1";
            this.addbutton1.Size = new System.Drawing.Size(75, 23);
            this.addbutton1.TabIndex = 4;
            this.addbutton1.Text = "Add";
            this.addbutton1.UseVisualStyleBackColor = true;
            this.addbutton1.Click += new System.EventHandler(this.addbutton1_Click);
            // 
            // searchbutton1
            // 
            this.searchbutton1.Location = new System.Drawing.Point(163, 150);
            this.searchbutton1.Name = "searchbutton1";
            this.searchbutton1.Size = new System.Drawing.Size(75, 23);
            this.searchbutton1.TabIndex = 3;
            this.searchbutton1.Text = "Search";
            this.searchbutton1.UseVisualStyleBackColor = true;
            // 
            // AddlistBox1
            // 
            this.AddlistBox1.FormattingEnabled = true;
            this.AddlistBox1.Location = new System.Drawing.Point(44, 215);
            this.AddlistBox1.Name = "AddlistBox1";
            this.AddlistBox1.Size = new System.Drawing.Size(208, 199);
            this.AddlistBox1.TabIndex = 5;
            // 
            // SearchlistBox2
            // 
            this.SearchlistBox2.FormattingEnabled = true;
            this.SearchlistBox2.Location = new System.Drawing.Point(32, 215);
            this.SearchlistBox2.Name = "SearchlistBox2";
            this.SearchlistBox2.Size = new System.Drawing.Size(206, 199);
            this.SearchlistBox2.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(724, 509);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Book information keeper";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox nametextBox2;
        private System.Windows.Forms.TextBox isbntextBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.RadioButton nameradioButton2;
        private System.Windows.Forms.RadioButton isbnradioButton1;
        private System.Windows.Forms.ListBox AddlistBox1;
        private System.Windows.Forms.Button addbutton1;
        private System.Windows.Forms.ListBox SearchlistBox2;
        private System.Windows.Forms.Button searchbutton1;
    }
}

