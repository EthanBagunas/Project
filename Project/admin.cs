using MySql.Data.MySqlClient;
using MySqlX.XDevAPI.Relational;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project
{
    public partial class admin : Form
    {
        string conn = "server=localhost;user id=root; password=rootpass; database=hotel";

        public admin()
        {
            InitializeComponent();

        }

        DataTable dTable = new DataTable();


        private void Load_Click(object sender, EventArgs e)
        {
            dTable.Clear();
            dTable.Columns.Clear();
            try
            {
                string table1 = comboBox1.SelectedItem.ToString();
                string Query = "SELECT * FROM " + table1;
                MySqlConnection myconn = new MySqlConnection(conn);
                MySqlCommand cmd = new MySqlCommand(Query, myconn);
                MySqlDataAdapter MyAdapter = new MySqlDataAdapter();
                MyAdapter.SelectCommand = cmd;

                dataGridView1.DataSource = null;
                MyAdapter.Fill(dTable);
                dataGridView1.DataSource = dTable;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }




        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string table1 = comboBox1.SelectedItem.ToString();
            MySqlConnection connection = new MySqlConnection(conn);
            connection.Open();

            // Create a new SqlDataAdapter with a SELECT statement to get the existing data
            MySqlDataAdapter adapter = new MySqlDataAdapter("SELECT * FROM " + table1, connection);

            // Create a new SqlCommandBuilder to generate the UPDATE statement based on the SELECT statement
            MySqlCommandBuilder builder = new MySqlCommandBuilder(adapter);

            // Use the SqlDataAdapter's Update method to apply the changes to the database
            adapter.Update(dTable);

            // Close the connection
            connection.Close();
        }

        
    }
}