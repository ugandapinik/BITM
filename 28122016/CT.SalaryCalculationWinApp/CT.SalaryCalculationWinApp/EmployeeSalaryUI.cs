using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CT.SalaryCalculationWinApp {
    public partial class EmployeeSalaryUI : Form {
        private Employee employee;
        private Salary salary;
        public EmployeeSalaryUI() {
            InitializeComponent();
        }

        private void ClearAll() {
            idTextBox.Text = "";
            nameTextBox.Text = "";
            emailTextBox.Text = "";
            basicSalaryTextBox.Text = "";
            medicalPercentageTextBox.Text = "";
            conveyancePercentageTextBox.Text = "";
            incrementPercentageTextBox.Text = "";

        }

        private void ClearSalaryInformation() {
            incrementNumberTextBox.Text = "";
            basicTextBox.Text = "";
            medicalTextBox.Text = "";
            conveyanceTextBox.Text = "";
            totalSalaryTextBox.Text = "";
        }
        private void EmployeeSalaryUI_Load(object sender, EventArgs e) {
            ClearAll();
            ClearSalaryInformation();
        }

        private void saveButton_Click(object sender, EventArgs e) {
            salary = new Salary();
            employee.EmployeeSalary = salary;

            employee.Id = idTextBox.Text;
            employee.Name = nameTextBox.Text;
            employee.Email = emailTextBox.Text;
            employee.EmployeeSalary.BasicSalary = Convert.ToDecimal(basicSalaryTextBox.Text);
            employee.EmployeeSalary.MedicalPercentage = Convert.ToDecimal(medicalPercentageTextBox.Text);
            employee.EmployeeSalary.ConveyancePercentage = Convert.ToDecimal(conveyancePercentageTextBox.Text);

            idTextBox.ReadOnly = true;
            nameTextBox.ReadOnly = true;
            emailTextBox.ReadOnly = true;
            basicSalaryTextBox.ReadOnly = true;
            medicalPercentageTextBox.ReadOnly = true;
            conveyancePercentageTextBox.ReadOnly = true;
            saveButton.Enabled = false;
        }

        private void incrementButton_Click(object sender, EventArgs e) {
            if (Convert.ToDecimal(incrementPercentageTextBox.Text) <= Convert.ToDecimal(0)) {
                MessageBox.Show("Increment amount should me greater than 0.", "Information!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            } else {
                basicSalaryTextBox.Text = salary.IncrementSalary(Convert.ToDecimal(incrementPercentageTextBox.Text)).ToString(".##");
            }
        }

        private void showButton_Click(object sender, EventArgs e) {
            if (salary != null) {
                incrementNumberTextBox.Text = employee.EmployeeSalary.NoOfIncrement.ToString();
                basicTextBox.Text = employee.EmployeeSalary.BasicSalary.ToString();
                medicalTextBox.Text = employee.EmployeeSalary.MedicalOfBasic.ToString();
                conveyanceTextBox.Text = employee.EmployeeSalary.ConveyanceOfBasic.ToString();
                totalSalaryTextBox.Text = employee.EmployeeSalary.TotalSalary.ToString();
            }
        }
    }
}
