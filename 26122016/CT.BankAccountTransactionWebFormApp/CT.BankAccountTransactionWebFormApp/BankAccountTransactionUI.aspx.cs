using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CT.BankAccountTransactionWebFormApp {
    public partial class BankAccountTransactionUI : System.Web.UI.Page {
        protected void Page_Load(object sender, EventArgs e) {

        }

        protected void createButton_Click(object sender, EventArgs e) {
            Account account = new Account();
            account.AccountNumber = accountNumberTextBox.Text;
            account.CustomerName = customerNameTextBox.Text;
            ViewState["Account"] = account;
            accountNumberTextBox.Text = "";
            customerNameTextBox.Text = "";
        }

        protected void depositButton_Click(object sender, EventArgs e) {

            reportLabel.Text = "";
            messageLabel.Text = "";

            decimal depositAmount = Convert.ToDecimal(amountTextBox.Text);

            if (depositAmount <= Convert.ToDecimal(0)) {
                messageLabel.Text = "Enter amount.";
                return;
            }

            Account account = (Account)ViewState["Account"];

            if (account == null) {
                messageLabel.Text = "Create Account First";
                return;
            } else {
                messageLabel.Text = "";
                account.DepositAmount(depositAmount);
                amountTextBox.Text = "";
            }
        }

        protected void withdrawButton_Click(object sender, EventArgs e) {

            reportLabel.Text = "";
            messageLabel.Text = "";

            decimal withdrawAmount = Convert.ToDecimal(amountTextBox.Text);

            if (withdrawAmount <= Convert.ToDecimal(0)) {
                messageLabel.Text = "Enter amount.";
                return;
            }

            Account account = (Account)ViewState["Account"];

            if (account.Balance < withdrawAmount) {
                messageLabel.Text = "Withdrawal amount canot be greater than present balance.";
                return;
            } 
            else {
                messageLabel.Text = "";
                account.WithdrawAmount(withdrawAmount);
                amountTextBox.Text = "";
            }

        }

        protected void showReoportButton_Click(object sender, EventArgs e) {

            Account account = (Account)ViewState["Account"];

            reportLabel.Text = account.CustomerName + ", your account number is " + account.AccountNumber +
                               " and your balance is: " + account.Balance;
        }
    }
}