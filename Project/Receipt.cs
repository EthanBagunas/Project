using MySql.Data.MySqlClient;
using Mysqlx.Crud;
using Org.BouncyCastle.Utilities.Collections;
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
    public partial class Receipt : Form
    {

        public string conn = "server=localhost;user id=root; password=rootpass; database=hotel";
        public string x, y, z;
        public Receipt(string list, string total, string done)
        {
            InitializeComponent();
            this.x = list;
            this.y = total;
            this.z = done;
        }



        private void Receipt_Load(object sender, EventArgs e)
        {
            using (MySqlConnection connection = new MySqlConnection(conn))
            {

                MySqlCommand cmd1 = new MySqlCommand(x, connection);
                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd1);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);

                MySqlCommand cmd2 = new MySqlCommand(y, connection);

                try
                {
                    connection.Open();


                    string rowsText1 = "";
                    foreach (DataRow row in dataTable.Rows)
                    {
                        string trans_type = row["transaction_type"].ToString();
                        rowsText1 += trans_type + "\n";
                    }
                    label1.Text = rowsText1;

                    string rowsText2 = "";
                    foreach (DataRow row in dataTable.Rows)
                    {
                        string amount = row["amount"].ToString();
                        rowsText2 += amount + "\n";
                    }
                    label2.Text = rowsText2;



                    object result = cmd2.ExecuteScalar();

                    if (result != null && result != DBNull.Value)
                    {
                        label3.Text = $"Total Amount: {result.ToString()}";
                    }
                    else
                    {
                        label3.Text = "No data found.";
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }


            }


        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string Query = z;
                MySqlConnection MyConn = new MySqlConnection(conn);
                MySqlCommand MyCommand = new MySqlCommand(Query, MyConn);
                MySqlDataReader MyReader2;
                MyConn.Open();
                MyReader2 = MyCommand.ExecuteReader();
                MyConn.Close();
                MessageBox.Show("Transaction Completed!!!");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
