using System;
using System.Windows.Forms;
namespace TDDApplication
{
    public partial class Calculator : Form
    {
        public Calculator()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                var NUM1 = int.TryParse(textBoxNum1.Text, out int Num1);
                var NUM2 = int.TryParse(textBoxNum2.Text, out int Num2);
                var total = Addition(Num1, Num2);
                textBoxTotal.Text = total.ToString();
            }
            catch (Exception)
            {

                textBoxTotal.Text = "something went wrong";
            }
            
        }
        public int Addition(int Num1, int Num2)
        {
            var total = Num1 + Num2;
            return total;
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}