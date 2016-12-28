using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace StudentInformationWebApp {
    public partial class StudentInfo : System.Web.UI.Page {
        protected void Page_Load(object sender, EventArgs e) {

        }

        private void ClearAll()
        {
            regNoTextBox.Text = "";
            studNameTextBox.Text = "";
            studEmailTextBox.Text = "";

            regTextBox.Text = "";
            nameTextBox.Text = "";
            emailTextBox.Text = "";
            saveButton.Text = "Save";
        }
        protected void saveButton_Click(object sender, EventArgs e) {
            if (saveButton.Text == "Save")
            {
                Student studentInfo = new Student();
                studentInfo.studentRegNo = regNoTextBox.Text;
                studentInfo.studentName = studNameTextBox.Text;
                studentInfo.studenEemail = studEmailTextBox.Text;
                ClearAll();
                ViewState["Student"] = studentInfo;
                saveButton.Text = "Clear";
            }
            else
            {
                ClearAll();
            }
        }

        protected void showButton_Click(object sender, EventArgs e) {
            ClearAll();
            Student studentInfo = (Student) ViewState["Student"];
            regTextBox.Text = studentInfo.studentRegNo;
            nameTextBox.Text = studentInfo.studentName;
            emailTextBox.Text = studentInfo.studenEemail;
            saveButton.Text = "Clear";


        }
    }
}