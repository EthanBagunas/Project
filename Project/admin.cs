using MySql.Data.MySqlClient;
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

        private void customer_Click(object sender, EventArgs e)
        {
            try
            {

                string Query = "select * from customer;";
                MySqlConnection myconn = new MySqlConnection(conn);
                MySqlCommand cmd = new MySqlCommand(Query, myconn);

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
    }
}
