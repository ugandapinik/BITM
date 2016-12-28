using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SimpleShowButton {
    public partial class indeUI : System.Web.UI.Page {
        protected void Page_Load(object sender, EventArgs e) {

        }

        //protected void show_Click(object sender, EventArgs e) {
        //    Response.Write("Hello World");
        //}

        protected void show_Click(object sender, EventArgs e)
        {
            string fname = firstname.Text;
            string lname = lastname.Text;


            display_result.Text = "User Fullname: " + fname + " " + lname;
        }

    }
}