using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsForm
{
    public partial class Q6 : Form
    {
        public Q6()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add("Education");
            listBox1.Items.Add("Food for All");
            listBox1.Items.Add("Freedom of speech");
            listBox1.Items.Add("Good Books");
            listBox1.Items.Add("Good Movies");

        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Sorted = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            listBox1.Items.Remove(listBox1.SelectedItems);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            label1.Text = "Display total items : ";
            label1.Text += listBox1.Items.Count;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {
            
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
