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




        private void Load_Click(object sender, EventArgs e)
        {
            try
            {
                string table1 = comboBox1.SelectedItem.ToString();
                string Query = "SELECT * FROM " + table1;
                MySqlConnection myconn = new MySqlConnection(conn);
                MySqlCommand cmd = new MySqlCommand(Query, myconn);
                cmd.Parameters.AddWithValue("@select", comboBox1.SelectedItem.ToString);
                MySqlDataAdapter MyAdapter = new MySqlDataAdapter();
                MyAdapter.SelectCommand = cmd;
                DataTable dTable = new DataTable();
                MyAdapter.Fill(dTable);
                dataGridView1.DataSource = dTable;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void update_Click(object sender, EventArgs e)
        {
            string table2 = comboBox1.SelectedItem.ToString();
            string query = "Select" + table2;
            MySqlConnection myconn = new MySqlConnection(conn);
            MySqlCommand command = new MySqlCommand(query, myconn);
            MySqlDataAdapter adapter = new MySqlDataAdapter(command);

            // create a DataTable and fill it with data from the database
            DataTable table = new DataTable();
            adapter.Fill(table);



            // update the changes to the database using the data adapter
            MySqlCommandBuilder builder = new MySqlCommandBuilder(adapter);
            adapter.Update(table);

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            admincus admincus = new admincus();
            admincus.Show();
        }
    }
}