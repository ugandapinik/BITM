using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebHelloWorldApp {
    public partial class HelloWorld : System.Web.UI.Page {
        protected void Page_Load(object sender, EventArgs e) {

        }

        protected void saveButton_Click(object sender, EventArgs e)
        {
            string name = nameTextBox.Text;
            //ViewState["Name"] = name;
            ViewState.Add("Name",name);
            nameTextBox.Text = "";
        }

        protected void showButton_Click(object sender, EventArgs e)
        {
            showNameLabel.Text = ViewState["Name"].ToString();
        }
    }
}