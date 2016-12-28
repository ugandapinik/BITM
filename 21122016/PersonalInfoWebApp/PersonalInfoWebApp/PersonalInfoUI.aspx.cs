using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PersonalInfoWebApp {
    public partial class PersonalInfoUI : System.Web.UI.Page {

        protected void Page_Load(object sender, EventArgs e) {

        }

        private void ClearAll() {
            firstNameTextBox.Text = "";
            lastNameTextBox.Text = "";
            fatherNameTextBox.Text = "";
            motherNameTextBox.Text = "";
            addressTextBox.Text = "";
            saveButton.Text = "Save";
        }
        protected void saveButton_Click(object sender, EventArgs e) {

            if (saveButton.Text == "Save")
            {
                Person personInfo = new Person();
                personInfo.firstName = firstNameTextBox.Text;
                personInfo.lastName = lastNameTextBox.Text;
                personInfo.fatherName = fatherNameTextBox.Text;
                personInfo.motherName = motherNameTextBox.Text;
                personInfo.address = addressTextBox.Text;
                ClearAll();
                ViewState["person"] = personInfo;
                saveButton.Text = "Clear";
            }
            else
            {
                ClearAll();
            }

        }

        protected void nameButton_Click(object sender, EventArgs e) {
            ClearAll();
            Person personInfo =(Person)ViewState["person"];
            firstNameTextBox.Text= personInfo.firstName ;
            lastNameTextBox.Text = personInfo.lastName; 
            saveButton.Text = "Clear";
        }

        protected void showAllButton_Click(object sender, EventArgs e) {
            ClearAll();
            Person personInfo = (Person)ViewState["person"];
            firstNameTextBox.Text = personInfo.firstName;
            lastNameTextBox.Text = personInfo.lastName;
            fatherNameTextBox.Text = personInfo.fatherName;
            motherNameTextBox.Text = personInfo.motherName;
            addressTextBox.Text = personInfo.address; 
            saveButton.Text = "Clear";
        }

        protected void parentsButton_Click(object sender, EventArgs e) {
            ClearAll();
            Person personInfo = (Person)ViewState["person"];
            fatherNameTextBox.Text = personInfo.fatherName;
            motherNameTextBox.Text = personInfo.motherName;
            saveButton.Text = "Clear";
        }

        protected void addressButton_Click(object sender, EventArgs e) {
            ClearAll();
            Person personInfo = (Person)ViewState["person"];
            addressTextBox.Text = personInfo.address;
            saveButton.Text = "Clear";
        }
    }
}