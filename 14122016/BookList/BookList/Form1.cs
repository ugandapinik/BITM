using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookList
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string[] book = new string[3];
        private void Form1_Load(object sender, EventArgs e)
        {
            LoadCombobox();
        }

        private void showButton_Click(object sender, EventArgs e)
        {
            string myText = "";
            myText = bookNameComboBox.GetItemText(bookNameComboBox.SelectedIndex);
            MessageBox.Show(myText);
        }

        private void LoadCombobox()
        {
            string[] book = new string[3];
            book[0] = "Bangla";
            book[1] = "English";
            book[2] = "Math";

            foreach (string item in book)
            {
                bookNameComboBox.Items.Add(item);
            }
            

        }
    }
}
