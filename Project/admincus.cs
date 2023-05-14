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
    public partial class admincus : Form
    {
        string conn = "server=localhost;user id=root; password=rootpass; database=hotel";

        public admincus()
        {
            InitializeComponent();
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true; // prevent ding sound
                textBox2.Focus(); // move focus to next TextBox
            }
        }

        private void textBox2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true; // prevent ding sound
                textBox3.Focus(); // move focus to next TextBox
            }
        }

        private void textBox3_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true; // prevent ding sound
                textBox4.Focus(); // move focus to next TextBox
            }
        }

        private void textBox4_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true; // prevent ding sound
                button1.PerformClick(); // simulate button click event
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                admin admin = new admin();

                string Query = "update customer set Lastname='" + this.textBox2.Text + "',Firstname='" + this.textBox3.Text + "',Contact='" + this.textBox4.Text + "'where cus_id=@id;";
                MySqlConnection MyConn2 = new MySqlConnection(conn);

                MySqlCommand MyCommand2 = new MySqlCommand(Query, MyConn2);
                MyCommand2.Parameters.AddWithValue("@id", admin.dataGridView1.CurrentRow.Cells[0].Value);
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
