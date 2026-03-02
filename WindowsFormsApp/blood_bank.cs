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
    public partial class blood_bank : Form
    {
        public blood_bank()
        {
            InitializeComponent();
        }

        private void nameTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=E:\COADING\C-Sharp\WindowsFormsApp\blood_bank.mdf;Integrated Security=True");

            con.Open();

            String query = "INSERT INTO blood_bank(name, email, blood_group, number, address) VALUES(@name, @email, @blood_group, @number, @address) ";

            SqlCommand cmd = new SqlCommand(query, con);

            cmd.Parameters.AddWithValue("@name", nameTextBox.Text);
            cmd.Parameters.AddWithValue("@email", emailTextBox.Text);
            cmd.Parameters.AddWithValue("@blood_group", comboBox1.SelectedText);
            cmd.Parameters.AddWithValue("@number", NumTextBox.Text);
            cmd.Parameters.AddWithValue("@address", addressRichTextBox.Text);

            cmd.ExecuteNonQuery();

            con.Close();

            MessageBox.Show("Data Inserted Successfully", "Record Added");

            nameTextBox.Text = "";
            emailTextBox.Text = "";
            NumTextBox.Text = "";
            addressRichTextBox.Text = "";

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void addressRichTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=E:\COADING\C-Sharp\WindowsFormsApp\blood_bank.mdf;Integrated Security=True");

            con.Open();

            String query = "UPDATE blood_bank SET name=@name, blood_group=@blood_group, number=@number, address=@address WHERE email=@email";

            SqlCommand cmd = new SqlCommand(query, con);

            cmd.Parameters.AddWithValue("@name", nameTextBox.Text);
            cmd.Parameters.AddWithValue("@email", emailTextBox.Text);
            cmd.Parameters.AddWithValue("@blood_group", comboBox1.SelectedText);
            cmd.Parameters.AddWithValue("@number", NumTextBox.Text);
            cmd.Parameters.AddWithValue("@address", addressRichTextBox.Text);

            cmd.ExecuteNonQuery();

            con.Close();

            MessageBox.Show("Data Updated Successfully", "Record Updated");

            nameTextBox.Text = "";
            emailTextBox.Text = "";
            NumTextBox.Text = "";
            addressRichTextBox.Text = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=E:\COADING\C-Sharp\WindowsFormsApp\blood_bank.mdf;Integrated Security=True");
            con.Open();

            string query = "DELETE FROM blood_bank WHERE email=@email";

            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@email", emailTextBox.Text);

            cmd.ExecuteNonQuery();
            con.Close();

            MessageBox.Show("Data Deleted Successfully", "Deletion");

            emailTextBox.Text = "";
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            string query = "SELECT * FROM blood_bank";

            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=E:\COADING\C-Sharp\WindowsFormsApp\blood_bank.mdf;Integrated Security=True");
            con.Open();

          
            SqlDataAdapter da = new SqlDataAdapter(query, con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
          
        }

    }
}
