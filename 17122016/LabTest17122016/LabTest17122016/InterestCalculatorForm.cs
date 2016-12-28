using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LabTest17122016 {
    public partial class InterestCalculatorForm : Form {
        double principalAmount = Convert.ToDouble(0);
        double interestRate = Convert.ToDouble(0);
        double futureTotalAmount = Convert.ToDouble(0);
        int compoundInterest = 0;
        int yearstoGrow = 0;
        public InterestCalculatorForm() {
            InitializeComponent();
        }

        private void InterestCalculatorForm_Load(object sender, EventArgs e) {
            ClearAll();
        }

        private void ClearAll() {
            principalAmountTextBox.Text = "";
            interestRateTextBox.Text = "";
            yearsToGoTextBox.Text = "";
            compoundInterestTextBox.Text = "";
            futureTotalTextBox.Text = "";
            CalculateButton.Text = "Calculate";
        }

        private void CalculateButton_Click(object sender, EventArgs e)
        {
            if (CalculateButton.Text == "Clear")
            {
                ClearAll();
                CalculateButton.Text = "Calculate";
            }
            else
            {
                principalAmount = Convert.ToDouble(principalAmountTextBox.Text);
                compoundInterest = Convert.ToInt32(compoundInterestTextBox.Text);
                interestRate = Convert.ToDouble(interestRateTextBox.Text);
                yearstoGrow = Convert.ToInt32(yearsToGoTextBox.Text);
                int n = compoundInterest*yearstoGrow;
                double interest = Convert.ToDouble(0);
                double compinterest = (1 + interestRate/100/4);
                interest = Math.Pow(compinterest, n);
                interest = principalAmount*interest;
                futureTotalTextBox.Text = interest.ToString(".##");
                CalculateButton.Text = "Clear";
            }
        }
    }
}
