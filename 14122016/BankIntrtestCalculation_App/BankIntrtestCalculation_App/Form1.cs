using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankIntrtestCalculation_App
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Calculatebutton_Click(object sender, EventArgs e)
        {
            decimal time=0;
            string nam = "";
            nam = bankNameComboBox.GetItemText(bankNameComboBox.SelectedIndex);
            time = Convert.ToDecimal(timeTextBox.Text);
            decimal blnc = Convert.ToDecimal(BalancetextBox.Text);

            if (bankNameComboBox.SelectedIndex == 0 && (time == 2 || time==1))
            {
                decimal Br = (blnc * 5 / 100)/time;
                decimal totint = Convert.ToDecimal(blnc) + Convert.ToDecimal(Br);
                Interest.Text = Convert.ToDecimal(totint).ToString();
            }
            else if (bankNameComboBox.SelectedIndex == 1 && (time == 2 || time == 1))
            {
                decimal Br = blnc * 8 / 100 / time;
                decimal totint = Convert.ToDecimal(blnc) + Convert.ToDecimal(Br);
                Interest.Text = Convert.ToDecimal(totint).ToString();
            }
            else if (bankNameComboBox.SelectedIndex == 2 && (time == 2 || time == 1))
            {
                decimal Br = blnc * 9 / 100 / time;
                decimal totint = Convert.ToDecimal(blnc) + Convert.ToDecimal(Br);
                Interest.Text = Convert.ToDecimal(totint).ToString();
            }
            else
            {
                MessageBox.Show("Enter Time less then 3");
                return;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string[] bank = new string[3];
            bank[0] = "BRAC 5%";
            bank[1] = "HSBC 8%";
            bank[2] = "DBBL 9%";
            foreach (string item in bank)
            {
                bankNameComboBox.Items.Add(item);
            }
        }

        private void bankNameComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            //string nam = "";
            //nam = bankNameComboBox.GetItemText(bankNameComboBox.SelectedIndex);
            //MessageBox.Show(nam);
            //if (bankNameComboBox.SelectedIndex == 0)
            //{
            //    decimal blnc=Convert.ToDecimal(BalancetextBox.Text);
            //    decimal Br = blnc * 5 / 100;
            //    MessageBox.Show(Convert.ToDecimal(Br).ToString());
            //}




        }
    }
}
