namespace Test
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
            this.showButton = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.totaltextBox = new System.Windows.Forms.TextBox();
            this.NoofTicketstextBox = new System.Windows.Forms.TextBox();
            this.UnitPricetextBox = new System.Windows.Forms.TextBox();
            this.nametextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Detailsbutton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // showButton
            // 
            this.showButton.Location = new System.Drawing.Point(161, 180);
            this.showButton.Name = "showButton";
            this.showButton.Size = new System.Drawing.Size(75, 23);
            this.showButton.TabIndex = 24;
            this.showButton.Text = "Show";
            this.showButton.UseVisualStyleBackColor = true;
            this.showButton.Click += new System.EventHandler(this.showButton_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(104, 133);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 13);
            this.label5.TabIndex = 23;
            this.label5.Text = "Total";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(61, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 13);
            this.label3.TabIndex = 21;
            this.label3.Text = "No. of Tickets";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(82, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 20;
            this.label2.Text = "Unit Price";
            // 
            // totaltextBox
            // 
            this.totaltextBox.Location = new System.Drawing.Point(152, 129);
            this.totaltextBox.Name = "totaltextBox";
            this.totaltextBox.Size = new System.Drawing.Size(189, 20);
            this.totaltextBox.TabIndex = 19;
            // 
            // NoofTicketstextBox
            // 
            this.NoofTicketstextBox.Location = new System.Drawing.Point(152, 77);
            this.NoofTicketstextBox.Name = "NoofTicketstextBox";
            this.NoofTicketstextBox.Size = new System.Drawing.Size(189, 20);
            this.NoofTicketstextBox.TabIndex = 17;
            // 
            // UnitPricetextBox
            // 
            this.UnitPricetextBox.Location = new System.Drawing.Point(152, 103);
            this.UnitPricetextBox.Name = "UnitPricetextBox";
            this.UnitPricetextBox.Size = new System.Drawing.Size(189, 20);
            this.UnitPricetextBox.TabIndex = 16;
            // 
            // nametextBox
            // 
            this.nametextBox.Location = new System.Drawing.Point(152, 51);
            this.nametextBox.Name = "nametextBox";
            this.nametextBox.Size = new System.Drawing.Size(189, 20);
            this.nametextBox.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(100, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Name";
            // 
            // Detailsbutton
            // 
            this.Detailsbutton.Location = new System.Drawing.Point(242, 180);
            this.Detailsbutton.Name = "Detailsbutton";
            this.Detailsbutton.Size = new System.Drawing.Size(75, 23);
            this.Detailsbutton.TabIndex = 25;
            this.Detailsbutton.Text = "Details";
            this.Detailsbutton.UseVisualStyleBackColor = true;
            this.Detailsbutton.Click += new System.EventHandler(this.Detailsbutton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(581, 422);
            this.Controls.Add(this.Detailsbutton);
            this.Controls.Add(this.showButton);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.totaltextBox);
            this.Controls.Add(this.NoofTicketstextBox);
            this.Controls.Add(this.UnitPricetextBox);
            this.Controls.Add(this.nametextBox);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button showButton;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox totaltextBox;
        private System.Windows.Forms.TextBox NoofTicketstextBox;
        private System.Windows.Forms.TextBox UnitPricetextBox;
        private System.Windows.Forms.TextBox nametextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Detailsbutton;
    }
}

