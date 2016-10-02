using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace trwCh12Ex7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                string input = "";
                int number1 = 0;
                int number2 = 0;

                input = textBox1.Text;
                number1 = int.Parse(input);
                input = textBox2.Text;
                number2 = int.Parse(input);

                textBox3.Text = Convert.ToString(number1 * number2);
            }
            catch (System.FormatException)
            {
                label4.Text = "Please enter a number only !";
                System.Threading.Thread.Sleep(3000);
                label4.Text = "RESULT:";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string input = "";
                int number1 = 0;
                int number2 = 0;

                input = textBox1.Text;
                number1 = int.Parse(input);
                input = textBox2.Text;
                number2 = int.Parse(input);

                textBox3.Text = Convert.ToString(number1 + number2);
            }
            catch (System.FormatException)
            {
                label4.Text = "Please enter a number only !";
                System.Threading.Thread.Sleep(3000);
                label4.Text = "RESULT:";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                string input = "";
                int number1 = 0;
                int number2 = 0;

                input = textBox1.Text;
                number1 = int.Parse(input);
                input = textBox2.Text;
                number2 = int.Parse(input);

                textBox3.Text = Convert.ToString(number1 - number2);
            }
            catch (System.FormatException)
            {
                label4.Text = "Please enter a number only !";
                System.Threading.Thread.Sleep(3000);
                label4.Text = "RESULT:";
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                string input = "";
                int number1 = 0;
                int number2 = 0;

                input = textBox1.Text;
                number1 = int.Parse(input);
                input = textBox2.Text;
                number2 = int.Parse(input);

                textBox3.Text = Convert.ToString(number1 / number2);
            }
            catch (System.DivideByZeroException)
            {
                label4.Text = "Can't Divide by Zero!";
                goToDelay();
                label4.Text = "RESULT:";
            }
            catch (System.FormatException)
            {
                label4.Text = "Please enter a number only !";
                System.Threading.Thread.Sleep(3000);
                label4.Text = "RESULT:";
            }
        }

        public static void goToDelay()
    {
        System.Threading.Thread.Sleep(3000);
    }
    }
}
