using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp
{
    public partial class calculator : Form
    {
        double first_number, second_number, result;
        string operation = " ";

        public calculator()
        {
            InitializeComponent();
        }

        private void button_0_Click(object sender, EventArgs e)
        {
            if (richTextBox.Text == "0" && richTextBox.Text != null)
            {
                richTextBox.Text = "0";
            }
            else
            {
                richTextBox.Text += "0";
            }

        }
        private void button_1_Click(object sender, EventArgs e)
        {
            if (richTextBox.Text == "0" && richTextBox.Text != null)
            {
                richTextBox.Text = "1";
            }
            else
            {
                richTextBox.Text += "1";
            }
        }
        private void button_2_Click(object sender, EventArgs e)
        {
            if (richTextBox.Text == "0" && richTextBox.Text != null)
            {
                richTextBox.Text = "2";
            }
            else
            {
                richTextBox.Text += "2";
            }

        }
        private void button_3_Click(object sender, EventArgs e)
        {
            if (richTextBox.Text == "0" && richTextBox.Text != null)
            {
                richTextBox.Text = "3";
            }
            else
            {
                richTextBox.Text += "3";
            }
        }
        private void button_4_Click(object sender, EventArgs e)
        {
            if (richTextBox.Text == "0" && richTextBox.Text != null)
            {
                richTextBox.Text = "4";
            }
            else
            {
                richTextBox.Text += "4";
            }
        }

        private void button_5_Click(object sender, EventArgs e)
        {
            if (richTextBox.Text == "0" && richTextBox.Text != null)
            {
                richTextBox.Text = "5";
            }
            else
            {
                richTextBox.Text += "5";
            }
        }

        private void button_6_Click(object sender, EventArgs e)
        {
            if (richTextBox.Text == "0" && richTextBox.Text != null)
            {
                richTextBox.Text = "6";
            }
            else
            {
                richTextBox.Text += "6";
            }
        }

        private void button_7_Click(object sender, EventArgs e)
        {
            if (richTextBox.Text == "0" && richTextBox.Text != null)
            {
                richTextBox.Text = "7";
            }
            else
            {
                richTextBox.Text += "7";
            }
        }

        private void button_8_Click(object sender, EventArgs e)
        {
            if (richTextBox.Text == "0" && richTextBox.Text != null)
            {
                richTextBox.Text = "8";
            }
            else
            {
                richTextBox.Text += "8";
            }
        }

        private void button_9_Click(object sender, EventArgs e)
        {
            if (richTextBox.Text == "0" && richTextBox.Text != null)
            {
                richTextBox.Text = "9";
            }
            else
            {
                richTextBox.Text += "9";
            }
        }

        private void calculator_Load(object sender, EventArgs e)
        {

        }

        private void backspace_Click(object sender, EventArgs e)
        {

        }

        private void division_Click(object sender, EventArgs e)
        {

        }

        private void calculate_Click(object sender, EventArgs e)
        {
            second_number = Convert.ToDouble(richTextBox.Text);
            if (operation == "+")
            {
                richTextBox.Text = (first_number + second_number).ToString();
            }
            else if (operation == "-")
            {
                richTextBox.Text = (first_number - second_number).ToString();
            }
            else if (operation == "*")
            {
                richTextBox.Text = (first_number * second_number).ToString();
            }
            else if (operation == "/")
            {
                richTextBox.Text = (first_number / second_number).ToString();
            }
            else if (operation == "%")
            {
                richTextBox.Text = (first_number/100).ToString();
            }
        }

        private void clear_Click(object sender, EventArgs e)
        {

        }

        private void plus_or_minus_Click(object sender, EventArgs e)
        {

        }

        private void add_Click(object sender, EventArgs e)
        {
            first_number = Convert.ToDouble(richTextBox.Text);
            richTextBox.Text = "0";
            operation = "+";
        }

        private void subtract_Click(object sender, EventArgs e)
        {
            first_number = Convert.ToDouble(richTextBox.Text);
            richTextBox.Text = "0";
            operation = "-";
        }

        private void multiply_Click(object sender, EventArgs e)
        {
            first_number = Convert.ToDouble(richTextBox.Text);
            richTextBox.Text = "0";
            operation = "*";
        }

        private void button_percentage_Click(object sender, EventArgs e)
        {
            first_number = Convert.ToDouble(richTextBox.Text);
            richTextBox.Text = "0";
            operation = "%";
        }

        private void button_dot_Click(object sender, EventArgs e)
        {
            if (richTextBox.Text == "0" && richTextBox.Text != null)
            {
                richTextBox.Text = "0.";
            }
            else
            {
                richTextBox.Text += ".";
            }
        }

        private void richTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
