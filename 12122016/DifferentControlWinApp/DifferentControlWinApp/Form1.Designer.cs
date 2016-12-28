namespace DifferentControlWinApp {
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
            this.evenCheckBox = new System.Windows.Forms.CheckBox();
            this.oddCheckBox = new System.Windows.Forms.CheckBox();
            this.showButton = new System.Windows.Forms.Button();
            this.dayComboBox = new System.Windows.Forms.ComboBox();
            this.showdayButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.genderButton = new System.Windows.Forms.Button();
            this.FemaleRadioButton = new System.Windows.Forms.RadioButton();
            this.maleRadioButton = new System.Windows.Forms.RadioButton();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.showdateButton = new System.Windows.Forms.Button();
            this.studentListView = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // evenCheckBox
            // 
            this.evenCheckBox.AutoSize = true;
            this.evenCheckBox.Location = new System.Drawing.Point(37, 17);
            this.evenCheckBox.Name = "evenCheckBox";
            this.evenCheckBox.Size = new System.Drawing.Size(50, 17);
            this.evenCheckBox.TabIndex = 0;
            this.evenCheckBox.Text = "even";
            this.evenCheckBox.UseVisualStyleBackColor = true;
            // 
            // oddCheckBox
            // 
            this.oddCheckBox.AutoSize = true;
            this.oddCheckBox.Location = new System.Drawing.Point(37, 52);
            this.oddCheckBox.Name = "oddCheckBox";
            this.oddCheckBox.Size = new System.Drawing.Size(44, 17);
            this.oddCheckBox.TabIndex = 1;
            this.oddCheckBox.Text = "odd";
            this.oddCheckBox.UseVisualStyleBackColor = true;
            // 
            // showButton
            // 
            this.showButton.Location = new System.Drawing.Point(37, 88);
            this.showButton.Name = "showButton";
            this.showButton.Size = new System.Drawing.Size(75, 23);
            this.showButton.TabIndex = 2;
            this.showButton.Text = "Show";
            this.showButton.UseVisualStyleBackColor = true;
            this.showButton.Click += new System.EventHandler(this.showButton_Click);
            // 
            // dayComboBox
            // 
            this.dayComboBox.FormattingEnabled = true;
            this.dayComboBox.Location = new System.Drawing.Point(178, 17);
            this.dayComboBox.Name = "dayComboBox";
            this.dayComboBox.Size = new System.Drawing.Size(162, 21);
            this.dayComboBox.TabIndex = 3;
            // 
            // showdayButton
            // 
            this.showdayButton.Location = new System.Drawing.Point(366, 14);
            this.showdayButton.Name = "showdayButton";
            this.showdayButton.Size = new System.Drawing.Size(75, 23);
            this.showdayButton.TabIndex = 4;
            this.showdayButton.Text = "Show Day";
            this.showdayButton.UseVisualStyleBackColor = true;
            this.showdayButton.Click += new System.EventHandler(this.showdayButton_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.genderButton);
            this.groupBox1.Controls.Add(this.FemaleRadioButton);
            this.groupBox1.Controls.Add(this.maleRadioButton);
            this.groupBox1.Location = new System.Drawing.Point(37, 134);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(209, 118);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Gender";
            // 
            // genderButton
            // 
            this.genderButton.Location = new System.Drawing.Point(78, 68);
            this.genderButton.Name = "genderButton";
            this.genderButton.Size = new System.Drawing.Size(105, 23);
            this.genderButton.TabIndex = 2;
            this.genderButton.Text = "Show Gender";
            this.genderButton.UseVisualStyleBackColor = true;
            this.genderButton.Click += new System.EventHandler(this.genderButton_Click);
            // 
            // FemaleRadioButton
            // 
            this.FemaleRadioButton.AutoSize = true;
            this.FemaleRadioButton.Location = new System.Drawing.Point(78, 44);
            this.FemaleRadioButton.Name = "FemaleRadioButton";
            this.FemaleRadioButton.Size = new System.Drawing.Size(59, 17);
            this.FemaleRadioButton.TabIndex = 1;
            this.FemaleRadioButton.Text = "Female";
            this.FemaleRadioButton.UseVisualStyleBackColor = true;
            // 
            // maleRadioButton
            // 
            this.maleRadioButton.AutoSize = true;
            this.maleRadioButton.Checked = true;
            this.maleRadioButton.Location = new System.Drawing.Point(78, 20);
            this.maleRadioButton.Name = "maleRadioButton";
            this.maleRadioButton.Size = new System.Drawing.Size(48, 17);
            this.maleRadioButton.TabIndex = 0;
            this.maleRadioButton.TabStop = true;
            this.maleRadioButton.Text = "Male";
            this.maleRadioButton.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Location = new System.Drawing.Point(165, 67);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker.TabIndex = 6;
            // 
            // showdateButton
            // 
            this.showdateButton.Location = new System.Drawing.Point(386, 67);
            this.showdateButton.Name = "showdateButton";
            this.showdateButton.Size = new System.Drawing.Size(75, 23);
            this.showdateButton.TabIndex = 7;
            this.showdateButton.Text = "Show Date";
            this.showdateButton.UseVisualStyleBackColor = true;
            this.showdateButton.Click += new System.EventHandler(this.showdateButton_Click);
            // 
            // studentListView
            // 
            this.studentListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.studentListView.GridLines = true;
            this.studentListView.Location = new System.Drawing.Point(286, 122);
            this.studentListView.Name = "studentListView";
            this.studentListView.Size = new System.Drawing.Size(392, 120);
            this.studentListView.TabIndex = 8;
            this.studentListView.UseCompatibleStateImageBehavior = false;
            this.studentListView.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "SEID";
            this.columnHeader1.Width = 108;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Name";
            this.columnHeader2.Width = 172;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Phone No";
            this.columnHeader3.Width = 103;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(296, 289);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(274, 186);
            this.listBox1.TabIndex = 9;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(495, 488);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 10;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(148, 289);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(142, 20);
            this.textBox1.TabIndex = 11;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(706, 523);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.studentListView);
            this.Controls.Add(this.showdateButton);
            this.Controls.Add(this.dateTimePicker);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.showdayButton);
            this.Controls.Add(this.dayComboBox);
            this.Controls.Add(this.showButton);
            this.Controls.Add(this.oddCheckBox);
            this.Controls.Add(this.evenCheckBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox evenCheckBox;
        private System.Windows.Forms.CheckBox oddCheckBox;
        private System.Windows.Forms.Button showButton;
        private System.Windows.Forms.ComboBox dayComboBox;
        private System.Windows.Forms.Button showdayButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button genderButton;
        private System.Windows.Forms.RadioButton FemaleRadioButton;
        private System.Windows.Forms.RadioButton maleRadioButton;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.Button showdateButton;
        private System.Windows.Forms.ListView studentListView;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
    }
}

