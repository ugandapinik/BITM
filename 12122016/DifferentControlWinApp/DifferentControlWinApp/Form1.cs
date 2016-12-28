using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DifferentControlWinApp {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void showButton_Click(object sender, EventArgs e) {
            if (evenCheckBox.Checked && !oddCheckBox.Checked) {
                MessageBox.Show("Even", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            } else if (oddCheckBox.Checked && !evenCheckBox.Checked) {
                MessageBox.Show("Odd", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            } else if (oddCheckBox.Checked && evenCheckBox.Checked) {
                MessageBox.Show("Both", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            } else {
                MessageBox.Show("None", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadComboBox();
            LoadAllStudent();
        }

        private void LoadComboBox()
        {
            string[] days = new string[]
            {
                "Saturday","Sunday","Monday"
            };
            foreach (string day in days)
            {
                dayComboBox.Items.Add(day);
            }
            //dayComboBox.Items.AddRange(days);
        }

        private void showdayButton_Click(object sender, EventArgs e)
        {
            string selected = dayComboBox.Text;
            MessageBox.Show(selected);
        }

        private void genderButton_Click(object sender, EventArgs e) {
            if (maleRadioButton.Checked)
            {
                MessageBox.Show("Male");
            }
            else if (FemaleRadioButton.Checked) {
                MessageBox.Show("Female");
            }
        }

        private void showdateButton_Click(object sender, EventArgs e)
        {

            var date = dateTimePicker.Text;
            MessageBox.Show(date);
        }

        private void LoadAllStudent()
        {
            ListViewItem item=new ListViewItem();
            item.Text = "1234";
            item.SubItems.Add("Name");
            item.SubItems.Add("0145663");

            studentListView.Items.Add(item);
        }
    }
}
