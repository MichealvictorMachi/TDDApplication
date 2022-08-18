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
                var Num1 = Int32.Parse(textBoxNum1.Text);
                var Num2 = Int32.Parse(textBoxNum2.Text);
                textBoxTotal.Text = (Addition(Num1, Num2)).ToString();

               
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