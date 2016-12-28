using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SalaryCalculationWebApp {
    public partial class SalaryInfoUI : System.Web.UI.Page {
        protected void Page_Load(object sender, EventArgs e) {

        }

        private void ClearAll()
        {
            basicSalaryTextBox.Text = "";
            conveyanceTextBox.Text = "";
            houseRentTextBox.Text = "";
            totalSalaryLabel.Text = "";
            totalSalaryLabel.Text = "";
        }
        protected void saveButton_Click(object sender, EventArgs e)
        {
            Salary salaryInfo=new Salary();
            salaryInfo.basicSalary = Convert.ToDecimal(basicSalaryTextBox.Text);
            salaryInfo.conveyancePercentage = Convert.ToDecimal(conveyanceTextBox.Text);
            salaryInfo.houseRentPercentage = Convert.ToDecimal(houseRentTextBox.Text);
            ViewState["Salary"] = salaryInfo;
            ClearAll();
        }

        protected void showTotalSalaryButton_Click(object sender, EventArgs e)
        {
            Salary salaryInfo = (Salary) ViewState["Salary"];
            totalSalaryLabel.Text =salaryInfo.CalculateTotalSalary().ToString(".##");
        }
    }
}