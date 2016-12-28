using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace UnitPriceWebApp {
    public partial class UnitPrice : System.Web.UI.Page {
        protected void Page_Load(object sender, EventArgs e) {

        }

        protected void saveButton_Click(object sender, EventArgs e)
        {
            totalPriceLabel.Text = "";
            ViewState["ItemNumber"] = Convert.ToInt16(itemNumberTextBox.Text);
            ViewState["UnitPrice"] = Convert.ToDecimal(unitPriceTextBox.Text);
            itemNumberTextBox.Text = "";
            unitPriceTextBox.Text = "";
        }

        protected void totalPriceButton_Click(object sender, EventArgs e)
        {
            totalPriceLabel.Text =Convert.ToDecimal(Convert.ToInt16(ViewState["ItemNumber"])*Convert.ToDecimal(ViewState["UnitPrice"])).ToString();
        }
    }
}