using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace StudentsViewStateWebApp {
    public partial class StudentsList : System.Web.UI.Page {
        protected void Page_Load(object sender, EventArgs e) {

        }

        protected void saveButton_Click(object sender, EventArgs e) {
            allStudentsListBox.Items.Clear();
            totalStudentLabel.Text = "";
            string name = nameTextBox.Text;
            nameTextBox.Text = "";
            List<string> studentsList = (List<string>)ViewState["name"];
            if (ViewState["name"] != null) {
                studentsList.Add(name);
            } else {
                List<string> students = new List<string>();
                students.Add(name);
                ViewState["name"] = students;
            }

        }

        protected void showAllButton_Click(object sender, EventArgs e) {
            allStudentsListBox.Items.Clear();
            List<string> studentsList = (List<string>)ViewState["name"];
            totalStudentLabel.Text = Convert.ToInt32(studentsList.Count()).ToString();
            foreach (var item in studentsList) {
                allStudentsListBox.Items.Add(item);
            }
            ViewState["name"] = null;
        }
    }
}