using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BasicInfo_App
{
    public partial class basicsalaryinformationForm : Form
    {
        private string name;
        private decimal Bsalary;
        private decimal Mallowan;
        private decimal Oallowan;
        private decimal total;
        public basicsalaryinformationForm()
        {
            InitializeComponent();
        }
        private void showButton_Click(object sender, EventArgs e)
        {
            name = nametextBox.Text;
            Bsalary = Convert.ToDecimal(basicSalarytextBox.Text);
            decimal mall = Bsalary * 5 / 100;
            decimal Oallowa = Bsalary * 7 / 100;
            total = Bsalary + mall + Oallowa;
            medicalAllowancetextBox.Text = Convert.ToInt32(mall).ToString();
            otherAllowancetextBox.Text = Convert.ToInt32(Oallowa).ToString();
            totalSalarytextBox.Text = Convert.ToDecimal(total).ToString();
            MessageBox.Show("Your Salary Amount: " + total);
        }

        private void basicsalaryinformationForm_Load(object sender, EventArgs e)
        {

        }
    }
}
