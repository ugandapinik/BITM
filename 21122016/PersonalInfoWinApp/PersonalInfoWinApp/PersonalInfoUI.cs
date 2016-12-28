using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PersonalInfoWinApp {
    public partial class PersonalInfoUI : Form {
        public PersonalInfoUI() {
            InitializeComponent();
        }
        Person personInfo=new Person();
        private void ClearAll()
        {
            firstNameTextBox.Text = "";
            lastNameTextBox.Text = "";
            fatherNameTextBox.Text = "";
            motherNameTextBox.Text = "";
            addressTextBox.Text = "";
            firstNameTextBox.Focus();
        }
        private void PersonalInfoUI_Load(object sender, EventArgs e) {
            ClearAll();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            personInfo.firstName = firstNameTextBox.Text;
            personInfo.lastName = lastNameTextBox.Text;
            personInfo.fatherName = fatherNameTextBox.Text;
            personInfo.motherName = motherNameTextBox.Text;
            personInfo.address = addressTextBox.Text;
            ClearAll();
        }

        private void showAllButton_Click(object sender, EventArgs e)
        {
            ClearAll();
            firstNameTextBox.Text = personInfo.firstName;
            lastNameTextBox.Text = personInfo.lastName;
            fatherNameTextBox.Text = personInfo.fatherName;
            motherNameTextBox.Text = personInfo.motherName;
            addressTextBox.Text = personInfo.address;
        }

        private void nameButton_Click(object sender, EventArgs e) {
            ClearAll();
            firstNameTextBox.Text = personInfo.firstName;
            lastNameTextBox.Text = personInfo.lastName;
        }

        private void parentsNameButton_Click(object sender, EventArgs e) {
            ClearAll();
            fatherNameTextBox.Text = personInfo.fatherName;
            motherNameTextBox.Text = personInfo.motherName;
        }

        private void addressButton_Click(object sender, EventArgs e) {
            ClearAll();
            addressTextBox.Text = personInfo.address;
        }
    }
}
