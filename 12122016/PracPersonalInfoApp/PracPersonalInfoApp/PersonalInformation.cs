using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PracPersonalInfoApp {
    public partial class FormPersonalInfo : Form
    {
        private string firstName = "";
        private string lastName = "";
        private string fatherName = "";
        private string motherName = "";
        private string address = "";

        public FormPersonalInfo() {
            InitializeComponent();
        }

        private void ClearAll()
        {

            firstnameTextBox.Text = "";
            lastnameTextBox.Text = "";
            fatherTextBox.Text = "";
            motherTextBox.Text = "";
            addressTextBox.Text = "";
            firstnameTextBox.Focus();
        }
        private void FormPersonalInfo_Load(object sender, EventArgs e)
        {
            ClearAll();
        }

        private void saveButton_Click(object sender, EventArgs e) {

            firstName = firstnameTextBox.Text;
            lastName = lastnameTextBox.Text;
            fatherName = fatherTextBox.Text;
            motherName = motherTextBox.Text;
            address = addressTextBox.Text;
            ClearAll();
        }

        private void showButton_Click(object sender, EventArgs e) {
            ClearAll();
            firstnameTextBox.Text = firstName;
            lastnameTextBox.Text=lastName ;
            fatherTextBox.Text= fatherName ;
            motherTextBox.Text = motherName;
            addressTextBox.Text= address ;
        }

        private void nameButton_Click(object sender, EventArgs e) {
            ClearAll();
            firstnameTextBox.Text = firstName;
            lastnameTextBox.Text = lastName;
        }

        private void parentButton_Click(object sender, EventArgs e) {
            ClearAll();
            fatherTextBox.Text = fatherName;
            motherTextBox.Text = motherName;
        }

        private void addressButton_Click(object sender, EventArgs e) {
            ClearAll();
            addressTextBox.Text = address;
        }
    }
}
