using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WindowsFormsApp
{
    public partial class registrationForm : Form
    {
        public registrationForm()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void city_Click(object sender, EventArgs e)
        {

        }

        private void registrationForm_Load(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void register_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=E:\\COADING\\C-Sharp\\WindowsFormsApp\\registration_database.mdf;Integrated Security=True");
            con.Open();

            string quary = "";
            SqlCommand cmd = new SqlCommand(quary, con);
            cmd.ExecuteNonQuery();

            MessageBox.Show("Registered Successfully");


            con.Close();
        }

        private void radio_female_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radio_male_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void input_branch_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void input_paswword_TextChanged(object sender, EventArgs e)
        {

        }

        private void input_name_TextChanged(object sender, EventArgs e)
        {

        }

        private void gender_Click(object sender, EventArgs e)
        {

        }

        private void branch_Click(object sender, EventArgs e)
        {

        }

        private void name_Click(object sender, EventArgs e)
        {

        }
    }
}
