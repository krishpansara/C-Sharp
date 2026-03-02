using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp
{
    public partial class student_form : Form
    {
        public student_form()
        {
            InitializeComponent();
        }

        private void txtAge_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string conStr = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=E:\\COADING\\C-Sharp\\WindowsFormsApp\\student_database.mdf;Integrated Security=True";
            SqlConnection con = new SqlConnection(conStr);
            con.Open();

            string query = "DELETE FROM Student WHERE EnrlNo=@EnrlNo";

            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@EnrlNo", txtEnrlNo.Text);

            cmd.ExecuteNonQuery();
            con.Close();

            MessageBox.Show("Data Deleted Successfully", "Deletion");

            txtEnrlNo.Text = "";

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string conStr = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=E:\\COADING\\C-Sharp\\WindowsFormsApp\\student_database.mdf;Integrated Security=True";
            SqlConnection con = new SqlConnection(conStr);
            con.Open();

            string query = "UPDATE Student SET ";

            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@EnrlNo", txtEnrlNo.Text);

            cmd.ExecuteNonQuery();
            con.Close();

            MessageBox.Show("Data Updated Successfully", "Update");

            txtEnrlNo.Text = "";
            txtName.Text = "";
            txtAge.Text = "";
            txtCity.Text = "";
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            string conStr = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=E:\\COADING\\C-Sharp\\WindowsFormsApp\\student_database.mdf;Integrated Security=True";
            //string conStr2 = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=E:\COADING\C-Sharp\WindowsFormsApp\student_database.mdf;Integrated Security=True"
            SqlConnection con = new SqlConnection(conStr);
            con.Open();

            string query = "INSERT INTO Student(EnrlNo, name, age, city) VALUES(@EnrlNo, @name, @age, @city) ";

            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@EnrlNo", txtEnrlNo.Text);
            cmd.Parameters.AddWithValue("@name", txtName.Text);
            cmd.Parameters.AddWithValue("@age", txtAge.Text);
            cmd.Parameters.AddWithValue("@city", txtCity.Text);

            cmd.ExecuteNonQuery();
            con.Close();

            MessageBox.Show("Data Inserted Successfully", "Insertion");

            txtEnrlNo.Text = "";
            txtName.Text = "";
            txtAge.Text = "";
            txtCity.Text = "";

        }

        private void txtCity_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnReset_Click(object sender, EventArgs e)
        {

        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtEnrlNo_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
