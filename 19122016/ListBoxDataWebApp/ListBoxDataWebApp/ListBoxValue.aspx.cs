using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ListBoxDataWebApp {
    public partial class ListBoxValue : System.Web.UI.Page {
        protected void Page_Load(object sender, EventArgs e) {

        }

        protected void showButton_Click(object sender, EventArgs e)
        {
            valueListBox.Items.Clear();
            int inputValue = Convert.ToInt16(inputValueTextBox.Text);
            inputValueTextBox.Text = "";
            
            for (int i = 1; i <= inputValue; i++)
            {
                valueListBox.Items.Add(i.ToString());
            }
        }
    }
}