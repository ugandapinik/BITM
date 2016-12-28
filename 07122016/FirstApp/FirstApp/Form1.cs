using System;
using System.Windows.Forms;

namespace FirstApp {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e) {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //string firstName = FirstNameTextBox.Text;
            //string lastName = LastNameextBox.Text;
            //MessageBox.Show("Hello, "+firstName+" "+lastName+".");
            int firstNumber = Convert.ToInt32(FirstNumTextBox.Text);
            int secondNumber = Convert.ToInt32(SecondNumTextBox.Text);
            int sum = firstNumber + secondNumber;
            //MessageBox.Show("Result is :" + sum);
            MessageBox.Show(sum.ToString());
            FirstNumTextBox.Text = "";
            SecondNumTextBox.Text = "";

        }
    }
}
