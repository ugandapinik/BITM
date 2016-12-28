using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test
{
    public partial class Form1 : Form
    {
        private string name;
        private int numtk;
        private decimal unit;
        private decimal total;
        private decimal Gtot;
        public Form1()
        {
            InitializeComponent();
        }
        private void showButton_Click(object sender, EventArgs e)
        {
            name = nametextBox.Text;
            numtk = Convert.ToInt32(NoofTicketstextBox.Text);
            unit = Convert.ToDecimal(UnitPricetextBox.Text);
            Gtot = numtk * unit;
            totaltextBox.Text = Convert.ToInt32(Gtot).ToString();
            MessageBox.Show("' " + name + "' " + " Please pay " + "' " + Gtot + "' " + " tk to purchase " + "' " + numtk  +"' " + " Ticket");
        }

        private void Detailsbutton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Name: " + name + Environment.NewLine + "Ticket no: " + numtk + Environment.NewLine + "Per Unit: " + unit + Environment.NewLine + "Total tk: " + Gtot);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
