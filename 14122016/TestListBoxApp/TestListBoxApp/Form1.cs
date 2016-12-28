using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestListBoxApp
{
    public partial class numberUIForm : Form
    {
        public numberUIForm()
        {
            InitializeComponent();
        }

        private void numberUIForm_Load(object sender, EventArgs e)
        {

        }

        private void addButton_Click(object sender, EventArgs e)
        {
            int number = Convert.ToInt32(numberTextBox.Text);
            for (int i = 1; i <= number; i++)
            {
                listBox1.Items.Add(i);
            }
            numberTextBox.Text = "";
        }
    }
}
