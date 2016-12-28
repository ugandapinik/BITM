using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DeskTopWinApp {
    public partial class Form1 : Form
    {
        private string name;
        public Form1() {
            InitializeComponent();
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            name = nameTextBox.Text;
            nameTextBox.Text = "";
        }

        private void Form1_Load(object sender, EventArgs e) {

        }

        private void showButton_Click(object sender, EventArgs e)
        {
            nameLabel.Text = name;
        }
    }
}
