using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Data;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Project
{
    public partial class checkin : Form
    {
        string conn = "server=localhost;user id=root; password=rootpass; database=hotel";
        public checkin()
        {
            InitializeComponent();
        }





        private void button1_Click(object sender, EventArgs e)
        {
            try
            {

                string Query = "select * from rooms;";
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
        /*string Query = "update rooms set('"+ selectedText +"') where status=@stat";*/
        private void button4_Click(object sender, EventArgs e)
        {
            string selectedText = updatebox.SelectedItem.ToString();

            try
            {
                string Query = "update rooms set status='" + selectedText + "' where rooms_id=@id";
                MySqlConnection MyConn2 = new MySqlConnection(conn);
                MySqlCommand MyCommand2 = new MySqlCommand(Query, MyConn2);
                MyCommand2.Parameters.AddWithValue("@id", dataGridView1.CurrentRow.Cells[0].Value);
                MySqlDataReader MyReader2;
                MyConn2.Open();
                MyReader2 = MyCommand2.ExecuteReader();

                while (MyReader2.Read())
                {
                }
                MyConn2.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
